﻿CREATE TABLE DemoFacility ( Facility_no int NOT NULL PRIMARY KEY, Name VARCHAR(30) NOT NULL, Hotel_no int NOT NULL, FOREIGN KEY (Hotel_no) REFERENCES dbo.Hotel(Hotel_no))  