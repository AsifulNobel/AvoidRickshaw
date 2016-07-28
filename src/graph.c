/*
 * graph.c
 *
 *  Created on: Jul 26, 2016
 *      Author: nobel
 */

#include <graph.h>
#include "avoidrickshaw.h"

void cairo_drawing(void *data)
{
	appdata_s *ad = data;

	double fare[7] = {9,15,8,12,6,20,7};

	int maxFare = 0;
	for(int i = 0; i < 7; i++)
	{
		if(fare[i] > maxFare)
			maxFare = fare[i];
	}

	double fractionFare[7];
	for(int i = 0; i < 7; i++)
	{
		fractionFare[i] = 0.6 - (fare[i]/maxFare) * 0.5;
	}

	int d = 0;

	if(ad->width < ad->height)
		d = ad->width;
	else
		d = ad->height;
	dlog_print(DLOG_DEBUG, LOG_TAG, "The d: %d", d);

	/* clear background as white */
	cairo_set_source_rgba(ad->cairo, 255, 255, 255, 1);
	cairo_paint(ad->cairo);

/************* fare display starts *************/


	cairo_translate(ad->cairo, 0.1 * d, 0.1 * d);
	cairo_set_line_width(ad->cairo, 5);

	/******* x and y  start ********/

	cairo_move_to (ad->cairo, 0.1 * d , 0.05 * d );
	cairo_line_to (ad->cairo, 0.1 * d, 0.6 * d);
	cairo_line_to (ad->cairo, 0.7 * d, 0.6 * d);
	cairo_set_source_rgb(ad->cairo, 0.0, 0.0, 0.0);
	cairo_stroke(ad->cairo);
	cairo_line_to (ad->cairo, 0.7 * d, 0.6 * d);

	cairo_arc(ad->cairo, 0.1 * d, 0.1 * d, 0.008 * d, 0, 2 * M_PI);
	cairo_fill(ad->cairo);
	cairo_arc(ad->cairo, 0.1 * d, 0.2 * d, 0.008 * d, 0, 2 * M_PI);
	cairo_fill(ad->cairo);
	cairo_arc(ad->cairo, 0.1 * d, 0.3 * d, 0.008 * d, 0, 2 * M_PI);
	cairo_fill(ad->cairo);
	cairo_arc(ad->cairo, 0.1 * d, 0.4 * d, 0.008 * d, 0, 2 * M_PI);
	cairo_fill(ad->cairo);
	cairo_arc(ad->cairo, 0.1 * d, 0.5 * d, 0.008 * d, 0, 2 * M_PI);
	cairo_fill(ad->cairo);
	/******* x and y  end *******/

	cairo_move_to (ad->cairo, 0.1 * d , fractionFare[0] * d );
	cairo_line_to (ad->cairo, 0.2 * d, fractionFare[1] * d);

	cairo_set_source_rgb(ad->cairo, 0.18, 0.16, 0.47);
	cairo_stroke(ad->cairo);

	cairo_line_to (ad->cairo, 0.2 * d, fractionFare[1] * d);
	cairo_line_to (ad->cairo, 0.3 * d, fractionFare[2] * d);

	cairo_set_source_rgb(ad->cairo, 0.16, 0.2, 053);
	cairo_stroke(ad->cairo);

	cairo_line_to (ad->cairo, 0.3 * d, fractionFare[2] * d);
	cairo_line_to (ad->cairo, 0.4 * d, fractionFare[3] * d);

	cairo_set_source_rgb(ad->cairo, 0.14, 0.26, 0.62);
	cairo_stroke(ad->cairo);

	cairo_line_to (ad->cairo, 0.4 * d, fractionFare[3] * d);
	cairo_line_to (ad->cairo, 0.5 * d, fractionFare[4] * d);

	cairo_set_source_rgb(ad->cairo, 0.14, 0.46, 0.73);
	cairo_stroke(ad->cairo);

	cairo_arc(ad->cairo, 0.4 * d, fractionFare[3] * d, 0.01 * d, 0, 2 * M_PI);
	cairo_fill(ad->cairo);
	cairo_line_to (ad->cairo, 0.5 * d, fractionFare[4] * d);
	cairo_line_to (ad->cairo, 0.6 * d, fractionFare[5] * d);

	cairo_set_source_rgb(ad->cairo, 0.27, 0.64, 0.84);
	cairo_stroke(ad->cairo);

	cairo_line_to (ad->cairo, 0.6 * d, fractionFare[5] * d);
	cairo_line_to (ad->cairo, 0.7 * d, fractionFare[6] * d);

	cairo_set_source_rgb(ad->cairo, 0.45, 0.81, 0.88);
	cairo_stroke(ad->cairo);

	cairo_set_source_rgb(ad->cairo, 0, 0, 1);
	cairo_arc(ad->cairo, 0.1 * d, fractionFare[0] * d, 0.01 * d, 0, 2 * M_PI);
	cairo_fill(ad->cairo);
	cairo_arc(ad->cairo, 0.2 * d, fractionFare[1] * d, 0.01 * d, 0, 2 * M_PI);
	cairo_fill(ad->cairo);
	cairo_arc(ad->cairo, 0.3 * d, fractionFare[2] * d, 0.01 * d, 0, 2 * M_PI);
	cairo_fill(ad->cairo);
	cairo_arc(ad->cairo, 0.5 * d, fractionFare[4] * d, 0.01 * d, 0, 2 * M_PI);
	cairo_fill(ad->cairo);
	cairo_arc(ad->cairo, 0.6 * d, fractionFare[5] * d, 0.01 * d, 0, 2 * M_PI);
	cairo_fill(ad->cairo);
	cairo_arc(ad->cairo, 0.7 * d, fractionFare[6] * d, 0.01 * d, 0, 2 * M_PI);
	cairo_fill(ad->cairo);

	/****** text start ********/

	cairo_set_source_rgb(ad->cairo, 0, 0, 1);
	cairo_text_extents_t extents;

	char maxF[4] = "";
	snprintf(maxF, 3,"%d" , maxFare);

	cairo_select_font_face (ad->cairo, "Sans",CAIRO_FONT_SLANT_NORMAL,
		CAIRO_FONT_WEIGHT_NORMAL);

	cairo_set_font_size (ad->cairo, 20.0);
	cairo_text_extents (ad->cairo, maxF, &extents);

	cairo_move_to (ad->cairo, 0.04 * d, 0.115 * d);
	cairo_show_text (ad->cairo, maxF);

	cairo_set_source_rgba(ad->cairo, 0, 0, 0, 1);
	const char *avgS = "avg";
	cairo_text_extents (ad->cairo, avgS, &extents);

	cairo_move_to (ad->cairo, 0.71 * d, (fractionFare[0] + fractionFare[1] + fractionFare[2] + fractionFare[3] + fractionFare[4] + fractionFare[5] + fractionFare[6])/7 * d);
	cairo_show_text (ad->cairo, avgS);

	cairo_set_font_size (ad->cairo, 30.0);
	cairo_set_source_rgba(ad->cairo, 0, 0, 1, 1);
	const char *fareString = "Fare";
	cairo_text_extents (ad->cairo, fareString, &extents);

	cairo_move_to (ad->cairo, 0.2 * d, 0.7 * d);
	cairo_show_text (ad->cairo, fareString);

	cairo_set_source_rgba(ad->cairo, 1, 0, 0, 1);
	const char *calorieString = "Calorie";
	cairo_text_extents (ad->cairo, calorieString, &extents);

	cairo_move_to (ad->cairo, 0.5 * d, 0.7 * d);
	cairo_show_text (ad->cairo, calorieString);


	/****** text ends *********/
/************* fare display ends *************/

/****************** calorie starts ***********************/
	double calorie[7] = {48,168,36,120,12,210,24};

	int maxCal = 0;
	for(int i = 0; i < 7; i++)
	{
		if(calorie[i] > maxCal)
			maxCal = calorie[i];
	}
	double fractionCal[7];
	for(int i = 0; i < 7; i++)
	{
		fractionCal[i] = 0.6 - (calorie[i]/maxCal) * 0.5;
	}

	cairo_move_to (ad->cairo, 0.1 * d, fractionCal[0] * d );
	cairo_line_to (ad->cairo, 0.2 * d, fractionCal[1] * d);

	cairo_set_source_rgb(ad->cairo, 0.7, 0.11, 0.23);
	cairo_stroke(ad->cairo);

	cairo_line_to (ad->cairo, 0.2 * d, fractionCal[1] * d);
	cairo_line_to (ad->cairo, 0.3 * d, fractionCal[2] * d);

	cairo_set_source_rgb(ad->cairo, 0.9, 0.12, 0.15);
	cairo_stroke(ad->cairo);

	cairo_line_to (ad->cairo, 0.3 * d, fractionCal[2] * d);
	cairo_line_to (ad->cairo, 0.4 * d, fractionCal[3] * d);

	cairo_set_source_rgb(ad->cairo, 0.94, 0.235, 0.16);
	cairo_stroke(ad->cairo);

	cairo_line_to (ad->cairo, 0.4 * d, fractionCal[3] * d);
	cairo_line_to (ad->cairo, 0.5 * d, fractionCal[4] * d);

	cairo_set_source_rgb(ad->cairo, 0.95, 0.48, 0.18);
	cairo_stroke(ad->cairo);

	cairo_line_to (ad->cairo, 0.5 * d, fractionCal[4] * d);
	cairo_line_to (ad->cairo, 0.6 * d, fractionCal[5] * d);

	cairo_set_source_rgb(ad->cairo, 0.97, 0.65, 0.33);
	cairo_stroke(ad->cairo);

	cairo_line_to (ad->cairo, 0.6 * d, fractionCal[5] * d);
	cairo_line_to (ad->cairo, 0.7 * d, fractionCal[6] * d);

	cairo_set_source_rgb(ad->cairo, 0.98, 0.78, 0.53);
	cairo_stroke(ad->cairo);

	cairo_set_source_rgb(ad->cairo, 1, 0, 0);
	cairo_arc(ad->cairo, 0.1 * d, fractionCal[0] * d, 0.01 * d, 0, 2 * M_PI);
	cairo_fill(ad->cairo);
	cairo_arc(ad->cairo, 0.2 * d, fractionCal[1] * d, 0.01 * d, 0, 2 * M_PI);
	cairo_fill(ad->cairo);
	cairo_arc(ad->cairo, 0.3 * d, fractionCal[2] * d, 0.01 * d, 0, 2 * M_PI);
	cairo_fill(ad->cairo);
	cairo_arc(ad->cairo, 0.4 * d, fractionCal[3] * d, 0.01 * d, 0, 2 * M_PI);
	cairo_fill(ad->cairo);
	cairo_arc(ad->cairo, 0.5 * d, fractionCal[4] * d, 0.01 * d, 0, 2 * M_PI);
	cairo_fill(ad->cairo);
	cairo_arc(ad->cairo, 0.6 * d, fractionCal[5] * d, 0.01 * d, 0, 2 * M_PI);
	cairo_fill(ad->cairo);
	cairo_arc(ad->cairo, 0.7 * d, fractionCal[6] * d, 0.01 * d, 0, 2 * M_PI);
	cairo_fill(ad->cairo);

/****************** calorie ends   ***********************/


	/****** text start ********
	cairo_text_extents_t extents2;
	cairo_set_source_rgb(ad->cairo, 1, 0, 0);
	const char *maxC;
	sprintf(maxC,"%d" , maxFare);
	cairo_select_font_face (ad->cairo, "Sans",CAIRO_FONT_SLANT_NORMAL,
		CAIRO_FONT_WEIGHT_NORMAL);
	cairo_set_font_size (ad->cairo, 20.0);

	cairo_text_extents (ad->cairo, maxC, &extents2);

	cairo_move_to (ad->cairo, 0.05 * d, 0.08 * d);
	cairo_show_text (ad->cairo, maxC);
	*/
	/****** text ends *********/
	/****** faded lines start **********/
	cairo_move_to (ad->cairo, 0.1 * d , 0.1 * d );
	cairo_line_to (ad->cairo, 0.7 * d, 0.1 * d);

	cairo_set_source_rgba(ad->cairo, 0, 0, 0, 0.2);
	cairo_stroke(ad->cairo);

	cairo_move_to (ad->cairo, 0.1 * d, (fractionFare[0] + fractionFare[1] + fractionFare[2] + fractionFare[3] + fractionFare[4] + fractionFare[5] + fractionFare[6])/7 * d );
	cairo_line_to (ad->cairo, 0.7 * d, (fractionFare[0] + fractionFare[1] + fractionFare[2] + fractionFare[3] + fractionFare[4] + fractionFare[5] + fractionFare[6])/7 * d);

	cairo_set_source_rgba(ad->cairo, 1, 0, 0, 0.2);
	cairo_stroke(ad->cairo);

	/****** faded lines ends **********/

	cairo_rectangle(ad->cairo, 0, 0, 0.8 * d, 0.8 * d);
	cairo_set_source_rgb(ad->cairo, 0, 0, 0);
	cairo_stroke(ad->cairo);
	cairo_surface_flush(ad->surface);

	/* display cairo drawin on screen */
	unsigned char * imageData = cairo_image_surface_get_data(cairo_get_target(ad->cairo));
	evas_object_image_data_set(ad->img, imageData);
	evas_object_image_data_update_add(ad->img, 0, 0, ad->width, ad->height);
}
