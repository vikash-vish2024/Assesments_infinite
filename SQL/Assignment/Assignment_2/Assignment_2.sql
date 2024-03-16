create database Assignment_2
use Assignment_2

--Two tables to be created in the database that may be used for the following exercises. 
--Their structure is as follows:

create table Employees
(Empno numeric(4)unique,
Ename varchar(20),
Job varchar(20),
Mgr_id numeric(4),
hiredate date,
salary numeric(6),
comm numeric(4),
deptno numeric(2) foreign key references Department(Deptno) )

create table Department
(Deptno numeric (2) primary key,
Dname varchar(20),
Location varchar(15))

Select * from Department
Select * from Employees

--insert data into Department
insert into Department values
(10,'ACCOUNTING','NEW YORK'),
(20,'RESEARCH','DALLAS'),
(30,'SALES','CHICAGO'),
(40,'OPERATION','BOSTON')

--Inserting data into Employees

Insert into Employees  values
(7369,'SMITH', 'CLERK',7902,'1980-12-17',800,NULL,20),
(7499,'ALLEN','SALESMAN',7698,'1981-02-20',1600,300,30),
(7521,'WARD','SALESMAN',7698,'1981-02-22',1250,500,30),
(7566,'JONES','MANAGER',7839,'1981-04-02',2975,NULL,20),
(7654,'MARTIN','SALESMAN', 7698,'1981-09-28',1250,1400,30),
(7698,'BLAKE','MANAGER', 7839,'1981-05-01',2850,NULL,30),
(7782,'CLARK','MANAGER', 7839,'1981-06-09',2450,NULL,10),
(7788,'SCOTT','ANALYST', 7566,'1987-04-19',3000,NULL,20),
(7839,'KING','PRESIDENT',NULL,'1981-NOV-17',5000,NULL,10),
(7844,'TURNER','SALESMAN',7698,'1981-09-08',1500,0,30),
(7876,'ADAMS','CLERK',7788, '1987-04-23',1100,NULL,20),
(7900,'JAMES','CLERK',7698, '1981-12-03',950,NULL,30),
(7902,'FORD','ANALYST',7566,'1981-12-03',3000,NULL,20),
(7934,'MILLER','CLERK',7782,'1982-01-23',1300,NULL, 10)

--Write and execute the necessary SQL statements to perform the following tasks.

--List all employees whose name begins with 'A'
select * from Employees where Ename like '[A]%'

--Select all those employees who don't have a manager
select * from Employees where Mgr_id is null

-- List employee name, number and salary for those employees who earn in the range 1200 to 1400.
select * from Employees where salary between 1200 and 1400

--Give all the employees in the RESEARCH department a 10% pay rise.
--Verify that this has been done by listing all their details before and after the rise

--Before Rise
select Empno, Deptno, Salary as OriginalSalary
from Employees
		where Deptno = (select Deptno from Department where Dname = 'RESEARCH');

--After Rise
select  Empno, Deptno, (Salary+(salary*10)/100) as 'Salary After Rise'
from Employees
		where Deptno = (select Deptno from Department where Dname = 'RESEARCH');


--Find the number of CLERKS employed. Give it a descriptive heading.
select COUNT(*) AS NumberOfClerks
from Employees
		where Job = 'CLERK'

--Find the average salary for each job type and the number of people employed in each job.
select Job, AVG(Salary) AS 'Average Salary', count(*) as 'Number of empoyee' 
from Employees
group by Job

--List the employees with the lowest and highest salary.
select * from Employees 
	where salary =(select max(salary) from Employees)
	  or salary =(select min(salary) from Employees)
	
--List full details of departments that don't have any employees.
select dept.Deptno,dept.Dname,dept.Location
from Department dept
left join Employees em on dept.Deptno=em.deptno
where em.Empno is null

--Get the names and salaries of all the analysts earning more than 1200 who are based in department 20.
--Sort the answer by ascending order of name.
select * from Employees
where(job='Analyst' and salary>1200 and deptno=20)

--For each department, list its name and number together with the total salary paid to employees in that department.
select dept.Dname as 'Department Name',dept.Deptno as 'Departmet No',sum(Emp.salary) as 'Total Salary'
from Department dept left join
Employees emp on dept.Deptno=emp.deptno
group by dept.Deptno,dept.Dname
order by dept.Deptno

--Find out salary of both MILLER and SMITH.
select Ename,salary from Employees
where (Ename='miller' or Ename='smith')
order by Ename

-- Find out the names of the employees whose name begin with ‘A’ or ‘M’.
select Ename from Employees
where Ename like 'A%M'

--Compute yearly salary of SMITH
select ename,(salary*12) as 'yearly salary' from Employees
where Ename=('smith')

--List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 
select Ename,salary from Employees
where salary not between 1500 and 2850
order by salary

--Find all managers who have more than 2 employees reporting to them
select  Mgr_id, count(Empno) as EMP_COUNT
from Employees
group by Mgr_id
having count(EMPNO) > 2;