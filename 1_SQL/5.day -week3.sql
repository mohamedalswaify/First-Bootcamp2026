 ***********************Session 5**********************************
-- 📘 SQL Server: Full DQL Course - Beginner to Advanced
-- 👨‍🏫 Name: Mohamed Alswaify
-- 📱 Mobile: 0564842804


---------------------------------------------------------
-- 📘 THEORETICAL INTRODUCTION: What is DQL?
------------------------------------------------------------
-- DQL (Data Query Language) is used to fetch data from database objects such as tables and views.
-- The main DQL command is:
--     SELECT

-- 🔹 SQL SELECT SYNTAX:
SELECT *|columns
FROM table name
[WHERE bool-expr AND|OR  bool-expr]
[group by column|expr ]
[having bool-expr]
[order by column|number|expr|alias [ASC][DESC]]



-- 🔹 Operators:
--   ➕ Arithmetic: +, -, *, /
--   🔁 Comparison: =, !=, <>, <, <=, >, >=
--   🧠 Logical: AND, OR, NOT
--   🧮 Range: not BETWEEN ... AND ...
--   📋 List: [not] IN (...)
--   🔍 Pattern: [not] LIKE 'pattern'
--   🚫 NULL Check: IS NULL, IS NOT NULL

-- * Displaying Data from Multiple Tables Using Joins:

    * FROM table1 [INNER] JOIN table2 ON bool-expr [[INNER] JOIN table3 ON bool-expr ...]
    * FROM table1 CROSS JOIN table2 where bool-expr
    * FROM table1, table2 where bool-expr
    * FROM table1 LEFT|RIGHT|FULL [OUTER] JOIN table2 ON bool-expr [ LEFT|RIGHT|FULL [OUTER] JOIN table3 ON bool-expr ...]

* Reporting Aggregated Data Using the Group Functions:

    max(), min(), sum(), avg(), count()




=====================================================
Data Manipulation Language (DML) in SQL Server
=====================================================

1. INSERT:
----------
Used to add new records to a table.

Syntax:
    INSERT INTO table_name (column1, column2, ...)
    VALUES (value1, value2, ...);

2. UPDATE:
----------
Used to modify existing records.

Syntax:
    UPDATE table_name
    SET column1 = value1, column2 = value2, ...
    WHERE condition;


3. DELETE:
----------
Used to remove one or more records.

Syntax:
    DELETE FROM table_name
    WHERE condition;





Introduction to Data Definition Language (DDL) in SQL Server

1. CREATE TABLE:
----------------
Syntax:
    CREATE TABLE table_name (
        column_name datatype [CONSTRAINT constraint_name constraint_type],
        ...,
        [CONSTRAINT constraint_name constraint_type]
    );

Naming Rules:
    - Maximum 128 characters.
    - Can include A-Z, a-z, 0-9, _, @, $, #.
    - Must begin with a letter.
    - Must not be a reserved keyword.

Common Datatypes in SQL Server:
    - Numeric: INT, BIGINT, SMALLINT, DECIMAL(p,s), FLOAT, REAL
    - Text: CHAR(n), VARCHAR(n), TEXT
    - Date/Time: DATE, DATETIME, SMALLDATETIME, TIME
    - Other: BIT, MONEY, UNIQUEIDENTIFIER, VARBINARY(MAX)

Constraint Types:
    - PRIMARY KEY
    - UNIQUE
    - NOT NULL
    - CHECK (condition)
    - FOREIGN KEY REFERENCES other_table(column)

    
2. ALTER TABLE:
---------------
Syntax Overview:
    ALTER TABLE table_name
    -- Add a new column
    ADD column_name datatype;

    -- Modify column datatype or nullability
    ALTER COLUMN column_name new_datatype;

    -- Drop a column
    DROP COLUMN column_name;

    -- Add a constraint
    ADD CONSTRAINT constraint_name constraint_type;

    -- Drop a constraint
    DROP CONSTRAINT constraint_name;

Note:
    - RENAME COLUMN is not supported directly; use SQL Server Management Studio (SSMS) or recreate the column.


    3. DROP TABLE:
--------------
Syntax:
    DROP TABLE table_name;






-- 🧠 This course demonstrates how to use SELECT in practical contexts, from basic retrieval to advanced logic and multi-table operations.
------------------------------------------------------------
------------------------------------------------------------
-- 🔰 BEGINNER LEVEL: Basic SELECT, WHERE, and ORDER BY
------------------------------------------------------------








select  e.department_id, d.department_name, max(salary) ,min(salary),sum(salary) ,count(*),avg(salary)  
from employees e , departments d
where e.department_id = d.department_id
group by    e.department_id, department_name



select  e.job_id, job_title, max(salary) maximum ,min(salary) minimum,sum(salary) total ,count(*) "num of emp",avg(salary)  average  
from employees e , jobs j
where e.job_id =j.job_id
group by  e.job_id, job_title
order by  e.job_id




Write a query to display the department_id, department name , maximum salary, minimum salary, total salary, 
average salary (rounded), and number of employees for each department from the employees table. 
Include only departments with department_id greater than 30 and  at least 5 employees. 
Sort the result by department_id.

select  e.department_id, d.department_name, max(salary) maximum ,min(salary) minimum,sum(salary) total ,count(*) num ,avg(salary) average 
from employees e join departments d
on e.department_id = d.department_id
where e.department_id >30 
group by  e.department_id, d.department_name
having count(*) >=5
order by e.department_id desc


