-- Program Name:        create-works-at.sql
-- Date Last Modified:  10/28/2022
-- Last Modified By:    Lauren Escobedo
-- Program Description: WORKS_AT table creation file

CREATE TABLE WORKS_AT (
    EMP_ID                  INT, --FOREIGN KEY REFERENCES EMPLOYEE(EMP_ID),  
    LOC_ID                  INT, --FOREIGN KEY REFERENCES LOCATION(LOC_ID),
    HOURS_WORKED            INT
);