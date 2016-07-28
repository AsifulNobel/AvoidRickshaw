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
	double fare[28] = {10,9,8,11,14,18,12,13,18,17,24,7};
	double calorie[28] = {24,19,18,26,30,36,28,30,38,38,60,12};
//	double fare[7] = {9,15,8,12,6,20,12};
//	double calorie[7] = {48,168,36,120,12,210,24};
	double maxCal = 0, maxFare = 0;

	int size = sizeof(fare)/sizeof(double), count = 0;
	double totalCalorie = 0, totalFare = 0;

	int totDays = 0;
	for(int i = 0; i < size && calorie[i] > 0; i++)
	{
		totalCalorie += calorie[i];
		totalFare += fare[i];
		totDays++;
	}
	double fractionFare[7], fractionCal[7];

	double totalWeeklyFare = 0, totalWeeklyCalorie = 0;
	if(totDays<=7)
	{
		for(int i = 0; i < totDays; i++)
		{
			totalWeeklyFare += fare[i];
			if(fare[i] > maxFare)
				maxFare = fare[i];
			totalWeeklyCalorie += calorie[i];
			if(calorie[i] > maxCal)
				maxCal = calorie[i];
			count++;
		}

		for(int i = 0; i < 7 && i < size; i++)
		{
			fractionFare[i] = 0.6 - (fare[i]/maxFare) * 0.5;
			fractionCal[i] = 0.6 - (calorie[i]/maxCal) * 0.5;
		}
	}
	else
	{
		for(int i = totDays - 7; i <totDays; i++)
		{
			totalWeeklyFare += fare[i];
			if(fare[i] > maxFare)
				maxFare = fare[i];
			totalWeeklyCalorie += calorie[i];
			if(calorie[i] > maxCal)
				maxCal = calorie[i];
			count++;
		}

		for(int i = totDays - 7, j = 0; i <totDays; i++, j++)
		{
			fractionFare[j] = 0.6 - (fare[i]/maxFare) * 0.5;
			fractionCal[j] = 0.6 - (calorie[i]/maxCal) * 0.5;
		}
	}
	double weeklyCalorieAverage = totalWeeklyCalorie/count;
	double avg = 0.6 - (weeklyCalorieAverage/maxCal) * 0.5;

	int d = 0;
	if(ad->width < ad->height)
		d = ad->width;
	else
		d = ad->height;
	dlog_print(DLOG_DEBUG, LOG_TAG, "The d: %d", d);

	/* clear background as white */
	cairo_set_source_rgba(ad->cairo, 1, 1, 1, 1);
	cairo_paint(ad->cairo);

	cairo_translate(ad->cairo, 0.05 * d, 0.1 * d);
	cairo_set_line_width(ad->cairo, 5);

/******* x and y  start ********/

	cairo_move_to (ad->cairo, 0.1 * d , 0.05 * d );
	cairo_line_to (ad->cairo, 0.1 * d, 0.6 * d);
	cairo_line_to (ad->cairo, 0.7 * d, 0.6 * d);
	cairo_set_source_rgb(ad->cairo, 0.0, 0.0, 0.0);
	cairo_stroke(ad->cairo);
	cairo_line_to (ad->cairo, 0.7 * d, 0.6 * d);

	for(double i = 0.1; i <= 0.5; i+=0.1)
	{
		cairo_arc(ad->cairo, 0.1 * d, i * d, 0.008 * d, 0, 2 * M_PI);
		cairo_fill(ad->cairo);
	}

/******* x and y  end *******/