select  e.department_id, d.department_name, 
max(salary) maximum ,min(salary) minimum,sum(salary) total ,count(e.employee_id) num ,cast(round(avg(salary),0) as int ) average 
from employees e , departments d
where e.department_id = d.department_id   and  e.department_id >30   
group by  e.department_id, d.department_name
having count(*) >=5
order by e.department_id desc
------------------------------------------------------------------------

insert into departments 
values(300,'IT APP',200,1800)

insert into departments 
values(300,'IT APP',null,null)

insert into departments    (department_id ,department_name)
values(310,'IT Program')

select  * 
from departments

select  * 
from locations



select  * 
from employees



insert into employees   
values(208,null,'Alswaify','mo@gmail.com',null,'2000-01-01','IT_PROG',5000,null,null,60)



insert into employees (employee_id,last_name,email,hire_date,job_id,salary,department_id)  
values(209,'Alswaify','mo@gmail.com','2000-01-01','IT_PROG',5000,60)



update  employees
set first_name = 'Mohamed' , salary = 7000
where employee_id in(208,209)



delete  employees
where employee_id in(208,209)
---------------------------------------------------------------------------------------


create  database FirstDB;

use master

drop  database FirstDB;



create table My_Depts
(
Dept_Id int primary key,
Dept_Name  VARCHAR(30) UNIQUE
);

drop table My_Depts

create table My_Depts
(
Dept_Id int constraint  My_Depts_Dept_Id_PK primary key,
Dept_Name  VARCHAR(30) constraint  My_Depts_Dept_Name_UQ  UNIQUE
);

create table My_Depts
(
Dept_Id int ,
Dept_Name  VARCHAR(30) ,

constraint  My_Depts_Dept_Id_PK primary key(Dept_Id),
constraint  My_Depts_Dept_Name_UQ  UNIQUE(Dept_Name)
);

insert into My_Depts
values(2,'App')


select  * 
from My_Depts



create table My_emps
(
Emp_Id int ,
Emp_Name varchar(60) not null ,
salary DECIMAL(8,2) ,
Gendr char(1),
Start_Data  DATE default getdate() ,
Dept_Id int,
constraint  My_emps_Emp_Id_PK primary key(Emp_Id),
constraint  My_emps_salary_CK check(salary between   4000 and  9000),
constraint  My_emps_Gendr_CK check(Gendr in('M','F')),
constraint  My_emps_Dept_Id_FK  FOREIGN KEY(Dept_Id)   REFERENCES My_Depts(Dept_Id)
);
insert into  My_emps  (Emp_Id,Emp_Name,salary,Gendr,Dept_Id)
values(1,'Mohamed Alswaify',4000,'M',1)
select  * 
from My_emps
-- * create courses table as follow:
--   cours_id => pk
--   course_title => not null
--   price => between 800 and 3000
--   start_date => default value the date after 7 days
--   duration => btw 12 and 120

create table courses
(
cours_id int,
 course_title varchar(50) not null,
 price DECIMAL(8,2) ,
 Start_Data  DATE default getdate()+7 ,
 duration int ,
constraint courses_cours_id_PK primary key(cours_id),
constraint courses_price_CK check(price between   800 and  3000),
constraint courses_duration_CK check(duration between   12 and  120)
);


-- * create a projects table 
--   project_id => pk
--   project_name => not null
--   client_name => 
--   hour_rate => positive greater than 1
CREATE TABLE Projects (
    Project_ID INT constraint Projects_Project_ID_PK PRIMARY KEY,
    Project_Name VARCHAR(100) NOT NULL,
    Client_Name VARCHAR(100),
    Hour_Rate DECIMAL(10, 2) constraint  Projects_Hour_Rate_CK CHECK (Hour_Rate > 1)
);
-- * create a tasks table
--   task_id => pk
--   description => max char 255
--   start_date => date
--   end_date => greater than start_date
--   project_id => foreign key

CREATE TABLE Tasks (
    Task_ID INT PRIMARY KEY,
    Description VARCHAR(255),
    Start_Date DATE,
    End_Date DATE,
    Project_ID INT FOREIGN KEY REFERENCES Projects(Project_ID),
    CONSTRAINT CK_Tasks_EndDate CHECK (End_Date > Start_Date)
);

CREATE TABLE Tasks (
    Task_ID INT PRIMARY KEY,
    Description VARCHAR(255),
    Start_Date DATE,
    End_Date DATE,
    Project_ID INT ,
	 CONSTRAINT Tasks_Project_ID_FK  FOREIGN KEY(Project_ID) REFERENCES Projects(Project_ID),
    CONSTRAINT CK_Tasks_EndDate CHECK (End_Date > Start_Date)
);



 ALTER TABLE Projects
 add city varchar(20) default 'Riyadh'

 ALTER TABLE Projects
  ALTER COLUMN city varchar(80) 


  ALTER TABLE Projects
  DROP CONSTRAINT Projects_Hour_Rate_CK;

   ALTER TABLE Projects
  add constraint  Projects_Hour_Rate_CK CHECK (Hour_Rate > 1)
 select  * 
 from Projects





 -----------------------------------------------------------
-- ✅ END OF COURSE
------------------------------------------------------------