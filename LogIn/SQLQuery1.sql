﻿CREATE TABLE library

(
    id INT PRIMARY KEY IDENTITY (1, 1),
    book_name  VARCHAR (MAX) NULL,
    borrow_name VARCHAR (MAX) NULL,
    std_id VARCHAR (MAX)  NULL,
   
)

SELECT * FROM library

DROP TABLE library

USE [D:\C# PROJECT\LOGIN\LOGIN\BIN\DEBUG\DATABASETEACHER.MDF]