 ***********************Session 4**********************************
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


-- 🧠 This course demonstrates how to use SELECT in practical contexts, from basic retrieval to advanced logic and multi-table operations.
------------------------------------------------------------
------------------------------------------------------------
-- 🔰 BEGINNER LEVEL: Basic SELECT, WHERE, and ORDER BY
------------------------------------------------------------

select  * 
from employees

select  * 
from jobs

select  * 
from departments

select  * 
from locations

select  e.first_name ,job_title
from employees e join  jobs j
on e.job_id = j.job_id


select first_name  ,department_name 
from employees join  departments
on employees.department_id  = departments.department_id


select e.first_name  ,d.department_name , job_title
from employees e join  departments d
on e.department_id  = d.department_id
join jobs j
on e.job_id = j.job_id

where  d.department_name = 'IT'

* Write a query for the HR department to produce the addresses of all the 
departments. Use the LOCATIONS tables. Show the location ID, street address, 
city, state or province, and country  in the output. 

select  department_name ,street_address,city,state_province ,country_name 
from departments d join  locations l
on d.location_id = l.location_id
join  countries c
on l.country_id = c.country_id

select  * 
from countries

* The HR department needs a report of employees in Toronto. Display the last name, 
job, department number, and the department name for all employees who work in 
Toronto. 

select  * 
from jobs

select  * 
from departments

select  last_name ,job_title ,e.department_id ,department_name,city
from employees e join jobs j
on e.job_id = j.job_id
join departments d
on e.department_id = d.department_id
join locations l 
on  d.location_id = l.location_id
where city = 'Toronto'



select  last_name ,job_title ,city
from employees e join jobs j
on e.job_id = j.job_id
join departments d
on e.department_id = d.department_id
join locations l 
on  d.location_id = l.location_id
where city = 'Toronto'






select  e.first_name ,job_title
from employees e inner join  jobs j
on e.job_id = j.job_id


select  e.first_name ,job_title
from employees e cross join  jobs j
where  e.job_id = j.job_id



select  e.first_name ,job_title
from employees e ,  jobs j
where  e.job_id = j.job_id and salary>15000

select  e.first_name ,job_title
from employees e inner join  jobs j
on e.job_id = j.job_id
where salary>15000


select e.first_name  ,d.department_name , job_title
from employees e join  departments d
on e.department_id  = d.department_id
join jobs j
on e.job_id = j.job_id


select e.first_name  ,d.department_name , job_title
from employees e ,  departments d,  jobs j
where e.department_id  = d.department_id and e.job_id = j.job_id

* The HR department needs a report of employees in Toronto. Display the last name, 
job, department number, and the department name for all employees who work in 
Toronto. (use cross join)

select  last_name ,job_title ,city
from employees e join jobs j
on e.job_id = j.job_id
join departments d
on e.department_id = d.department_id
join locations l 
on  d.location_id = l.location_id
where city = 'Toronto'

select  last_name ,job_title ,city
from employees e , jobs j ,departments d ,locations l 
where e.job_id = j.job_id and e.department_id = d.department_id and d.location_id = l.location_id and city = 'Toronto'







select  * 
from employees


select  * 
from departments

select  department_name ,first_name 
from departments d left outer join employees e
on d.manager_id = e.employee_id

select  department_name ,first_name 
from departments d  right outer join employees e
on d.manager_id = e.employee_id
order by  department_name desc



select  department_name ,first_name 
from departments d  full outer join employees e
on d.manager_id = e.employee_id
order by  department_name desc

--------------------------------------------------
select  max(salary) ,min(salary),sum(salary) ,count(*),avg(salary)  
from employees
where department_id = 60

select  max(salary) ,min(salary),sum(salary) ,count(*),avg(salary)  
from employees
where job_id = 'sa_man'


select  department_id, max(salary) ,min(salary),sum(salary) ,count(*),avg(salary)  
from employees
group by  department_id

Write a query to display the job , maximum salary, minimum salary, total salary, 
average salary , and number of employees for each jobs from the employees table. 
Sort the result by job.


select  job_id, max(salary) maximum ,min(salary) maximum,sum(salary) total ,count(*) "num of emp",avg(salary)  average  
from employees
group by  job_id
order by  job_id


select  e.department_id, d.department_name, max(salary) ,min(salary),sum(salary) ,count(*),avg(salary)  
from employees e , departments d
where e.department_id = d.department_id
group by    e.department_id, department_name

select  e.job_id, job_title, max(salary) maximum ,min(salary) minimum,sum(salary) total ,count(*) "num of emp",avg(salary)  average  
from employees e , jobs j
where e.job_id =j.job_id
group by  e.job_id, job_title
order by  e.job_id



select  e.department_id, d.department_name, max(salary)  maximum ,min(salary )minimum  ,sum(salary) total ,count(*) num,avg(salary)   avgarge
from employees e , departments d
where e.department_id = d.department_id   and  e.department_id not in(50,90)
group by    e.department_id, department_name
having sum(salary) >30000
order by   e.department_id
 

Write a query to display the department_id, department name , maximum salary, minimum salary, total salary, 
average salary (rounded), and number of employees for each department from the employees table. 
Include only departments with department_id greater than 30 and having at least 5 employees. 
Sort the result by department_id.


 -----------------------------------------------------------
-- ✅ END OF COURSE
------------------------------------------------------------