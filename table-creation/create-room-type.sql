-- Program Name:        create-room-type.sql
-- Date Last Modified:  10/28/2022
-- Last Modified By:    Lauren Escobedo
-- Program Description: ROOM_TYPE table creation file

CREATE TABLE ROOM_TYPE(
    TYPE_CODE           INT PRIMARY KEY,     
    TYPE_PRICE          DECIMAL(6,2),
    TYPE_DESCRIPTION    NVARCHAR(4000)
);