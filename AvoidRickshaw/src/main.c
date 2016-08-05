#include <tizen.h>
#include <system_settings.h>

#include "avoidrickshaw.h"
#include "view.h"
#include "data.h"

static void _on_position_changed_cb(double total_distance);

/**
 * @brief Hook to take necessary actions before main event loop starts.
 * Initialize UI resources and application's data.
 * If this function returns true, the main loop of application starts.
 * If this function returns false, the application is terminated.
 */
static bool app_create(void *user_data)
{
	if (!view_create(NULL))
			return false;

	view_set_button_callbacks(data_tracking_start, data_tracking_stop, data_show_db);
	data_set_position_changed_callback(_on_position_changed_cb);
	data_set_steps_count_changed_callback(view_set_steps_count);
	data_set_fare_changed_callback(view_set_fare);
	data_set_calorie_changed_callback(view_set_calories);

	if (!data_initialize())
		return false;

	view_set_gps_ok_text(data_gps_enabled_get());

	return true;
}

/**
 * @brief This callback function is called when another application
 * sends a launch request to the application.
 */
static void app_control(app_control_h app_control, void *user_data)
{
	/* Handle the launch request. */
}

/**
 * @brief This callback function is called each time
 * the application is completely obscured by another application
 * and becomes invisible to the user.
 */
static void app_pause(void *user_data)
{
	/* Take necessary actions when application becomes invisible. */
}

/**
 * @brief This callback function is called each time
 * the application becomes visible to the user.
 */
static void app_resume(void *user_data)
{
	/* Take necessary actions when application becomes visible. */
}

/**
 * @brief This callback function is called once after the main loop of the application exits.
 */
static void app_terminate(void *user_data)
{
	/* Release all resources. */
	data_finalize();
	view_destroy();
}

/**
 * @brief This function will be called when the language is changed.
 */
static void ui_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	/* APP_EVENT_LANGUAGE_CHANGED */
	char *locale = NULL;

	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE, &locale);

	if (locale != NULL) {
		elm_language_set(locale);
		free(locale);
	}
	return;
}

/**
 * @brief Main function of the application.
 */
int main(int argc, char *argv[])
{
	int ret;

	ui_app_lifecycle_callback_s event_callback = {0, };
	app_event_handler_h handlers[5] = {NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	/*
	 * If you want to handle more events,
	 * please check the application life cycle guide.
	 */
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, NULL);

	ret = ui_app_main(argc, argv, &event_callback, NULL);
	if (ret != APP_ERROR_NONE)
		dlog_print(DLOG_ERROR, LOG_TAG, "ui_app_main() failed. err = %d", ret);

	return ret;
}

/**
 * @brief Internal callback function invoked on position obtained from GPS change.
 * This callback function is attached by the data_set_position_changed_callback() function
 * and it is responsible for pedometer information display.
 * @param[in] total_distance The total distance passed in current measurement session.
 * @param[in] step_length The estimation of average step length.
 */
static void _on_position_changed_cb(double total_distance)
{
	 view_set_total_distance(total_distance);
}
