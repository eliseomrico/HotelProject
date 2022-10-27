----======================================== CREDIT CARD TABLE ==================================================
 
-- CREATE TABLE CREDIT_CARD(
--	credit_card_no         int,
--	credit_card_fname      nvarchar(30),
--	credit_card_lname      nvarchar(30),
--	credit_expire_date     nvarchar(10),
--	credit_sec_code        int,

--	PRIMARY KEY(credit_card_no)
-- );

----======================================== CUSTOMER TABLE ==================================================

--CREATE TABLE CUSTOMER(
--	cust_id                 int,
--	cust_fname              nvarchar(30),
--	cust_lname              nvarchar(30),
--	cust_phone              nvarchar(12),
--	cust_email              nvarchar(25),
--	cust_balance            decimal,
--	cust_credit_card_no     int,

--	CONSTRAINT FK_Child_Parent FOREIGN KEY (cust_credit_card_no)  
--	REFERENCES CREDIT_CARD (credit_card_no),

--	PRIMARY KEY(cust_id)
--);

---- TEST CREDIT CARD DATA
---- (credit_card_no: Int, fname,lname,expire_date,sec_code );
-- INSERT INTO CREDIT_CARD VALUES (1234,'Bob','Dylan','01/05/2029',521);
-- INSERT INTO CREDIT_CARD VALUES (56342,'Ariana','Grande','03/01/2026',397);
-- INSERT INTO CREDIT_CARD VALUES (4589484,'Freddie','Mercury','01/01/2023',521);
-- INSERT INTO CREDIT_CARD VALUES (82953,'Ed','Sheeran','04/10/2026',397);

---- TEST CUSTOMER DATA
---- (id,'fname','lname','phone','email',balance:(decimal),cus_credit_card_no: int);
-- INSERT INTO CUSTOMER VALUES (111,'Bob','Dylan','508-712-6934','bob.dylan@att.net',1200.00,1234);
-- INSERT INTO CUSTOMER VALUES (222,'Ariana','Grande','401-732-5698','agrande@yahoo.com',50000.00,56342);
-- INSERT INTO CUSTOMER VALUES (333,'Freddie','Mercury','204-135-8796','thefreddie@gmail.com',43000.00,4589484);
-- INSERT INTO CUSTOMER VALUES (444,'Ed','Sheeran','269-103-5748','sheeran.ed@sbcglobal.net',300000.00,82953);