/****************** calorie starts ***********************/

	cairo_set_source_rgb(ad->cairo, 1, 0, 0);
	cairo_arc(ad->cairo, 0.1 * d, fractionCal[0] * d, 0.01 * d, 0, 2 * M_PI);
	cairo_fill(ad->cairo);

	if(count>=2)
	{
		cairo_move_to (ad->cairo, 0.1 * d, fractionCal[0] * d );
		cairo_line_to (ad->cairo, 0.2 * d, fractionCal[1] * d);
		cairo_set_source_rgb(ad->cairo, 0.7, 0.11, 0.23);
		cairo_stroke(ad->cairo);

		cairo_set_source_rgb(ad->cairo, 1, 0, 0);
		cairo_arc(ad->cairo, 0.2 * d, fractionCal[1] * d, 0.01 * d, 0, 2 * M_PI);
		cairo_fill(ad->cairo);

		if(count>=3)
		{
			cairo_line_to (ad->cairo, 0.2 * d, fractionCal[1] * d);
			cairo_line_to (ad->cairo, 0.3 * d, fractionCal[2] * d);
			cairo_set_source_rgb(ad->cairo, 0.9, 0.12, 0.15);
			cairo_stroke(ad->cairo);

			cairo_set_source_rgb(ad->cairo, 1, 0, 0);
			cairo_arc(ad->cairo, 0.3 * d, fractionCal[2] * d, 0.01 * d, 0, 2 * M_PI);
			cairo_fill(ad->cairo);

			if(count>=4)
			{
				cairo_line_to (ad->cairo, 0.3 * d, fractionCal[2] * d);
				cairo_line_to (ad->cairo, 0.4 * d, fractionCal[3] * d);
				cairo_set_source_rgb(ad->cairo, 0.94, 0.235, 0.16);
				cairo_stroke(ad->cairo);

				cairo_set_source_rgb(ad->cairo, 1, 0, 0);
				cairo_arc(ad->cairo, 0.4 * d, fractionCal[3] * d, 0.01 * d, 0, 2 * M_PI);
				cairo_fill(ad->cairo);

				if(count>=5)
				{
					cairo_line_to (ad->cairo, 0.4 * d, fractionCal[3] * d);
					cairo_line_to (ad->cairo, 0.5 * d, fractionCal[4] * d);
					cairo_set_source_rgb(ad->cairo, 0.95, 0.48, 0.18);
					cairo_stroke(ad->cairo);

					cairo_set_source_rgb(ad->cairo, 1, 0, 0);
					cairo_arc(ad->cairo, 0.5 * d, fractionCal[4] * d, 0.01 * d, 0, 2 * M_PI);
					cairo_fill(ad->cairo);

					if(count>=6)
					{
						cairo_line_to (ad->cairo, 0.5 * d, fractionCal[4] * d);
						cairo_line_to (ad->cairo, 0.6 * d, fractionCal[5] * d);
						cairo_set_source_rgb(ad->cairo, 0.97, 0.65, 0.33);
						cairo_stroke(ad->cairo);

						cairo_set_source_rgb(ad->cairo, 1, 0, 0);
						cairo_arc(ad->cairo, 0.6 * d, fractionCal[5] * d, 0.01 * d, 0, 2 * M_PI);
						cairo_fill(ad->cairo);

						if(count>=7)
						{
							cairo_line_to (ad->cairo, 0.6 * d, fractionCal[5] * d);
							cairo_line_to (ad->cairo, 0.7 * d, fractionCal[6] * d);
							cairo_set_source_rgb(ad->cairo, 0.98, 0.78, 0.53);
							cairo_stroke(ad->cairo);

							cairo_set_source_rgb(ad->cairo, 1, 0, 0);
							cairo_arc(ad->cairo, 0.7 * d, fractionCal[6] * d, 0.01 * d, 0, 2 * M_PI);
							cairo_fill(ad->cairo);
						}
					}
				}
			}
		}
	}


/****************** calorie ends   ***********************/

