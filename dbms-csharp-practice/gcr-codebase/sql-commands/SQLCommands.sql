/*
Syntax to create database : 
CREATE DATABASE Database_Name;
*/
Create Database BridgeLabz;


/*
Syntax to use database:
USE DatabaseName;
*/
Use BridgeLabz;


/*
DDL commands and Types of keys in SQL:

Syntax to create a table:
CREATE TABLE Table_Name(
	column1 datatype constraint
	column2 datatype constraint
);
*/
--Create Students table with StudentId as Primary key
Create Table Students(
	StudentId Int Primary Key,
	Name Varchar(50),
	Age Int,
	City Varchar(50),
	Email Varchar(50) Unique
);
--Create Courses table with CourseId as Primary key
Create Table Courses(
	CourseId Int Primary Key,
	CourseName Varchar(50),
	CourseFee Int
);
--Create Enrollments Table with Foreign Keys(CourseId and StudentId) and both combined Composite Key(StudentId,CourseId)
Create Table Enrollments (
    StudentID INT,
    CourseID INT,
    EnrollmentDate DATE,
    Primary Key (StudentId, CourseId),
    Foreign Key (StudentId) References Students(StudentId),
    Foreign Key (CourseId) References Courses(CourseId)
);


/*
Syntax to Insert Recorde in table:

INSERT INTO Table_Name VALUES
(column1_value,column2_value,column3_value),
(column1_value,column2_value,column3_value);
*/
--Insert values in Students table
--Insert data into Students table
Insert Into Students Values
(1, 'Arjun', 20, 'Delhi', 'arjun@gmail.com'),
(2, 'Neha', 22, 'Mumbai', 'neha@gmail.com'),
(3, 'Rahul', 19, 'Delhi', 'rahul@gmail.com'),
(4, 'Priya', 21, 'Pune', 'priya@gmail.com');
--Insert values in Courses table
Insert Into Courses Values
(101, 'Java', 5000),
(102, 'Python', 4500),
(103, 'SQL', 3000);
--Insert values in Enrollments table
Insert Into Enrollments Values
(1, 101, '2025-01-10'),
(1, 103, '2025-01-15'),
(2, 102, '2025-01-12'),
(3, 101, '2025-01-11');



/*
Alter Command Syntax:

Add Single Column: 
ALTER TABLE Table_Name
ADD column_name datatype constraint;

Add Multiple Columns:
ALTER TABLE Table_Name
ADD column_name datatype
	column_name datatype

Modify DataType:
ALTER TABLE Table_Name
ADD COLUMN column_name new_datatype;

Drop a column:
ALTER TABLE Table_Name
DROP COLUMN column_name;
*/
--Add a column PhoneNumber in Students table
Alter Table Students
Add PhoneNumber Varchar(10);
--Add gender and address columns in Students table
Alter Table Students
Add Gender Varchar(10),
	StudentAddress Varchar(100);
--Modify Name column datatype
Alter Table Students
Alter Column Name Varchar(100);
--Drop Column StudentAddress 
Alter Table Students
Drop Column StudentAddress;



/*
DML commands:

Syntax to Insert records:
INSERT INTO Table_Name VALUES
(column1_value,column2_value,column3_value),
(column1_value,column2_value,column3_value);

Syntax to Update records:
UPDATE table_name
SET column=value
WHERE condition;

Syntax to Delete record:
DELETE FROM table_name
WHERE condition;
*/
--Insert data into Students table
Insert Into Students 
Values (5, 'Amit', 23, 'Jaipur', 'amit@gmail.com');
--Insert selected columns
Insert Into Students (StudentId, Name, Age)
Values (6, 'Riya', 20);
--Update student age
Update Students
Set Age = 22
Where StudentId = 3;
--Update multiple columns
Update Students
Set City = 'Bangalore', Age = 24
Where StudentId = 2;
--Delete a specific record
Delete From Students
Where StudentId = 6;



/*
DQL commands:

Syntax for SELECT command:
SELECT * FROM table_name;
SELECT column1, column2 FROM table_name;

Syntax for WHERE clause:
SELECT * FROM table_name
WHERE condition;
*/
--Fetch all records
Select * from Students;
--Fetch students with age greater than 20
SELECT Name, Age
FROM Students
WHERE Age > 20;
--Fetch students whose age is between 20 and 22
SELECT * FROM Students
WHERE Age BETWEEN 20 AND 22;
--Fetch students whose name starts with 'A'
SELECT * FROM Students
WHERE Name LIKE 'A%';



