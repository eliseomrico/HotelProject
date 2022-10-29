-- Program Name:        create-reservation.sql
-- Date Last Modified:  10/28/2022
-- Last Modified By:    Lauren Escobedo
-- Program Description: RESERVATION table creation file

CREATE TABLE RESERVATION (
    RES_NO              INT IDENTITY(1,1) PRIMARY KEY,     
    RES_EMP_ID          INT FOREIGN KEY REFERENCES EMPLOYEE(EMP_ID),
    RES_CUST_ID         INT FOREIGN KEY REFERENCES CUSTOMER(CUST_ID),
    RES_LOC_ID          INT FOREIGN KEY REFERENCES LOCATION(LOC_ID),
    RES_ROOM_NO         INT FOREIGN KEY REFERENCES ROOM(ROOM_NO),
    RES_START_DATE      DATE,
    RES_END_DATE        DATE
);