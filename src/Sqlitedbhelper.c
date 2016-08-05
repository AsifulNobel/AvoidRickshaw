#include <string.h>
#include <time.h>
#include <sqlite3.h>
#include <stdint.h>
#include <stdlib.h>
#include <storage.h>
#include <app_common.h>
#include <stdio.h>
#include <dlog.h>
#include "avoidrickshaw.h"
#include "Sqlitedbhelper.h"

#define DB_NAME "sample.db"
#define TABLE_NAME "infoTable"
/***************/

#define COL_ID "ID"
#define COL_DIST "Distance"
#define COL_DATE "Info_DATE"
#define COL_STP "Steps"
#define COL_CAL "Calories"
#define COL_FARE "Fare"

/***************/

#define BUFLEN 500 /*assume buffer length for query string's size.*/

// Helper functions for counting days between two date of format YYYY-MM-DD
int countLeapDays(int m, int y);
void getNumericDate(int *d, int *m, int *y, const char *day);
int getDays(const char* day1, const char* day2);


sqlite3 *avoidRickshawDb; /*name of database*/
QueryData *qrydata;
int select_row_count = 0;
int g_row_count = 0;
char *tmp_date;

/*open database instance*/
int opendb()
{
     char * dataPath = app_get_data_path(); /*fetched package path available physically in the device*/
	 int size = strlen(dataPath)+10;

	 char * path = malloc(sizeof(char)*size);

	 strcpy(path,dataPath);
	 strncat(path, DB_NAME, size);

	 int ret = sqlite3_open_v2( path , &avoidRickshawDb, SQLITE_OPEN_CREATE|SQLITE_OPEN_READWRITE, NULL);
	 if(ret != SQLITE_OK)

	 free(dataPath);
	 free(path);

	 /*didn't close database instance as this will be handled by caller e.g. insert, delete*/

	 return ret;
}

/**
 * @brief Creates Table for storing app info in Database
 * @return Status SQLITE_ERROR or SQLITE_OK
 * SQLITE_ERROR = 1
 * SQLITE_OK = 0
 */
int initdb()
{
	if (opendb() != SQLITE_OK) /*create database instance*/
		return SQLITE_ERROR;

   int ret;
   char *ErrMsg;
   /*query preparation for table creation. it will not be created the table if it is exists already*/
   char *sql = "CREATE TABLE IF NOT EXISTS "\
		    TABLE_NAME" ("  \
			COL_DATE" TEXT NOT NULL, " \
			COL_DIST" REAL NOT NULL," \
			COL_FARE" INTEGER NOT NULL, " \
			COL_CAL" REAL NOT NULL, " \
			COL_STP" INTEGER NOT NULL,"\
			COL_ID" INTEGER PRIMARY KEY AUTOINCREMENT);";

   ret = sqlite3_exec(avoidRickshawDb, sql, NULL, 0, &ErrMsg); /*execute query*/

   if(ret != SQLITE_OK)
   {
	   dlog_print(DLOG_DEBUG, LOG_TAG, "Table Create Error! [%s]", ErrMsg);
	   sqlite3_free(ErrMsg);
	   sqlite3_close(avoidRickshawDb); /*close db instance as instance is still open*/

	   return SQLITE_ERROR;
   }

   dlog_print(DLOG_DEBUG, LOG_TAG, "Db Table created successfully!");
   sqlite3_close(avoidRickshawDb); /*close the db instance as operation is done here*/

   dlog_print(DLOG_DEBUG, LOG_TAG, "Closed Db instance!");

   return SQLITE_OK;
}

/*callback for insert operation*/
static int insertcb(void *NotUsed, int argc, char **argv, char **azColName){
   int i;
   for(i=0; i<argc; i++){
      /*usually we do not need to do anything.*/
   }
   return 0;
}

/**
 * @brief Insert info in Database
 *
 * @param[in] distance [float Type]
 * @param[in] steps [int Type]
 * @param[in] calories [float Type]
 * @param[in] fare [int Type]
 *
 * @return Status SQLITE_ERROR or SQLITE_OK
 * SQLITE_ERROR = 1
 * SQLITE_OK = 0
 */
