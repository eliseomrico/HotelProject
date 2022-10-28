-- Program Name:        create-room.sql
-- Date Last Modified:  10/28/2022
-- Last Modified By:    Lauren Escobedo
-- Program Description: ROOM table creation file

CREATE TABLE ROOM (
    ROOM_NO             INT PRIMARY KEY,     
    ROOM_LOCATION       INT, --FOREIGN KEY REFERENCES LOCATION(LOC_ID),
    ROOM_TYPE           INT,
    ROOM_AVAILABLE      NVARCHAR(1)
);