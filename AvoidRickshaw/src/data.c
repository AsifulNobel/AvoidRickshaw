#include <locations.h>
#include <math.h>
#include <sensor.h>
#include <Ecore.h>
#include <app_preference.h>
#include "avoidrickshaw.h"
#include "data.h"
#include "Sqlitedbhelper.h"
#include "view.h"

#define TRESHOLD 0.2
#define MAX_ACCEL_INIT_VALUE 1000
#define DOUBLE_COMPARIZON_THRESHOLD 0.0001

#define RADIUS 6371
#define TO_RAD (3.14159265/180)
#define KM 1000
#define LAT_UNINITIATED DBL_MAX
#define LONG_UNINITIATED DBL_MAX

static bool initialized = false;

static struct data_info {
	location_manager_h location_manager;
	double total_distance;
	double prev_latitude;
	double prev_longitude;
	data_position_changed_callback_t position_changed_callback;
	data_gps_steps_count_callback_t steps_count_changed_callback;
	data_fare_count_callback_t fare_count_changed_callback;
	data_calorie_count_callback_t calorie_count_changed_callback;
	sensor_listener_h acceleration_listener;
	double prev_acc_av;
	double init_acc_av;
	int prev_steps_count;
	int steps_count;
	double start_time;
	double calories;
	double weight;
} s_info = {
	.location_manager = NULL,
	.total_distance = 0.0,
	.prev_latitude = LAT_UNINITIATED,
	.prev_longitude = LONG_UNINITIATED,
	.position_changed_callback = NULL,
	.steps_count_changed_callback = NULL,
	.fare_count_changed_callback = NULL,
	.calorie_count_changed_callback = NULL,
	.acceleration_listener = NULL,
	.prev_acc_av = MAX_ACCEL_INIT_VALUE,
	.init_acc_av = MAX_ACCEL_INIT_VALUE,
	.prev_steps_count = 0,
	.steps_count = 0,
	.start_time = 0.0,
	.calories = 0.0,
	.weight = 70.0
};

static void _pos_updated_cb(double latitude, double longitude, double altitude, time_t timestamp, void *data);
static void _accel_cb(sensor_h sensor, sensor_event_s *event, void *data);
static bool _data_distance_tracker_start(void);
static bool _data_distance_tracker_stop(void);
static bool _data_distance_tracker_init(void);
static void _data_distance_tracker_destroy(void);
static bool _data_acceleration_sensor_start(void);
static bool _data_acceleration_sensor_stop(void);
static bool _data_acceleration_sensor_init_handle(void);
static void _data_acceleration_sensor_release_handle(void);
static int count_fare(void);
void _data_save_db(void);
static void calorieBurner();

/**
 * @brief Initialization function for data module.
 * @return This function returns 'EINA_TRUE' if the data module was initialized successfully,
 * otherwise 'EINA_FALSE' is returned.
 */
Eina_Bool data_initialize(void)
{
	/*
	 * If you need to initialize application data,
	 * please use this function.
	 */
	if (data_gps_enabled_get())
		_data_distance_tracker_init();

	return _data_acceleration_sensor_init_handle();
}

/**
 * @brief Finalization function for data module.
 */
void data_finalize(void)
{
	/*
	 * If you need to finalize application data,
	 * please use this function.
	 */
	_data_distance_tracker_destroy();
	_data_acceleration_sensor_release_handle();
}

/**
 * @brief Starts the activity tracking.
 */
bool data_tracking_start(void)
{
	if(!initialized && data_gps_enabled_get()){
		bool track = _data_distance_tracker_start();
		bool accel_sensor = _data_acceleration_sensor_start();
		s_info.start_time = ecore_time_get();
		initialized = true;

		/* Re-initialize count on start of another session */
		if (!s_info.steps_count) {
			s_info.steps_count_changed_callback(s_info.steps_count);
			s_info.position_changed_callback(s_info.total_distance);
			s_info.fare_count_changed_callback(0);
			view_set_calories(s_info.calories);
		}

		const char key_name[] = "weight\0";
		bool existing;

		preference_is_existing(key_name, &existing);

		if (existing) {
			preference_get_double(key_name, &s_info.weight);
		}

		if (track && accel_sensor)
			return true;
		else
			return false;
	}
	return false;
}