/*
DCL Commands:

Syntax to Grant access:
GRANT privilage_name on object_name/table_name 
TO {user_name | public | role_name};

Syntax to Revoke access:
FROM privilege_name on object_name/table_name
FROM {user_name | public | role_name};
*/
--Create New Login 
CREATE LOGIN StudentLogin
WITH PASSWORD = 'Student@123';
USE BridgeLabz;
CREATE USER StudentUser
FOR LOGIN StudentLogin;

-- Grant permission
GRANT SELECT ON Students TO StudentUser;
GRANT INSERT ON Students TO StudentUser;
--Revoke permission
REVOKE INSERT ON Students FROM StudentUser;


/*
TCL Commands:

Syntax to Begin Transaction: 
BEGIN TRANSACTION;

Syntax for Commit(Save changes):
COMMIT;

Syntax for Rollback(Undoes changes) 
ROLLBACK TRANSACTION savepoint_name;

Syntax for Savepoint(creates a checkpoint inside transaction):
SAVE TRANSACTION savepoint_name;
*/
--Begin transaction
BEGIN TRANSACTION;
--Update age
UPDATE Students 
SET Age = 22 WHERE StudentId = 1;
--Save Transaction
SAVE TRANSACTION save1;
--Delete student with id 2
DELETE FROM Students WHERE StudentId = 2;
--Rollback to save1
ROLLBACK TRANSACTION save1;
--Commit Transaction
COMMIT;



/*
JOINS in SQL
Inner Join Syntax:
	SELECT columns
	FROM table1
	INNER JOIN table2
	ON condition;
*/
--Get students who are enrolled in courses
Select 
    S.StudentId,
    S.Name,
    E.CourseID,
    E.EnrollmentDate
From Students S
Inner Join Enrollments E
On S.StudentId = E.StudentID;

/*
Left Join Syntax:
	SELECT columns
	FROM table1
	LEFT JOIN table2
	ON condition;
*/
--Get all students and their enrollments (if any)
Select 
    S.StudentId,
    S.Name,
    E.CourseID
From Students S
Left Join Enrollments E
On S.StudentId = E.StudentID;

/*
Right Join Syntax:
	SELECT columns
	FROM table1
	RIGHT JOIN table2
	ON condition;
*/
--Get all enrollments and student details
Select 
    S.StudentId,
    S.Name,
    E.CourseID
From Students S
Right Join Enrollments E
On S.StudentId = E.StudentID;

/*
Full Outer Join Syntax:
	SELECT columns
	FROM table1
	FULL OUTER JOIN table2
	ON condition;
*/
--Get all students and all enrollments
Select 
    S.StudentId,
    S.Name,
    E.CourseID
From Students S
Full Outer Join Enrollments E
On S.StudentId = E.StudentID;

/*
Join Multiple Tables:
	SELECT columns
	FROM table1
	JOIN table2 ON condition
	JOIN table3 ON condition;
*/
--Student name with course name and enrollment date
Select 
    S.Name AS StudentName,
    C.CourseName,
    E.EnrollmentDate
From Students S
Inner Join Enrollments E
On S.StudentId = E.StudentID
Inner Join Courses C
On E.CourseID = C.CourseId;

/*
Cross Join Syntax:
	SELECT columns
	FROM table1
	CROSS JOIN table2;
*/
--All students combined with all courses
Select 
    S.Name AS StudentName,
    C.CourseName
From Students S
Cross Join Courses C;

/*
Self Join Syntax:
	SELECT A.column, B.column
	FROM table A
	JOIN table B
	ON condition;
*/
--Students from same city
Select
    A.Name AS Student1,
    B.Name AS Student2,
    A.City
From Students A
Join Students B
On A.City = B.City
And A.StudentId <> B.StudentId;

/*
More DDL Commands:
DROP(removes permanantely) command Syntax:
Drop a single table:
DROP TABLE Table_Name;

Drop multiple tables:
DROP TABLE table1_name,table2_name;

Drop database:
DROP DATABASE Database_Name;
*/
--Drop Table Enrollments
Drop Table Enrollments;
--Drop Tables Courses and Students
Drop Table Courses,Students;
--Drop Database BridgeLabz
Drop Database BridgeLabz;


/*
TRUNCATE(removes all data but keeps structure) command Syntax:
Truncate a table:
TRUNCATE TABLE table_name;

Truncate multiple tables:
TRUNCATE TABLE table1;
TRUNCATE TABLE table2;
*/
--Truncate Table Students
Truncate Table Students;
--Truncate Enrollments and Courses tables 
TRUNCATE TABLE Enrollments;
TRUNCATE TABLE Courses;