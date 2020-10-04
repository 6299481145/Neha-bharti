#include <iostream>
#include"sqlite3.h"

using  namespace std; 

   static int callback(void *NotUsed, int argc, char **argv, char **azColName){
    int i;
    for(i=0; i<argc; i++){
      cout<<"%s = %s\n", azColName[i], argv[i] ? argv[i] : "NULL";
    }
    cout<<"endl";
    return 0;
 }
  
  int main(int argc, char **argv){
    sqlite3 *db;
    char *zErrMsg = 0;
    int rc;
 
    if( argc!=3 ){
      fcout<<stderr, "Usage: %s DATABASE SQL-STATEMENT\n", argv[0];
      return(1);
    }
    rc = sqlite3_open(argv[1], &db);
    if( rc ){
      fcout<<stderr, "Can't open database: %s\n", sqlite3_errmsg(db);
      sqlite3_close(db);
      return(1);
    }
    rc = sqlite3_exec(db, argv[2], callback, 0, &zErrMsg);
    if( rc!=SQLITE_OK ){
      fcout<<stderr, "SQL error: %s\n", zErrMsg;
      sqlite3_free(zErrMsg);
    }
    sqlite3_close(db);
    return 0;
  }