int insertIntoDb(float distance, int steps, float calories, int fare)
{
	if(opendb() != SQLITE_OK) /*create database instance*/
		return SQLITE_ERROR;

	char sqlbuff[BUFLEN];
	char *ErrMsg;
	int ret;
	/*read system date time using sqlite function*/
	char* dateTime = "strftime('%Y-%m-%d','now')";

	/*prepare query for INSERT operation*/
	snprintf(sqlbuff, BUFLEN, "INSERT INTO "\
			TABLE_NAME" ("\
			COL_DATE"," \
			COL_DIST"," \
			COL_FARE"," \
			COL_CAL"," \
			COL_STP")"\
			" VALUES(%s, %f, %d, %f, %d);", /*didn't include id as it is autoincrement*/
					dateTime, distance, fare, calories, steps);

	ret = sqlite3_exec(avoidRickshawDb, sqlbuff, insertcb, 0, &ErrMsg); /*execute query*/
	if (ret != SQLITE_OK)
	{
		dlog_print(DLOG_ERROR, LOG_TAG, "Insertion Error! [%s]", sqlite3_errmsg(avoidRickshawDb));
		sqlite3_free(ErrMsg);
		sqlite3_close(avoidRickshawDb); /*close db instance for failed case*/
		return SQLITE_ERROR;
	}
	sqlite3_close(avoidRickshawDb); /*close db instance for success case*/
	return SQLITE_OK;
}

/**
 * @brief Update info in Database
 *
 * @param[in] distance [float Type]
 * @param[in] steps [int Type]
 * @param[in] calories [float Type]
 * @param[in] fare [int Type]
 *
 * @return Status SQLITE_ERROR or SQLITE_OK
 * SQLITE_ERROR = 1
 * SQLITE_OK = 0
 */
int updateInfoDb(float distance, int steps, float calories, int fare)
{
	if(opendb() != SQLITE_OK) /*create database instance*/
		return SQLITE_ERROR;

	char sqlbuff[BUFLEN];
	char *ErrMsg;
	int ret;
	/*read system date time using sqlite function*/
	char* dateTime = "strftime('%Y-%m-%d','now')";

	/*prepare query for INSERT operation*/
	snprintf(sqlbuff, BUFLEN, "UPDATE "\
			TABLE_NAME" SET "\
			COL_DIST"=%f," \
			COL_FARE"=%d," \
			COL_CAL"=%f," \
			COL_STP"=%d"\
			" WHERE "\
			COL_DATE"=%s;", /*didn't include id as it is autoincrement*/
					distance, fare, calories, steps, dateTime);

	dlog_print(DLOG_DEBUG, LOG_TAG, "Update query = [%s]", sqlbuff);

	ret = sqlite3_exec(avoidRickshawDb, sqlbuff, insertcb, 0, &ErrMsg); /*execute query*/
	if (ret != SQLITE_OK)
	{
		dlog_print(DLOG_ERROR, LOG_TAG, "Update Error! [%s]", sqlite3_errmsg(avoidRickshawDb));
		sqlite3_free(ErrMsg);
		sqlite3_close(avoidRickshawDb); /*close db instance for failed case*/
		return SQLITE_ERROR;
	}
	sqlite3_close(avoidRickshawDb); /*close db instance for success case*/
	return SQLITE_OK;
}

