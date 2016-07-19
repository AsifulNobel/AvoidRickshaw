#if !defined(_DATA_H)
#define _DATA_H

typedef void (*data_position_changed_callback_t)(double);
typedef void (*data_gps_steps_count_callback_t)(int);
typedef void (*data_fare_count_callback_t)(int);
typedef void (*data_calorie_count_callback_t)(double);


Eina_Bool data_initialize(void);
void data_finalize(void);
void data_tracking_start(void);
void data_tracking_stop(void);
void data_show_db(void);
bool data_gps_enabled_get(void);
void data_set_position_changed_callback(data_position_changed_callback_t position_changed_callback);
void data_set_steps_count_changed_callback(data_gps_steps_count_callback_t steps_count_callback);
void data_set_fare_changed_callback(data_fare_count_callback_t fare_count_callback);
void data_set_calorie_changed_callback(data_calorie_count_callback_t calorie_count_callback);

#endif
