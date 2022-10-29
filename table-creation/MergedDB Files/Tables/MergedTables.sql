--======================================== MARCEL'S TABLES ==================================================
--===========================================================================================================

--======================================== CREDIT CARD TABLE ==================================================
 
CREATE TABLE CREDIT_CARD(
	credit_card_no         nvarchar(20),
	credit_card_fname      nvarchar(30),
	credit_card_lname      nvarchar(30),
	credit_expire_date     nvarchar(10),
	credit_sec_code        int,

	PRIMARY KEY(credit_card_no)
 );

--======================================== CUSTOMER TABLE ==================================================

CREATE TABLE CUSTOMER(
	cust_id                 int,
	cust_fname              nvarchar(30),
	cust_lname              nvarchar(30),
	cust_phone              nvarchar(15),
	cust_balance            decimal(8,2),
          --May need Constraint
	cust_credit_card_no     nvarchar(20),

	PRIMARY KEY(cust_id)
);


--======================================== TRANSACTION TABLE ==================================================

CREATE TABLE TRANSACTIONS (
	trans_no         int,
	trans_date       date,
	trans_amt        decimal(8,2),
          --Definitely need to add business Constraint so that amt cannot exceed 999,999
	trans_res_id     int,


	PRIMARY KEY(trans_no)
);


--======================================== EMPLOYEE TABLE ==================================================

CREATE TABLE EMPLOYEE (
	emp_id        int IDENTITY(1,1),
	emp_fname     nvarchar(30),
	emp_lname     nvarchar(30),
	emp_title     nvarchar(25),
	emp_loc_id    int,
	super_id      int, -- references supersvisor id # (Self-Ref)
	emp_ssn       int,

	PRIMARY KEY(emp_id)
);

--======================================== LAUREN'S TABLES ==================================================
--===========================================================================================================



--======================================== LOCATION TABLE ==================================================
CREATE TABLE LOCATION (
    LOC_ID              INT IDENTITY(1,1) PRIMARY KEY,
    LOC_HOURS           NVARCHAR(200), -- confer with ashley and matt on how we are displaying hours
    LOC_ADDRESS         NVARCHAR(50),
    LOC_PHONE           NVARCHAR(15),
    LOC_NAME            NVARCHAR(50),
    LOC_SUPER_ID        INT 
);


--======================================== RESERVATION TABLE ==================================================
CREATE TABLE RESERVATION (
    RES_NO              INT IDENTITY(1,1) PRIMARY KEY,     
    RES_EMP_ID          INT, 
    RES_CUST_ID         INT, 
    RES_LOC_ID          INT, 
    RES_ROOM_NO         INT, 
    RES_START_DATE      DATE,
    RES_END_DATE        DATE
);


--======================================== ROOM_TYPE TABLE ==================================================
CREATE TABLE ROOM_TYPE(
    TYPE_CODE           INT PRIMARY KEY,     
    TYPE_PRICE          DECIMAL(6,2),
    TYPE_DESCRIPTION    NVARCHAR(4000)
);


--======================================== ROOM TABLE ==================================================
CREATE TABLE ROOM (
    ROOM_NO             INT PRIMARY KEY,     
    ROOM_LOC       INT,
    ROOM_TYPE           INT,
    ROOM_AVAILABLE      NVARCHAR(1)
);

--======================================== TEST DATA ==================================================
--=====================================================================================================

-- TEST CREDIT CARD DATA
 --INSERT INTO CREDIT_CARD VALUES (1234,'Bob','Dylan','01/05/2029',521);
 --INSERT INTO CREDIT_CARD VALUES (56342,'Ariana','Grande','03/01/2026',397);
 --INSERT INTO CREDIT_CARD VALUES (4589484,'Freddie','Mercury','01/01/2023',521);
 --INSERT INTO CREDIT_CARD VALUES (82953,'Ed','Sheeran','04/10/2026',397);

-- TEST CUSTOMER DATA
 --INSERT INTO CUSTOMER VALUES (111,'Bob','Dylan','508-712-6934','bob.dylan@att.net',1200.00,1234);
 --INSERT INTO CUSTOMER VALUES (222,'Ariana','Grande','401-732-5698','agrande@yahoo.com',50000.00,56342);
 --INSERT INTO CUSTOMER VALUES (333,'Freddie','Mercury','204-135-8796','thefreddie@gmail.com',43000.00,4589484);
 --INSERT INTO CUSTOMER VALUES (444,'Ed','Sheeran','269-103-5748','sheeran.ed@sbcglobal.net',300000.00,82953);

-- TEST TRANSACTIONS DATA
--INSERT INTO TRANSACTIONS VALUES (123456,12/08/2022,125.60,861451);
-- INSERT INTO TRANSACTIONS VALUES (454899,01/17/2022,500.00,456489);
-- INSERT INTO TRANSACTIONS VALUES (151496,06/01/2022,1000.60,121492);
-- INSERT INTO TRANSACTIONS VALUES (121986,03/27/2021,226.10,549864);

-- TEST EMPLOYEE DATA
--INSERT INTO EMPLOYEE (emp_fname,emp_lname,emp_title,super_id,emp_ssn) VALUES ('Employee','1','Front Desk',10,318455693);
--INSERT INTO EMPLOYEE (emp_fname,emp_lname,emp_title,super_id,emp_ssn) VALUES ('Employee','2','Housekeeper',10,189658789);
--INSERT INTO EMPLOYEE (emp_fname,emp_lname,emp_title,super_id,emp_ssn) VALUES ('Supervisor','Bob','Manager',20,129848958);