/**
 * @brief Stops the activity tracking.
 */
bool data_tracking_stop(void)
{
	if(initialized) {
		bool track = _data_distance_tracker_stop();
		bool accel_sensor = _data_acceleration_sensor_stop();
		initialized = false;

		if (track && accel_sensor){
			return true;
		}
		else
			return false;
	}
	else
		return false;
}

/**
 * @brief Attaches the position changed callback function.
 * @param[in] position_changed_callback The callback function to be attached.
 */
void data_set_position_changed_callback(data_position_changed_callback_t position_changed_callback)
{
	s_info.position_changed_callback = position_changed_callback;
}

/**
 * @brief Attaches the steps counter changed callback function.
 * @param[in] steps_count_callback The callback function to be attached.
 */
void data_set_steps_count_changed_callback(data_gps_steps_count_callback_t steps_count_callback)
{
	s_info.steps_count_changed_callback = steps_count_callback;
}

/*
 * @brief Attaches fare count changed callback function.
 * @param[in] fare_count_callback The callback function to be attached.
 */
void data_set_fare_changed_callback(data_fare_count_callback_t fare_count_callback)
{
	s_info.fare_count_changed_callback = fare_count_callback;
}


/*
 * @brief Attaches calorie count changed callback function.
 * @param[in] calorie_count_callback The callback function to be attached.
 */
void data_set_calorie_changed_callback(data_calorie_count_callback_t calorie_count_callback)
{
	s_info.calorie_count_changed_callback = calorie_count_callback;
}

/**
 * @brief Obtains the state of the GPS module and attaches a callback function
 * for its state change.
 * @return This function returns 'true' if the GPS module is enabled,
 * otherwise 'false' is returned.
 */
bool data_gps_enabled_get(void)
{
	bool gps_enabled = false;

	/* Check if GPS is enabled and set callback for GPS status updates */
	int ret = location_manager_is_enabled_method(LOCATIONS_METHOD_GPS, &gps_enabled);
	if (ret != LOCATIONS_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to get GPS status");
		return false;
	}

	if (!gps_enabled) {
			dlog_print(DLOG_ERROR, LOG_TAG, "GPS not enabled");
			return false;
	}

	return true;
}

/**
 * @brief Function invoked after updating total distance to count Rickshaw fare. After calculating
 *  This function calculates fare of the rickshaw

 *Function parameter

 *distance(double) - it is the distance walked in Kilometer
 *baseFare (int) - holds the base fare of rickshaw
 *farePerUnitDistance - holds the per unit distance fare after covering the base distance

 *Return value -
 Rickshaw fare

 **farePerUnitDistance is now currently a constant attribute
 **It uses a plus method

 References -

 Max Plus Methods for NonLinear Control and Estimation
 * @return Calculated fare.
 */
int count_fare(void) {
	int baseFare = 10;
	int farePerUnitDistance = 5;
	int fare;

	double baseDistance = 1.0;

	fare = (int) (0.015 * s_info.total_distance);

	dlog_print(DLOG_DEBUG, LOG_TAG, "Counting Fare, fare: %d", fare);
	s_info.fare_count_changed_callback(fare);

	return fare;
}

/**
 * @brief Internal callback function invoked on position obtained from GPS module update.
 * This callback function is attached with the location_manager_set_position_updated_cb() function.
 * It is responsible for total distance passed and number of steps computation.
 * These values are computed based on coordinates obtained from GPS module.
 * @param[in] latitude The value of latitude.
 * @param[in] longitude The value of longitude.
 * @param[in] altitude The value of altitude.
 * @param[in] data The user data passed to the callback attachment function.
 */
