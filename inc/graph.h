/*
 * graph.h
 *
 *  Created on: Jul 26, 2016
 *      Author: nobel
 */

#ifndef GRAPH_H_
#define GRAPH_H_

#include <Elementary.h>
#include <cairo.h>
#include "Sqlitedbhelper.h"

typedef struct appdata {

	int width;
	int height;
	Evas_Object *img;

	cairo_surface_t *surface;
	cairo_t *cairo;

} appdata_s;


void cairo_drawing(void *cairo_data, QueryData *dbData, int row_count);

#endif /* GRAPH_H_ */