/***************************************************/
/*this callback will be called for each row fetched from database. we need to handle retrieved elements for each row manually and store data for further use*/
static int selectAllItemcb(void *data, int argc, char **argv, char **azColName){
	/*
	* SQLite queries return data in argv parameter as  character pointer */
	/*prepare a temporary structure*/
	QueryData *temp;
	int dayDiff;

	if (select_row_count == 0)
		dayDiff = getDays(argv[0], tmp_date) + 1;
	else
		dayDiff = getDays(argv[0], tmp_date);

	if (dayDiff > 1) {

		temp = (QueryData*)realloc(qrydata, ((select_row_count + dayDiff) * sizeof(QueryData)));

		for(int i = 0; i < dayDiff; i++){
			strcpy(temp[select_row_count+i].date, "0");
			temp[select_row_count+i].distance = 0.0;
			temp[select_row_count+i].fare = 0;
			temp[select_row_count+i].calories = 0.0;
			temp[select_row_count+i].steps = 0;
			temp[select_row_count+i].id = 0;
		}
		select_row_count += dayDiff-1;
		strcpy(tmp_date, argv[0]);
	}
	else {
		temp = (QueryData*) realloc(qrydata, ((select_row_count + 1) * sizeof(QueryData)));
		strcpy(tmp_date, argv[0]);
	}

	if(temp == NULL){
		dlog_print(DLOG_ERROR, LOG_TAG, "Cannot reallocate memory for QueryData");
		return SQLITE_ERROR;
	}
	else {
        /*store data into temp structure*/
		strcpy(temp[select_row_count].date, argv[0]);
		temp[select_row_count].distance = atof(argv[1]);
		temp[select_row_count].fare = atoi(argv[2]);
		temp[select_row_count].calories = atof(argv[3]);
		temp[select_row_count].steps = atoi(argv[4]);
		temp[select_row_count].id = atoi(argv[5]);

		qrydata = temp;
	}
	temp = NULL;
	free(temp);

	select_row_count++; /*keep row count*/

	return SQLITE_OK;
}

/*this callback will be called for each row fetched from database. we need to handle retrieved elements for each row manually and store data for further use*/
static int selectItemcb(void *data, int argc, char **argv, char **azColName){
	/*
	* SQLite queries return data in argv parameter as  character pointer */
	/*prepare a temporary structure*/
	QueryData *temp = (QueryData*)realloc(qrydata, ((select_row_count + 1) * sizeof(QueryData)));

	if(temp == NULL){
		dlog_print(DLOG_ERROR, LOG_TAG, "Cannot reallocate memory for QueryData");
		return SQLITE_ERROR;
	}
	else {
        /*store data into temp structure*/
		strcpy(temp[select_row_count].date, argv[0]);
		temp[select_row_count].distance = atof(argv[1]);
		temp[select_row_count].fare = atoi(argv[2]);
		temp[select_row_count].calories = atof(argv[3]);
		temp[select_row_count].steps = atoi(argv[4]);
		temp[select_row_count].id = atoi(argv[5]);

		qrydata = temp;
	}
	temp = NULL;
	free(temp);

	select_row_count++; /*keep row count*/

	return SQLITE_OK;
}

/**
 * @brief Gets all data from Database
 */
int getAllMsgFromDb(QueryData **msg_data, int* num_of_rows)
{
	if(opendb() != SQLITE_OK) /*create database instance*/
		return SQLITE_ERROR;

	qrydata = (QueryData *) calloc (1, sizeof(QueryData)); /*preparing local querydata struct*/

	char *sql = "SELECT * FROM infoTable ORDER BY ID DESC"; /*select query*/
	int ret;
	char *ErrMsg;
	select_row_count = 0;

    ret = sqlite3_exec(avoidRickshawDb, sql, selectItemcb, (void*)msg_data, &ErrMsg);

    if (ret != SQLITE_OK)
	{
	   dlog_print(DLOG_ERROR, LOG_TAG, "Select query execution error [%s]", ErrMsg);
	   sqlite3_free(ErrMsg);
	   sqlite3_close(avoidRickshawDb); /*close db for failed case*/

	   return SQLITE_ERROR;
	}

   *msg_data = qrydata;
   *num_of_rows = select_row_count;

   sqlite3_close(avoidRickshawDb); /*close db for success case*/

   return SQLITE_OK;
}

/*
 * @brief Gets data of last 28 days from Database with current date included.
 */