static void _pos_updated_cb(double latitude, double longitude, double altitude, time_t timestamp, void *data)
{
	int ret;
	double distance = 0;

	location_accuracy_level_e gps_accuracy;
	double horizontal_acc = 0.0;
	double vertical_acc = 0.0;

	location_manager_get_accuracy(s_info.location_manager, & gps_accuracy, &horizontal_acc, &vertical_acc);

	dlog_print(DLOG_DEBUG, LOG_TAG, "horizontal_acc: %lf, vertical_acc: %lf", horizontal_acc, vertical_acc);

	/* If callback is called for the first time and step count is non-zero, set previous values */
	if (fabs(s_info.prev_latitude - LAT_UNINITIATED) < DOUBLE_COMPARIZON_THRESHOLD &&
		fabs(s_info.prev_longitude - LONG_UNINITIATED) < DOUBLE_COMPARIZON_THRESHOLD &&
		s_info.steps_count > 0) {
		s_info.prev_latitude = latitude;
		s_info.prev_longitude = longitude;

		return;
	}

	dlog_print(DLOG_DEBUG, LOG_TAG, "previous lat: %lf, previous long: %lf", s_info.prev_latitude, s_info.prev_longitude);
	dlog_print(DLOG_DEBUG, LOG_TAG, "current lat: %lf, current long: %lf", latitude, longitude);

	/* Calculate distance between previous and current location data and
	 * update view */
	ret = location_manager_get_distance(latitude, longitude, s_info.prev_latitude, s_info.prev_longitude, &distance);
	if (ret != LOCATIONS_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to get distance");
		return;
	}

	if (s_info.steps_count > s_info.prev_steps_count) {
		// If user is actually walking/running

		s_info.total_distance += distance;
		dlog_print(DLOG_DEBUG, LOG_TAG, "total distance: %lf meters", s_info.total_distance);

		/* Set new prev values */
		s_info.prev_latitude = latitude;
		s_info.prev_longitude = longitude;
		s_info.prev_steps_count = s_info.steps_count;

		if (s_info.position_changed_callback)
			s_info.position_changed_callback(s_info.total_distance);

		count_fare();
		calorieBurner();
	}
	else if (distance > 0) {
		// If user is moving, but not walking/running

		s_info.prev_latitude = latitude;
		s_info.prev_longitude = longitude;;

		dlog_print(DLOG_DEBUG, LOG_TAG, "because step count did not update, saving position only.");
	}
	else {
		dlog_print(DLOG_DEBUG, LOG_TAG, "because step count and distances did not update, nothing to do.");
	}
}

/**
 * @brief Internal function responsible for distance tracker initialization.
 * This function creates the location manager instance and attaches position change callback.
 * @return This function returns 'true' if the distance tracker was initialized successfully,
 * otherwise 'false' is returned.
 */
static bool _data_distance_tracker_init(void)
{
	/* Create location manager and set callback for position updates */
	int ret = location_manager_create(LOCATIONS_METHOD_HYBRID, &s_info.location_manager);
	if (ret != LOCATIONS_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to create location manager");
		return false;
	}


	ret = location_manager_set_position_updated_cb(s_info.location_manager, _pos_updated_cb, 4, NULL);
	if (ret != LOCATIONS_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to register callback for position update");
		_data_distance_tracker_destroy();
		return false;
	}

	return true;
}

/**
 * @brief Internal function responsible for distance tracker destruction.
 */
static void _data_distance_tracker_destroy(void)
{
	if (!s_info.location_manager)
		return;

	if (location_manager_destroy(s_info.location_manager) != LOCATIONS_ERROR_NONE)
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to destroy location manager");

}

/**
 * @brief Internal function responsible for distance tracker starting.
 */
static bool _data_distance_tracker_start(void)
{
	if (!s_info.location_manager && !_data_distance_tracker_init()) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Location manager not initialized");
		return false;
	}

	if (location_manager_start(s_info.location_manager) != LOCATIONS_ERROR_NONE){
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to start location manager");
		return false;
	}
	return true;
}

/**
 * @brief Internal function responsible for distance tracker stopping.
 */
static bool _data_distance_tracker_stop(void)
{
	if (!s_info.location_manager)
		return false;

	if (location_manager_stop(s_info.location_manager) != LOCATIONS_ERROR_NONE){
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to stop location manager");
		return false;
	}

	// Save info to database
	_data_save_db();

	/* Re-initialize distance and steps */
	s_info.total_distance = 0.0;
	s_info.steps_count = 0;
	s_info.calories = 0.0;

	return true;
}

