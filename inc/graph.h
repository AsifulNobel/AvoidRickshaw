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

typedef struct appdata {

	int width;
	int height;
	Evas_Object *img;

	cairo_surface_t *surface;
	cairo_t *cairo;

} appdata_s;


void cairo_drawing(void *data);

#endif /* GRAPH_H_ */