int getLast28DaysInfo(QueryData **msg_data, int* num_of_rows)
{
	if(opendb() != SQLITE_OK) /*create database instance*/
		return SQLITE_ERROR;

	qrydata = (QueryData *) calloc (1, sizeof(QueryData)); /*preparing local querydata struct*/

	char *sql = "SELECT * FROM infoTable WHERE "\
			COL_DATE" BETWEEN date('now','-27 days')"
					" AND date('now') ORDER BY ID DESC;";

	size_t len = sizeof("YYYY-MM-DD");
	tmp_date = (char *) calloc(1, len);
	time_t now = time(NULL);
	struct tm *t = localtime(&now);
	strftime(tmp_date, len, "%Y-%m-%d", t);

	int ret;
	char *ErrMsg;
	select_row_count = 0;

    ret = sqlite3_exec(avoidRickshawDb, sql, selectAllItemcb, (void*)msg_data, &ErrMsg);

    if (ret != SQLITE_OK)
	{
	   dlog_print(DLOG_ERROR, LOG_TAG, "Select query execution error [%s]", ErrMsg);
	   sqlite3_free(ErrMsg);
	   sqlite3_close(avoidRickshawDb); /*close db for failed case*/

	   return SQLITE_ERROR;
	}

   *msg_data = qrydata;
   *num_of_rows = select_row_count;
   tmp_date = NULL;
   free(tmp_date);

   sqlite3_close(avoidRickshawDb); /*close db for success case*/

   return SQLITE_OK;
}


int getMsgById(QueryData **msg_data, int id)
{
	if(opendb() != SQLITE_OK) /*create database instance*/
		return SQLITE_ERROR;

	qrydata = (QueryData *) calloc (1, sizeof(QueryData));

	char sql[BUFLEN];
	snprintf(sql, BUFLEN, "SELECT * FROM infoTable where ID=%d;", id);

	int ret = 0;
	char *ErrMsg;

    ret = sqlite3_exec(avoidRickshawDb, sql, selectAllItemcb, (void*)msg_data, &ErrMsg);
	if (ret != SQLITE_OK)
	{
	   sqlite3_free(ErrMsg);
	   sqlite3_close(avoidRickshawDb);

	   return SQLITE_ERROR;
	}

	*msg_data = qrydata;

	sqlite3_close(avoidRickshawDb); /*close db*/

	return SQLITE_OK;
}

/**
 * @brief Gets info from Database corresponding to current date
 *
 * @return SQLITE_OK info for current date is found, SQLITE_ERROR otherwise.
 */
int getMsgByCurrentDate(QueryData **msg_data, int* num_of_rows)
{
	if(opendb() != SQLITE_OK) /*create database instance*/
			return SQLITE_ERROR;

	qrydata = (QueryData *) calloc (1, sizeof(QueryData)); /*preparing local querydata struct*/
	char* dateTime = "strftime('%Y-%m-%d','now')";

	char sqlBuff[BUFLEN];
	int ret;
	char *ErrMsg;
	select_row_count = 0;

	/*prepare query for SELECT operation*/
	snprintf(sqlBuff, BUFLEN, "SELECT * FROM infoTable WHERE "\
			COL_DATE"=%s;", dateTime);


	ret = sqlite3_exec(avoidRickshawDb, sqlBuff, selectItemcb, (void*)msg_data, &ErrMsg);

	if (ret != SQLITE_OK)
	{
	   dlog_print(DLOG_ERROR, LOG_TAG, "Select query execution error [%s]", ErrMsg);
	   sqlite3_free(ErrMsg);
	   sqlite3_close(avoidRickshawDb); /*close db for failed case*/

	   return SQLITE_ERROR;
	}

   *msg_data = qrydata;
   *num_of_rows = select_row_count;

   sqlite3_close(avoidRickshawDb); /*close db for success case*/

   return SQLITE_OK;
}


static int deletecb(void *data, int argc, char **argv, char **azColName)
{
   int i;
   for(i=0; i<argc; i++){
	/*no need to do anything*/
   }
   return 0;
}

int deleteMsgById(int id)
{
	if(opendb() != SQLITE_OK) /*create database instance*/
		return SQLITE_ERROR;

   char sql[BUFLEN];
   snprintf(sql, BUFLEN, "DELETE from infoTable where ID=%d;", id);

   int counter = 0, ret = 0;
   char *ErrMsg;

   ret = sqlite3_exec(avoidRickshawDb, sql, deletecb, &counter, &ErrMsg);
	if (ret != SQLITE_OK)
	{
	   sqlite3_free(ErrMsg);
	   sqlite3_close(avoidRickshawDb);

	   return SQLITE_ERROR;
	}

	sqlite3_close(avoidRickshawDb);

   return SQLITE_OK;
}

