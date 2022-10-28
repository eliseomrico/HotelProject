-- Program Name:        create-location.sql
-- Date Last Modified:  10/28/2022
-- Last Modified By:    Lauren Escobedo
-- Program Description: LOCATION table creation file

CREATE TABLE LOCATION (
    LOC_ID              INT IDENTITY(1,1) PRIMARY KEY,
    LOC_HOURS           NVARCHAR(200), -- confer with ashley and matt on how we are displaying hours
    LOC_ADDRESS         NVARCHAR(50),
    LOC_PHONE           NVARCHAR(15)r,
    LOC_NAME            NVARCHAR(50),
    LOC_SUPER_ID        INT --FOREIGN KEY REFERENCES EMPLOYEE(EMP_ID)
);