 ***********************Session 3**********************************
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
-- SELECT * |  column1, column2, ...
-- FROM table_name
-- [WHERE condition]
-- [ORDER BY column1, column2, ... [ASC|DESC]]



-- 🔹 Operators:
--   ➕ Arithmetic: +, -, *, /
--   🔁 Comparison: =, !=, <>, <, <=, >, >=
--   🧠 Logical: AND, OR, NOT
--   🧮 Range: not BETWEEN ... AND ...
--   📋 List: [not] IN (...)
--   🔍 Pattern: [not] LIKE 'pattern'
--   🚫 NULL Check: IS NULL, IS NOT NULL

-- * Displaying Data from Multiple Tables Using Joins:

--     * FROM table1 [INNER] JOIN table2 ON bool-expr [[INNER] JOIN table3 ON bool-expr ...]



-- 🧠 This course demonstrates how to use SELECT in practical contexts, from basic retrieval to advanced logic and multi-table operations.
------------------------------------------------------------

------------------------------------------------------------
-- 🔰 BEGINNER LEVEL: Basic SELECT, WHERE, and ORDER BY
------------------------------------------------------------


select  last_name ,salary , job_id , hire_date , department_id
from employees
where department_id  in(30,60,90)


select  last_name ,salary , job_id , hire_date , department_id
from employees
where job_id  ='SA_REP'


select  last_name ,salary , job_id , hire_date , department_id
from employees
where job_id  ='IT_PROG'


select  last_name ,salary , job_id , hire_date , department_id
from employees
where job_id in( 'SA_REP'  ,  'IT_PROG'  )



select  last_name ,salary , job_id , hire_date , department_id
from employees
where job_id   like'IT%'


select  last_name ,salary , job_id , hire_date , department_id
from employees
where last_name like'%z'


select  last_name ,salary , job_id , hire_date , department_id
from employees
where last_name like'k%'

select  last_name ,salary , job_id , hire_date , department_id
from employees
where last_name like'_ee%'



select  last_name ,salary , job_id , hire_date , department_id
from employees
where  department_id is null


select  last_name ,salary , job_id , hire_date , department_id
from employees
where  department_id is not null


select  last_name ,salary , job_id , hire_date , department_id
from employees
where department_id not  in(30,60,90)


select  last_name ,salary , job_id , hire_date , department_id
from employees
where job_id  not  like'IT%'

* Display the employee name, job, and department for all employees
 who work at department 30 or  department 50 or departments 70

 select  * 
 from employees

  select  first_name  + ' '+ last_name   "employee name" , job_id   JOB ,department_id department
 from employees
 where  department_id in(30,50,70)



* Display the employee name, department, and salary for all employees 
who have no commission (NULL)

select  first_name  + ' '+ last_name   "employee name" , salary ,department_id department ,commission_pct
 from employees
 where commission_pct is null



 * Display the last name, job, and salary for all employees 
whose salary is not equal 
to $2,500, $3,500, or $7,000.


select  * 
from employees


select  last_name ,job_id,salary
from employees
where salary not in(2500,3500,70000)


select  last_name,salary,hire_date ,department_id
from  employees
where hire_date not between '2000-01-01'   and '2000-12-31'  
order by   hire_date 






select  last_name,salary,hire_date ,department_id
from  employees
where salary >=6000



select  last_name,salary,hire_date ,department_id
from  employees
where department_id = 50   



select  last_name,salary,hire_date ,department_id
from  employees
where department_id = 50    and  salary >=6000


select  last_name,salary,hire_date ,department_id
from  employees
where department_id = 50    or  salary >=6000


--IT_PROG ,SA_REP
select  last_name,salary,job_id 
from  employees
where job_id= 'IT_PROG'    or  job_id= 'SA_REP' 


select  last_name,salary,job_id 
from  employees
where job_id in( 'IT_PROG','SA_REP' )    and salary >=9000


* Write a query that displays the last name and salary for all employees whose name starts 
with the letters “J,” “A,” or “M.” and the salary more than 6000 SR 
after that  Sort the results descending by the employees’ last names.

(13+7+10 )/3 = 23.33

select  last_name ,salary 
from employees
where (last_name like'J%'  or  last_name like'A%'     or  last_name like'M%'  )    and     salary >6000
order by last_name desc



select  * 
from employees

select  * 
from jobs

select  * 
from departments



select first_name  ,department_name 
from employees join  departments
on employees.department_id  = departments.department_id


select e.first_name  ,d.department_name 
from employees e join  departments d
on e.department_id  = d.department_id




select  e.first_name ,job_title
from employees e join  jobs j
on e.job_id = j.job_id


* Write a query for the HR department to produce the addresses of all the 
departments. Use the LOCATIONS tables. Show the  street address, 
city, state or province, and country in the output.



select  * 
from locations 

select  * 
from departments


select  department_name ,street_address,city,state_province ,country_id 
from departments d join  locations l
on d.location_id = l.location_id







 -----------------------------------------------------------
-- ✅ END OF COURSE
------------------------------------------------------------