/**
 * @brief Deletes all info from Database except last 28 days using sql query.
 */
int delAllExceptLast28Days()
{
	if(opendb() != SQLITE_OK) /*create database instance*/
		return SQLITE_ERROR;

   char *sql = "DELETE FROM infoTable WHERE "\
   			COL_DATE" < date('now','-27 days') OR "
   			COL_DATE" > date('now');";

   int counter = 0, ret = 0;
   char *ErrMsg;

   ret = sqlite3_exec(avoidRickshawDb, sql, deletecb, &counter, &ErrMsg);
   if (ret != SQLITE_OK)
   {
	  dlog_print(DLOG_ERROR, LOG_TAG, "Delete query execution error [%s]", ErrMsg);
	  sqlite3_free(ErrMsg);
	  sqlite3_close(avoidRickshawDb);

	  return SQLITE_ERROR;
   }

   sqlite3_close(avoidRickshawDb);

   return SQLITE_OK;
}

/**
 * @brief Deletes Table
 */
int deleteMsgAll()
{
	if(opendb() != SQLITE_OK) /*create database instance*/
		return SQLITE_ERROR;

   char sql[BUFLEN];
   snprintf(sql, BUFLEN, "DROP TABLE IF EXISTS infoTable;");

   int counter = 0, ret = 0;
   char *ErrMsg;

   ret = sqlite3_exec(avoidRickshawDb, sql, deletecb, &counter, &ErrMsg);
	if (ret != SQLITE_OK)
	{
	   dlog_print(DLOG_DEBUG, LOG_TAG, "Delete Error! [%s]", sqlite3_errmsg(avoidRickshawDb));
	   sqlite3_free(ErrMsg);
	   sqlite3_close(avoidRickshawDb);

	   return SQLITE_ERROR;
	}

	sqlite3_close(avoidRickshawDb);

   return SQLITE_OK;
}

/**
 * @brief Callback function for obtaining counted value returned by sql query.
 */
static int row_count_cb(void *data, int argc, char **argv, char **azColName)
{
	g_row_count = atoi(argv[0]); /*number of rows*/

	return 0;
}

/**
 * @brief Counts total number of rows present in specified database table.
 */
int getTotalMsgItemsCount(int* num_of_rows)
{
	if(opendb() != SQLITE_OK) /*create database instance*/
		return SQLITE_ERROR;

   char *sql = "SELECT COUNT(*) FROM infoTable";
   char *ErrMsg;

   int ret = 0;

   ret = sqlite3_exec(avoidRickshawDb, sql, row_count_cb, NULL, &ErrMsg);
	if (ret != SQLITE_OK)
	{
	    sqlite3_free(ErrMsg);
	    sqlite3_close(avoidRickshawDb);

	    return SQLITE_ERROR;
	}

	sqlite3_close(avoidRickshawDb);

	*num_of_rows = g_row_count;
	g_row_count = 0;
   return SQLITE_OK;
}


int countLeapDays(int m, int y){
    if (m <= 2)
        y--;

    return y/4 - y/100 + y/400;
}

void getNumericDate(int *d, int *m, int *y, const char *day){
    char *temp = (char *) calloc(1, 5);

    strncpy(temp, &day[0], 4);
    *y = atoi(temp);
    temp = NULL;

    temp = calloc(1, 3);
    strncpy(temp, &day[5], 2);
    *m = atoi(temp);
    temp = NULL;

    temp = calloc(1, 3);
    strncpy(temp, &day[8], 2);
    *d = atoi(temp);

    temp = NULL;
    free(temp);
}