/**
 * @brief Internal callback function invoked on acceleration measurement acquisition.
 * This callback function is attached with the sensor_listener_set_event_cb() function.
 * It is responsible for acceleration peaks detection which is assumed to occur on step making.
 * @param[in] sensor The accelerometer sensor handle.
 * @param[in] event The event structure containing the acquired data.
 * @param[in] data The user data passed to the callback attachment function.
 */
static void _accel_cb(sensor_h sensor, sensor_event_s *event, void *data)
{
	/* Get current average value of acceleration on three axes */
	double current_acc_av = (fabs(event->values[0]) + fabs(event->values[1]) + fabs(event->values[2])) / 3;

	/* If initial average acceleration value is not set, do it now */
	if (fabs(s_info.init_acc_av - MAX_ACCEL_INIT_VALUE) < DOUBLE_COMPARIZON_THRESHOLD) {
		s_info.init_acc_av = s_info.prev_acc_av = current_acc_av;
		return;
	}

	/* Register a drop of acceleration average value */
	if ((s_info.prev_acc_av > s_info.init_acc_av && s_info.init_acc_av - current_acc_av > TRESHOLD)) {
		s_info.steps_count++;
		if (s_info.steps_count_changed_callback)
			s_info.steps_count_changed_callback(s_info.total_distance/.6);
	}

	s_info.prev_acc_av = current_acc_av;
}

/**
 * @brief Internal function responsible for acceleration sensor initialization
 * and data acquisition callback function attachment.
 * @return This function returns 'true' if the acceleration sensor was initialized successfully,
 * otherwise 'false' is returned.
 */
static bool _data_acceleration_sensor_init_handle(void)
{
	sensor_h sensor;
	bool supported = false;

	int ret = sensor_is_supported(SENSOR_ACCELEROMETER, &supported);
	if (ret != SENSOR_ERROR_NONE || !supported) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Accelerometer sensor not supported on current device");
		return false;
	}

	ret = sensor_get_default_sensor(SENSOR_ACCELEROMETER, &sensor);
	if (ret != SENSOR_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to get default accelerometer sensor");
		return false;
	}

	ret = sensor_create_listener(sensor, &s_info.acceleration_listener);
	if (ret != SENSOR_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to create accelerometer sensor");
		return false;
	}

	ret = sensor_listener_set_event_cb(s_info.acceleration_listener, 200, _accel_cb, NULL);
	if (ret != SENSOR_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to set event callback for sensor listener");
		sensor_destroy_listener(s_info.acceleration_listener);
		s_info.acceleration_listener = NULL;
		return false;
	}

	ret = sensor_listener_set_option(s_info.acceleration_listener, SENSOR_OPTION_ALWAYS_ON);
	if (ret != SENSOR_ERROR_NONE)
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to set sensor's always on option");

	return true;
}

/**
 * @brief Internal function responsible for acceleration listener destruction.
 */
static void _data_acceleration_sensor_release_handle(void)
{
	if (!s_info.acceleration_listener)
		return;

	if (sensor_destroy_listener(s_info.acceleration_listener) != SENSOR_ERROR_NONE)
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to destroy accelerometer sensor listener");

	s_info.acceleration_listener = NULL;
}

/**
 * @brief Internal function responsible for acceleration sensor staring.
 */
static bool _data_acceleration_sensor_start(void)
{
	if (!s_info.acceleration_listener)
		return false;

	if (sensor_listener_start(s_info.acceleration_listener) != SENSOR_ERROR_NONE){
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to start accelerometer sensor listener");
		return false;
	}
	return true;
}

/**
 * @brief Internal function responsible for acceleration sensor stopping.
 */
static bool _data_acceleration_sensor_stop(void)
{
	if (!s_info.acceleration_listener)
		return false;

	if (sensor_listener_stop(s_info.acceleration_listener) != SENSOR_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to stop accelerometer sensor listener");
		return false;
	}

	/* Reset init/prev acceleration data */
	s_info.init_acc_av = s_info.prev_acc_av = MAX_ACCEL_INIT_VALUE;

	return true;
}

/*
 * @Brief Callback function for saving session info in database.
 */