/************* fare display starts *************/
	cairo_set_source_rgb(ad->cairo, 0, 0, 1);
	cairo_arc(ad->cairo, 0.1 * d, fractionFare[0] * d, 0.01 * d, 0, 2 * M_PI);
	cairo_fill(ad->cairo);

	if(count>=2)
	{
		cairo_move_to (ad->cairo, 0.1 * d , fractionFare[0] * d );
		cairo_line_to (ad->cairo, 0.2 * d, fractionFare[1] * d);
		cairo_set_source_rgb(ad->cairo, 0.18, 0.16, 0.47);
		cairo_stroke(ad->cairo);

		cairo_set_source_rgb(ad->cairo, 0, 0, 1);
		cairo_arc(ad->cairo, 0.2 * d, fractionFare[1] * d, 0.01 * d, 0, 2 * M_PI);
		cairo_fill(ad->cairo);

		if(count>=3)
		{
			cairo_line_to (ad->cairo, 0.2 * d, fractionFare[1] * d);
			cairo_line_to (ad->cairo, 0.3 * d, fractionFare[2] * d);
			cairo_set_source_rgb(ad->cairo, 0.16, 0.2, 053);
			cairo_stroke(ad->cairo);

			cairo_set_source_rgb(ad->cairo, 0, 0, 1);
			cairo_arc(ad->cairo, 0.3 * d, fractionFare[2] * d, 0.01 * d, 0, 2 * M_PI);
			cairo_fill(ad->cairo);


			if(count>=4)
			{
				cairo_line_to (ad->cairo, 0.3 * d, fractionFare[2] * d);
				cairo_line_to (ad->cairo, 0.4 * d, fractionFare[3] * d);
				cairo_set_source_rgb(ad->cairo, 0.14, 0.26, 0.62);
				cairo_stroke(ad->cairo);

				cairo_set_source_rgb(ad->cairo, 0, 0, 1);
				cairo_arc(ad->cairo, 0.4 * d, fractionFare[3] * d, 0.01 * d, 0, 2 * M_PI);
				cairo_fill(ad->cairo);

				if(count>=5)
				{
					cairo_line_to (ad->cairo, 0.4 * d, fractionFare[3] * d);
					cairo_line_to (ad->cairo, 0.5 * d, fractionFare[4] * d);
					cairo_set_source_rgb(ad->cairo, 0.14, 0.46, 0.73);
					cairo_stroke(ad->cairo);

					cairo_set_source_rgb(ad->cairo, 0, 0, 1);
					cairo_arc(ad->cairo, 0.5 * d, fractionFare[4] * d, 0.01 * d, 0, 2 * M_PI);
					cairo_fill(ad->cairo);

					if(count>=6)
					{
						cairo_line_to (ad->cairo, 0.5 * d, fractionFare[4] * d);
						cairo_line_to (ad->cairo, 0.6 * d, fractionFare[5] * d);
						cairo_set_source_rgb(ad->cairo, 0.27, 0.64, 0.84);
						cairo_stroke(ad->cairo);

						cairo_set_source_rgb(ad->cairo, 0, 0, 1);
						cairo_arc(ad->cairo, 0.6 * d, fractionFare[5] * d, 0.01 * d, 0, 2 * M_PI);
						cairo_fill(ad->cairo);

						if(count>=7)
						{
							cairo_line_to (ad->cairo, 0.6 * d, fractionFare[5] * d);
							cairo_line_to (ad->cairo, 0.7 * d, fractionFare[6] * d);
							cairo_set_source_rgb(ad->cairo, 0.45, 0.81, 0.88);
							cairo_stroke(ad->cairo);

							cairo_set_source_rgb(ad->cairo, 0, 0, 1);
							cairo_arc(ad->cairo, 0.7 * d, fractionFare[6] * d, 0.01 * d, 0, 2 * M_PI);
							cairo_fill(ad->cairo);
						}
					}
				}
			}
		}
	}




/************* fare display ends *************/

