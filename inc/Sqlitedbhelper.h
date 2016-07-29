/*this structure will be commonly used in both database and application layer*/
#define MAX_LEN 200

typedef struct
{
    int id;
    char date[MAX_LEN];
    float distance;
    int steps;
    float calories;
    int fare;

} QueryData;

int initdb();

int insertIntoDb(float distance, int steps, float calories, int fare);

/*update Db row with input data*/
int updateInfoDb(float distance, int steps, float calories, int fare);

/*fetch all stored message form database. This API will return total number of rows found in this call*/
int getAllMsgFromDb(QueryData **msg_data, int* num_of_rows);

/*fetch stored message form database based on given ID. Application needs to send desired ID*/
int getMsgById(QueryData **msg_data, int id);

/*fetch stored message form database based on current date*/
int getMsgByCurrentDate(QueryData **msg_data, int* num_of_rows);

/*delete stored message form database based on given ID. Application needs to send desired ID*/
int deleteMsgById(int id);

/*fetch all stored message form database*/
int deleteMsgAll();

/*count number of stored msg in the database and will return the total number*/
int getTotalMsgItemsCount(int* num_of_rows);

/*Db Populate function*/
void populateDb(void);