void _data_save_db(void) {
	dlog_print(DLOG_DEBUG, LOG_TAG, "Stop button clicked!");

	int temp;
	temp = count_fare();
	int num_rows = 0;

	int ret;
	ret = initdb();
	dlog_print(DLOG_DEBUG, LOG_TAG, "Called initdb function...Status: %d", ret);

	QueryData* msgdata;

	/*allocate msgdata memory. this will be used for retrieving data from database*/
	msgdata = (QueryData*) calloc (1, sizeof(QueryData));

	ret = getMsgByCurrentDate(&msgdata, &num_rows);

	if (!ret){
		// If starting database for first time, populate database for App Demo.
		if (num_rows == 0) {
			populateDb();
		}

		if(num_rows > 0) {
			msgdata->distance += (float) s_info.total_distance;
			msgdata->fare += temp;
			msgdata->steps += s_info.total_distance/0.6;
			msgdata->calories += (float) s_info.calories;

			dlog_print(DLOG_DEBUG, LOG_TAG, "Saving, fare: %d, calories: %.2f", msgdata->fare, msgdata->calories);

			/*Update existing row in DB*/
			if (msgdata->steps > 0 && msgdata->distance > 0)
				ret = updateInfoDb(msgdata->distance, msgdata->steps, msgdata->calories, msgdata->fare);
			else
				return;
		}
		else {
			msgdata->distance = (float) s_info.total_distance;
			msgdata->fare = temp;
			msgdata->steps = s_info.total_distance/0.6;
			msgdata->calories = (float) s_info.calories;

			dlog_print(DLOG_DEBUG, LOG_TAG, "Saving, fare: %d, calories: %.2f", msgdata->fare, msgdata->calories);

			/*Insert new row in DB*/
			if (msgdata->steps > 0 && msgdata->distance > 0)
				ret = insertIntoDb(msgdata->distance, msgdata->steps, msgdata->calories, msgdata->fare);
			else
				return;
		}
	}
	else {
		dlog_print(DLOG_ERROR, LOG_TAG, "Error querying current date info in DB!");
	}

	dlog_print(DLOG_DEBUG, LOG_TAG, "Saving session data in database...Status: %d", ret);
}

/*
 * @Brief Callback function for 'Show History' button
 */
void data_show_db(void) {
	dlog_print(DLOG_DEBUG, LOG_TAG, "'Show History' button clicked!");
}

/**
 * @brief Calculates burnt calories while walking or running.
 *
 *This function calculates calories burned;

 *Function parameter

 *distance(double) - it is the distance walked in Kilometer
 *time (double) - total amount of time walked in Hour
 *weight (double) - body weight in KG ;

 *Return Value -
 *calories burned in the process

 **This function thinks that Walking surface grade is 0%

 *References -

 *Margaria R, Cerretelli P, Aghemo P, Sassi G. Energy cost of running. J Appl Physiol. 1963 Mar;18:367-70.

 *Margaria, R., 1938. Sulla fisiologia, e specialmente sul consumo energetico, della marcia e della corsa a varie velocita ed inclinazioni del terreno. Atti Accad. Naz. Lincei Classe Sci. Fis. Mat. Nat. Serie VI 7, 299–368.

 *American College of Sports Medecine: ACSM's Metabolic Calculations Handbook, 2007, Baltimore, MD. Also available online at: ACSM Metabolic Equations

**/

static void calorieBurner()
{
	double tempDistance = s_info.total_distance / 1000;
    double elapsedTime = ecore_time_get(); // Gets current time in seconds

    elapsedTime -= s_info.start_time;
    elapsedTime = elapsedTime / 3600; // converts elapsed time in seconds to hour

    dlog_print(DLOG_DEBUG, LOG_TAG, "elapsed time: %lf hour", elapsedTime);

    s_info.calories = 0.0215 * tempDistance * tempDistance * tempDistance
    		- 0.1765 * tempDistance * tempDistance + 0.8710 * tempDistance
    		+ 1.4577 * s_info.weight * elapsedTime ;

    // If travelled distance is non-zero, then change 'calories burnt' value shown in view
    if (s_info.total_distance > 0)
    	s_info.calorie_count_changed_callback(s_info.calories);
}
