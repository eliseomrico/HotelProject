-- ========================== CUSTOMER CONSTRAINTS ==========================
--	CONSTRAINT FK_CUSTOMER_CREDIT_CARD FOREIGN KEY (cust_credit_card_no)  
--	REFERENCES CREDIT_CARD (credit_card_no),
-- CUSTOMER CONSTRAINTS

-- ========================== TRANSACTIONS CONSTRAINTS ==========================

--	-- CONSTRAINT FK_TRANSACTION_RESERVATION FOREIGN KEY (trans_res_id),  
--	-- REFERENCES RESERVATION (res_no),

-- ========================== EMPLOYEE CONSTRAINTS ==========================

	-- CONSTRAINT FK_TRANSACTION_RESERVATION FOREIGN KEY (trans_res_id),  
	-- REFERENCES CREDIT_CARD (credit_card_no),

-- ========================== LOCATION CONSTRAINTS ==========================

--LOC_SUPER_ID FOREIGN KEY REFERENCES EMPLOYEE(EMP_ID)

-- ========================== RESERVATION CONSTRAINTS ==========================

--FOREIGN KEY REFERENCES EMPLOYEE(EMP_ID),
--FOREIGN KEY REFERENCES CUSTOMER(CUST_ID),
--FOREIGN KEY REFERENCES LOCATION(LOC_ID),
--FOREIGN KEY REFERENCES ROOM(ROOM_NO),

-- ========================== ROOM CONSTRAINTS ==========================

--FOREIGN KEY REFERENCES LOCATION(LOC_ID),

-- ========================== WORKS_AT CONSTRAINTS ==========================

--FOREIGN KEY REFERENCES EMPLOYEE(EMP_ID),
--FOREIGN KEY REFERENCES LOCATION(LOC_ID),