/************* text start ********************/

	cairo_text_extents_t extents;
	cairo_select_font_face (ad->cairo, "Sans",CAIRO_FONT_SLANT_NORMAL,
			CAIRO_FONT_WEIGHT_NORMAL);
	cairo_set_font_size (ad->cairo, 0.07 * d);
	cairo_set_source_rgb(ad->cairo, 0, 0, 0);
	cairo_move_to (ad->cairo, 0.3 * d, 0.055 * d);
	cairo_show_text (ad->cairo, "Last Week");

	cairo_set_font_size (ad->cairo, 0.04 * d);

	cairo_set_source_rgba(ad->cairo, 1, 0, 0, 1);
	cairo_move_to (ad->cairo, 0.72 * d, (avg - 0.075) * d);
	cairo_show_text (ad->cairo, "average");
	cairo_move_to (ad->cairo, 0.72 * d, (avg - 0.025) * d);
	cairo_show_text (ad->cairo, "calorie");
	cairo_move_to (ad->cairo, 0.72 * d, (avg + 0.025) * d);
	cairo_show_text (ad->cairo, "burn(cal)");
	char printAvg[8];
	sprintf(printAvg,"%.2f" , ((0.6 - avg)*maxCal)/0.5);
	cairo_text_extents (ad->cairo, printAvg, &extents);
	cairo_move_to (ad->cairo, 0.72 * d, (avg + 0.075) * d);
	cairo_show_text (ad->cairo, printAvg);

	cairo_set_font_size (ad->cairo, 0.05 * d);

	cairo_set_source_rgba(ad->cairo, 1, 0, 0, 1);
	cairo_move_to (ad->cairo, 0.2 * d, 0.7 * d);
	cairo_show_text (ad->cairo, "Calorie");

	cairo_set_source_rgba(ad->cairo, 0, 0, 1, 1);
	cairo_move_to (ad->cairo, 0.5 * d, 0.7 * d);
	cairo_show_text (ad->cairo, "Fare");

	cairo_set_font_size (ad->cairo, 0.035 * d);

	cairo_set_source_rgb(ad->cairo, 1, 0, 0);
	for(double i = 1; i<=5; i++)
	{
		char maxC[8];
		sprintf(maxC,"%.0f" , (maxCal/5)*i);
		cairo_text_extents (ad->cairo, maxC, &extents);
		cairo_move_to (ad->cairo, 0.05 * d, (0.085 + 0.5 - (i/10)) * d);
		cairo_show_text (ad->cairo, maxC);
	}
	cairo_set_source_rgb(ad->cairo, 0, 0, 1);
	for(double i = 1; i<=5; i++)
	{
		char maxF[8];
		sprintf(maxF,"%.0f" , (maxFare/5)*i);
		cairo_text_extents (ad->cairo, maxF, &extents);
		cairo_move_to (ad->cairo, 0.05 * d, (0.125 + 0.5 - (i/10)) * d);
		cairo_show_text (ad->cairo, maxF);
	}
	/********* Total Count Text starts *******/
	cairo_set_font_size (ad->cairo, 0.055 * d);
	cairo_set_source_rgb(ad->cairo, 0,0,0);
	cairo_move_to (ad->cairo, 0.05 * d, 0.9 * d);
	cairo_show_text (ad->cairo, "Last Week");

	cairo_set_font_size (ad->cairo, 0.025 * d);
	cairo_set_source_rgb(ad->cairo, 1,0,0);
	cairo_move_to (ad->cairo, 0.01 * d, 1.0 * d);
	cairo_show_text (ad->cairo, "Total Calories Burned:");
	char totalWeeklyCalorieS[8];
	sprintf(totalWeeklyCalorieS,"%.2f" , totalWeeklyCalorie);
	cairo_text_extents (ad->cairo, totalWeeklyCalorieS, &extents);
	cairo_move_to (ad->cairo, 0.3 * d, 1.0 * d);
	cairo_show_text (ad->cairo, totalWeeklyCalorieS);
	cairo_move_to (ad->cairo, 0.39 * d, 1.0 * d);
	cairo_show_text (ad->cairo, "cal");

	cairo_set_source_rgb(ad->cairo, 0, 0, 1);
	cairo_move_to (ad->cairo, 0.48 * d, 1.0 * d);
	cairo_show_text (ad->cairo, "Total Money Saved:");
	char totalWeeklyFareS[8];
	sprintf(totalWeeklyFareS,"%.2f" , totalWeeklyFare);
	cairo_text_extents (ad->cairo, totalWeeklyFareS, &extents);
	cairo_move_to (ad->cairo, 0.74 * d, 1.0 * d);
	cairo_show_text (ad->cairo, totalWeeklyFareS);
	cairo_move_to (ad->cairo, 0.83 * d, 1.0 * d);
	cairo_show_text (ad->cairo, "taka");

	cairo_set_font_size (ad->cairo, 0.055 * d);
	cairo_set_source_rgb(ad->cairo, 0,0,0);
	cairo_move_to (ad->cairo, 0.05 * d, 1.1 * d);
	cairo_show_text (ad->cairo, "Last Month (Total days:");
	char totalDays[8];
	sprintf(totalDays,"%d" , totDays);
	cairo_text_extents (ad->cairo, totalDays, &extents);
	cairo_move_to (ad->cairo, 0.63 * d, 1.1 * d);
	cairo_show_text (ad->cairo, totalDays);

	cairo_move_to (ad->cairo, 0.7 * d, 1.1 * d);
	cairo_show_text (ad->cairo, ")");

	cairo_set_font_size (ad->cairo, 0.025 * d);
	cairo_set_source_rgb(ad->cairo, 1,0,0);
	cairo_move_to (ad->cairo, 0.01 * d, 1.2 * d);
	cairo_show_text (ad->cairo, "Total Calories Burned:");
	char totalCalorieS[8];
	sprintf(totalCalorieS,"%.2f" , totalCalorie);
	cairo_text_extents (ad->cairo, totalCalorieS, &extents);
	cairo_move_to (ad->cairo, 0.3 * d, 1.2 * d);
	cairo_show_text (ad->cairo, totalCalorieS);
	cairo_move_to (ad->cairo, 0.39 * d, 1.2 * d);
	cairo_show_text (ad->cairo, "cal");

	cairo_set_source_rgb(ad->cairo, 0, 0, 1);
	cairo_move_to (ad->cairo, 0.48 * d, 1.2 * d);
	cairo_show_text (ad->cairo, "Total Money Saved:");
	char totalFareS[8];
	sprintf(totalFareS,"%.2f" , totalFare);
	cairo_text_extents (ad->cairo, totalFareS, &extents);
	cairo_move_to (ad->cairo, 0.74 * d, 1.2 * d);
	cairo_show_text (ad->cairo, totalFareS);
	cairo_move_to (ad->cairo, 0.83 * d, 1.2 * d);
	cairo_show_text (ad->cairo, "taka");

	/********* Total Count Text ends *******/

/********************** text ends *********************/


		/****** faded lines start **********/
	cairo_move_to (ad->cairo, 0.1 * d , 0.1 * d );
	cairo_line_to (ad->cairo, 0.7 * d, 0.1 * d);

	cairo_set_source_rgba(ad->cairo, 0, 0, 0, 0.2);
	cairo_stroke(ad->cairo);

	cairo_move_to (ad->cairo, 0.1 * d, avg * d);
	cairo_line_to (ad->cairo, 0.7 * d, avg * d);

	cairo_set_source_rgba(ad->cairo, 1, 0, 0, 0.5);
	cairo_stroke(ad->cairo);

	/****** faded lines ends **********/

	cairo_rectangle(ad->cairo, 0, 0, 0.9 * d, 0.8 * d);
	cairo_set_source_rgb(ad->cairo, 0, 0, 0);
	cairo_stroke(ad->cairo);
	cairo_surface_flush(ad->surface);

	/* display cairo drawin on screen */
	unsigned char * imageData = cairo_image_surface_get_data(cairo_get_target(ad->cairo));
	evas_object_image_data_set(ad->img, imageData);
	evas_object_image_data_update_add(ad->img, 0, 0, ad->width, ad->height);
}
