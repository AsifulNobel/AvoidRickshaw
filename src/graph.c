#include <graph.h>
#include "avoidrickshaw.h"

void cairo_drawing(void *cairo_data, QueryData *dbData, int row_count)
{
	appdata_s *ad = cairo_data;

	int temp = row_count;

//	while(row_count > -1) {
//		dlog_print(DLOG_DEBUG, LOG_TAG, "id: %d, date: %s, distance: %f, steps: %d, calories: %f, fare: %d",
//				dbData[row_count].id, dbData[row_count].date, dbData[row_count].distance,
//				dbData[row_count].steps, dbData[row_count].calories, dbData[row_count].fare);
//
//		row_count--;
//	}

	row_count = temp;

	double maxCal = 0, maxFare = 0;
	int count = 0;
	double totalCalorie = 0, totalFare = 0;
	int totDays = row_count + 1;

	for(int i = 0; i < totDays; i++)
	{
		totalCalorie += dbData[i].calories;
		totalFare += dbData[i].fare;
	}

	double fractionFare[7], fractionCal[7];
	double totalWeeklyFare = 0, totalWeeklyCalorie = 0;

	if (totDays <= 7)
	{
		for(int i = 0; i < totDays; i++)
		{
			totalWeeklyFare += dbData[i].fare;
			if(dbData[i].fare > maxFare)
				maxFare = dbData[i].fare;
			totalWeeklyCalorie += dbData[i].calories;
			if(dbData[i].calories > maxCal)
				maxCal = dbData[i].calories;
			count++;
		}

		for(int i = totDays - 1, j = 0; i >= 0; i--, j++)
		{
			fractionFare[j] = 0.6 - (dbData[i].fare/maxFare) * 0.5;
			fractionCal[j] = 0.6 - (dbData[i].calories/maxCal) * 0.5;
		}
	}
	else
	{
		for(int i = 0; i <7; i++)
		{
			totalWeeklyFare += dbData[i].fare;
			if(dbData[i].fare > maxFare)
				maxFare = dbData[i].fare;
			totalWeeklyCalorie += dbData[i].calories;
			if(dbData[i].calories > maxCal)
				maxCal = dbData[i].calories;
			count++;
		}

		for(int i = 6, j = 0; i >=0; i--, j++)
		{
			fractionFare[j] = 0.6 - (dbData[i].fare/maxFare) * 0.5;
			fractionCal[j] = 0.6 - (dbData[i].calories/maxCal) * 0.5;
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

	cairo_translate(ad->cairo, 0.05 * d, 0.05 * d);
	cairo_set_line_width(ad->cairo, 5);

/******* x and y  start ********/

	cairo_move_to (ad->cairo, 0.1 * d , 0.05 * d );
	cairo_line_to (ad->cairo, 0.1 * d, 0.6 * d);
	cairo_line_to (ad->cairo, 0.8 * d, 0.6 * d);
	cairo_set_source_rgb(ad->cairo, 0.0, 0.0, 0.0);
	cairo_stroke(ad->cairo);
	cairo_line_to (ad->cairo, 0.7 * d, 0.6 * d);

	for(double i = 0.1; i <= 0.5; i+=0.1)
	{
		cairo_arc(ad->cairo, 0.1 * d, i * d, 0.008 * d, 0, 2 * M_PI);
		cairo_fill(ad->cairo);
	}

	for(double i = 0.2; i <= 0.7; i+=0.1)
	{
		cairo_arc(ad->cairo, i * d, 0.6 * d, 0.008 * d, 0, 2 * M_PI);
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
	cairo_set_font_size (ad->cairo, 0.06 * d);
	cairo_set_source_rgb(ad->cairo, 0, 0, 0);
	cairo_move_to (ad->cairo, 0.3 * d, 0.06 * d);
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


	cairo_set_font_size (ad->cairo, 0.04 * d);

	cairo_set_source_rgb(ad->cairo, 1, 0, 0);
	cairo_arc(ad->cairo, 0.75 * d, 0.70 * d, 0.01 * d, 0, 2 * M_PI);
	cairo_fill(ad->cairo);
	cairo_move_to (ad->cairo, 0.77 * d, 0.715 * d);
	cairo_show_text (ad->cairo, "Calorie");

	cairo_set_source_rgb(ad->cairo, 0, 0, 1);
	cairo_arc(ad->cairo, 0.75 * d, 0.75 * d, 0.01 * d, 0, 2 * M_PI);
	cairo_fill(ad->cairo);
	cairo_move_to (ad->cairo, 0.77 * d, 0.765 * d);
	cairo_show_text (ad->cairo, "Fare");

	cairo_set_font_size (ad->cairo, 0.035 * d);

	cairo_set_source_rgb(ad->cairo, 1, 0, 0);

	/*Draw calorie labels on graph y-axis*/
	for(double i = 1; i<=5; i++)
	{
		char maxC[8];
		sprintf(maxC,"%.0f" , (maxCal/5)*i);
		cairo_text_extents (ad->cairo, maxC, &extents);
		cairo_move_to (ad->cairo, 0.03 * d, (0.085 + 0.5 - (i/10)) * d);
		cairo_show_text (ad->cairo, maxC);
	}
	cairo_set_source_rgb(ad->cairo, 0, 0, 1);

	/*Draw fare labels on graph y-axis*/
	for(double i = 1; i<=5; i++)
	{
		char maxF[8];
		sprintf(maxF,"%.0f" , (maxFare/5)*i);
		cairo_text_extents (ad->cairo, maxF, &extents);
		cairo_move_to (ad->cairo, 0.03 * d, (0.125 + 0.5 - (i/10)) * d);
		cairo_show_text (ad->cairo, maxF);
	}
	/********* Total Count Text starts *******/

	cairo_set_source_rgb(ad->cairo, 0, 0, 0);
	cairo_set_font_size (ad->cairo, 0.055 * d);
	cairo_move_to (ad->cairo, 0.35 * d, 0.9 * d);
	cairo_show_text (ad->cairo, "Summary");

	cairo_set_font_size (ad->cairo, 0.045 * d);

	cairo_set_source_rgb(ad->cairo, 1, 0, 0);
	cairo_move_to (ad->cairo, 0.38 * d, 1.03 * d);
	cairo_show_text (ad->cairo, "Calorie");
	cairo_move_to (ad->cairo, 0.38 * d, 1.07 * d);
	cairo_show_text (ad->cairo, "(Cal)");
	cairo_set_source_rgb(ad->cairo, 0, 0, 1);
	cairo_move_to (ad->cairo, 0.6 * d, 1.03 * d);
	cairo_show_text (ad->cairo, "Fare");
	cairo_move_to (ad->cairo, 0.6 * d, 1.07 * d);
	cairo_show_text (ad->cairo, "(Taka)");
	cairo_set_source_rgb(ad->cairo, 0,0,0);
	cairo_move_to (ad->cairo, 0.1 * d, 1.16 * d);
	cairo_show_text (ad->cairo, "Last Week");

	cairo_set_source_rgb(ad->cairo, 1, 0, 0);
	char totalWeeklyCalorieS[8];
	sprintf(totalWeeklyCalorieS,"%.2f" , totalWeeklyCalorie);
	cairo_text_extents (ad->cairo, totalWeeklyCalorieS, &extents);
	cairo_move_to (ad->cairo, 0.38 * d, 1.15 * d);
	cairo_show_text (ad->cairo, totalWeeklyCalorieS);

	cairo_set_source_rgb(ad->cairo, 0, 0, 1);
	char totalWeeklyFareS[8];
	sprintf(totalWeeklyFareS,"%.2f" , totalWeeklyFare);
	cairo_text_extents (ad->cairo, totalWeeklyFareS, &extents);
	cairo_move_to (ad->cairo, 0.6 * d, 1.15 * d);
	cairo_show_text (ad->cairo, totalWeeklyFareS);

	cairo_set_source_rgb(ad->cairo, 0, 0, 0);
	char totalDays[8];
//	sprintf(totalDays,"Last %d days" , totDays);
	sprintf(totalDays,"Last 28 days"); /*It will always be 28 days, regardless of input data rows*/
	cairo_text_extents (ad->cairo, totalDays, &extents);
	cairo_move_to (ad->cairo, 0.1 * d, 1.25 * d);
	cairo_show_text (ad->cairo, totalDays);

	cairo_set_source_rgb(ad->cairo, 1,0,0);
	char totalCalorieS[8];
	sprintf(totalCalorieS,"%.2f" , totalCalorie);
	cairo_text_extents (ad->cairo, totalCalorieS, &extents);
	cairo_move_to (ad->cairo, 0.38 * d, 1.25 * d);
	cairo_show_text (ad->cairo, totalCalorieS);

	cairo_set_source_rgb(ad->cairo, 0, 0, 1);
	char totalFareS[8];
	sprintf(totalFareS,"%.2f" , totalFare);
	cairo_text_extents (ad->cairo, totalFareS, &extents);
	cairo_move_to (ad->cairo, 0.6 * d, 1.25 * d);
	cairo_show_text (ad->cairo, totalFareS);
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

	/****** Summary Line Starts *******/
	cairo_set_source_rgba(ad->cairo, 0, 0, 0, 1);

	cairo_move_to (ad->cairo, 0.1 * d , 1.1 * d );
	cairo_line_to (ad->cairo, 0.8 * d, 1.1 * d);
	cairo_stroke(ad->cairo);
	cairo_move_to (ad->cairo, 0.1 * d , 1.2 * d );
	cairo_line_to (ad->cairo, 0.8 * d, 1.2 * d);
	cairo_stroke(ad->cairo);
	cairo_move_to (ad->cairo, 0.35 * d , 1 * d );
	cairo_line_to (ad->cairo, 0.35 * d, 1.3 * d);
	cairo_stroke(ad->cairo);
	cairo_move_to (ad->cairo, 0.575 * d , 1 * d );
	cairo_line_to (ad->cairo, 0.575 * d, 1.3 * d);
	cairo_stroke(ad->cairo);

	/****** Summary Line Ends *******/
	cairo_rectangle(ad->cairo, 0, 0, 0.9 * d, 0.8 * d);
	cairo_set_source_rgb(ad->cairo, 0, 0, 0);
	cairo_stroke(ad->cairo);
	cairo_surface_flush(ad->surface);

	/* display cairo drawin on screen */


	unsigned char * imageData = cairo_image_surface_get_data(cairo_get_target(ad->cairo));
	evas_object_image_data_set(ad->img, imageData);
	evas_object_image_data_update_add(ad->img, 0, 0, ad->width, ad->height);
}