int getDays(const char* day1, const char* day2){
    int daysOfMonth[12] = {31, 28, 31, 30, 31, 30,
                           31, 31, 30, 31, 30, 31};
    int n1, d1, m1, y1;
    int n2, d2, m2, y2;

    getNumericDate(&d1, &m1, &y1, day1);
    getNumericDate(&d2, &m2, &y2, day2);

    n1 = y1*365 + d1;
    n2 = y2*365 + d2;

    int i;
    for (i=0; i<m1 - 1; i++)
        n1 += daysOfMonth[i];

    for (i=0; i<m2 - 1; i++)
        n2 += daysOfMonth[i];

    n1 += countLeapDays(m1, y1);
    n2 += countLeapDays(m2, y2);

    return (n2 - n1);
}

// Function for inserting dummy values in DB
void populateDb(void)
{
	if(opendb() != SQLITE_OK) /*create database instance*/
	{
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to create database instance.");
		return;
	}

	float distance;
	int steps;
	float calories;
	int fare;
	float tempDistance;
	srand(time(NULL));

	char sqlbuff[BUFLEN];
	char *ErrMsg;
	int ret;
	char dateTime[14];

	for(int i = 1; i <= 31; i++){
		if (i == 25 || i == 27 || i == 28 || i == 15) {
			continue;
		}
//		if (i >= 25 && i <= 30) {
//			continue;
//		}
//		if (i >= 25 && i <= 31) {
//			continue;
//		}
//		if (i >= 26 && i <= 31) {
//			continue;
//		}

		sprintf(dateTime, "'2016-07-%02d'", i);

		distance = (float) ((rand() % 1800) + 200.1); //Distance between 0.2 km and 2 km
		tempDistance = distance / 1000;
		steps = (int) distance * 2;
		calories = 0.0215 * tempDistance * tempDistance * tempDistance
				- 0.1765 * tempDistance * tempDistance + 0.8710 * tempDistance
				+ 1.4577 * 70 * (tempDistance/3);
		fare = (int) (0.015 * distance);

		/*prepare query for INSERT operation*/
		snprintf(sqlbuff, BUFLEN, "INSERT INTO "\
				TABLE_NAME" ("\
				COL_DATE"," \
				COL_DIST"," \
				COL_FARE"," \
				COL_CAL"," \
				COL_STP")"\
				" VALUES(%s, %f, %d, %f, %d);",
						dateTime, distance, fare, calories, steps);

		ret = sqlite3_exec(avoidRickshawDb, sqlbuff, insertcb, 0, &ErrMsg); /*execute query*/
		if (ret != SQLITE_OK)
		{
			dlog_print(DLOG_ERROR, LOG_TAG, "PopulateDb: Insertion Error! [%s]", sqlite3_errmsg(avoidRickshawDb));
			sqlite3_free(ErrMsg);
			sqlite3_close(avoidRickshawDb); /*close db instance for failed case*/
			return;
		}
	}

	for(int i = 1; i < 2; i++){

		sprintf(dateTime, "'2016-08-%02d'", i);

		distance = (float) ((rand() % 1800) + 200.1); //Distance between 0.2 km and 2 km
		tempDistance = distance / 1000;
		steps = (int) distance * 2;
		calories = 0.0215 * tempDistance * tempDistance * tempDistance
				- 0.1765 * tempDistance * tempDistance + 0.8710 * tempDistance
				+ 1.4577 * 70 * (tempDistance/3);
		fare = (int) (0.015 * distance);

		/*prepare query for INSERT operation*/
		snprintf(sqlbuff, BUFLEN, "INSERT INTO "\
				TABLE_NAME" ("\
				COL_DATE"," \
				COL_DIST"," \
				COL_FARE"," \
				COL_CAL"," \
				COL_STP")"\
				" VALUES(%s, %f, %d, %f, %d);",
						dateTime, distance, fare, calories, steps);

		ret = sqlite3_exec(avoidRickshawDb, sqlbuff, insertcb, 0, &ErrMsg); /*execute query*/
		if (ret != SQLITE_OK)
		{
			dlog_print(DLOG_ERROR, LOG_TAG, "PopulateDb: Insertion Error! [%s]", sqlite3_errmsg(avoidRickshawDb));
			sqlite3_free(ErrMsg);
			sqlite3_close(avoidRickshawDb); /*close db instance for failed case*/
			return;
		}
	}

	sqlite3_close(avoidRickshawDb); /*close db instance for success case*/
}
