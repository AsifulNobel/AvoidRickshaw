#if !defined(_VIEW_H)
#define _VIEW_H

typedef void (*view_button_clicked_callback_t)(void);

Eina_Bool view_create(void *user_data);
Evas_Object *view_create_win(const char *pkg_name);
Evas_Object *view_create_layout(Evas_Object *parent);
Evas_Object *view_create_conformant_without_indicator(Evas_Object *win);
void view_set_gps_ok_text(bool gps_ok);
void view_set_steps_count(int count);
void view_set_total_distance(double distance);
void view_set_fare(int fare);
//void view_set_calories(double calories);
void view_set_button_callbacks(view_button_clicked_callback_t start_button_clicked_cb,
		view_button_clicked_callback_t stop_button_clicked_cb,
		view_button_clicked_callback_t history_button_clicked_cb);
void view_destroy(void);

#endif
