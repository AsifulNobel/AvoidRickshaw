#include <string.h>
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

sqlite3 *avoidRickshawDb; /*name of database*/
int select_row_count = 0;

/*open database instance*/
int opendb()
{
     char * dataPath = app_get_data_path(); /*fetched package path available physically in the device*/
	 int size = strlen(dataPath)+10;

	 char * path = malloc(sizeof(char)*size);

	 strcpy(path,dataPath);
	 strncat(path, DB_NAME, size);

//	 DBG("DB Path = [%s]", path); /*prepared full path, database will be stored there*/

	 int ret = sqlite3_open_v2( path , &avoidRickshawDb, SQLITE_OPEN_CREATE|SQLITE_OPEN_READWRITE, NULL);
	 if(ret != SQLITE_OK)
//		ERR("DB Create Error! [%s]", sqlite3_errmsg(avoidRickshawDb));

	 free(dataPath);
	 free(path);
         /*didn't close database instance as this will be handled by caller e.g. insert, delete*/
	 return ret;
}

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

   dlog_print(DLOG_DEBUG, LOG_TAG, "create table query : %s", sql);

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

int insertIntoDb(float distance, int steps, float calories, int fare)
{
	if(opendb() != SQLITE_OK) /*create database instance*/
		return SQLITE_ERROR;

	char sqlbuff[BUFLEN];
	char *ErrMsg;
	int ret;
	/*read system date time using sqlite function*/
	char* dateTime = "strftime('%Y-%m-%d  %H-%M','now')";

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

	dlog_print(DLOG_DEBUG, LOG_TAG, "Insert query = [%s]", sqlbuff);

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

/***************************************************/

QueryData *qrydata;

/*this callback will be called for each row fetched from database. we need to handle retrieved elements for each row manually and store data for further use*/
static int selectAllItemcb(void *data, int argc, char **argv, char **azColName){
        /*
        * SQLite queries return data in argv parameter as  character pointer */
        /*prepare a temporary structure*/
	QueryData *temp = (QueryData*)realloc(qrydata, ((select_row_count + 1) * sizeof(QueryData)));

	if(temp == NULL){
		dlog_print(DLOG_ERROR, LOG_TAG, "Cannot reallocate memory for QueryData");
		return SQLITE_ERROR;
	} else {
        /*store data into temp structure*/
		strcpy(temp[select_row_count].date, argv[0]);
		temp[select_row_count].distance = atof(argv[1]);
		temp[select_row_count].fare = atoi(argv[2]);
		temp[select_row_count].calories = atof(argv[3]);
		temp[select_row_count].steps = atoi(argv[4]);
		temp[select_row_count].id = atoi(argv[5]);

                /*copy temp structure into main sturct*/
		qrydata = temp;
	}

	select_row_count++; /*keep row count*/

   return SQLITE_OK;
}

int getAllMsgFromDb(QueryData **msg_data, int* num_of_rows)
{
	if(opendb() != SQLITE_OK) /*create database instance*/
		return SQLITE_ERROR;

	qrydata = (QueryData *) calloc (1, sizeof(QueryData)); /*preparing local querydata struct*/

	char *sql = "SELECT * FROM infoTable ORDER BY ID DESC"; /*select query*/
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
//	   DBG("select query execution error [%s]", ErrMsg);
	   sqlite3_free(ErrMsg);
	   sqlite3_close(avoidRickshawDb);

	   return SQLITE_ERROR;
	}

//	DBG("select query execution success!");

        /*assign fetched data into caller's struct*/
	*msg_data = qrydata;

	sqlite3_close(avoidRickshawDb); /*close db*/

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
//		ERR("Delete Error! [%s]", sqlite3_errmsg(avoidRickshawDb));
	   sqlite3_free(ErrMsg);
	   sqlite3_close(avoidRickshawDb);

	   return SQLITE_ERROR;
	}

	sqlite3_close(avoidRickshawDb);

   return SQLITE_OK;
}

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

int g_row_count = 0;

static int row_count_cb(void *data, int argc, char **argv, char **azColName)
{
	g_row_count = atoi(argv[0]); /*number of rows*/

	return 0;
}
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
//		ERR("Count Error! [%s]", sqlite3_errmsg(avoidRickshawDb));
	    sqlite3_free(ErrMsg);
	    sqlite3_close(avoidRickshawDb);

	    return SQLITE_ERROR;
	}

//	DBG("Total row found[%d]", g_row_count);

	sqlite3_close(avoidRickshawDb);

	*num_of_rows = g_row_count;
	g_row_count = 0;
   return SQLITE_OK;
}
