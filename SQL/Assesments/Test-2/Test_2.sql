create database Test
use test
--table Employee and Department
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

--insert data into Department
insert into Department values
(10,'ACCOUNTING','NEW YORK'),
(20,'RESEARCH','DALLAS'),
(30,'SALES','CHICAGO'),
(40,'OPERATION','BOSTON')
--inserting data into Employees
Insert into Employees  values
(7369,'SMITH', 'CLERK',7902,'1980-12-17',800,NULL,20),
(7499,'ALLEN','SALESMAN',7698,'2019-02-20',1600,300,30),
(7521,'WARD','SALESMAN',7698,'1981-02-22',1250,500,30),
(7566,'JONES','MANAGER',7839,'1981-04-02',2975,NULL,20),
(7654,'MARTIN','SALESMAN', 7698,'1981-09-28',1250,1400,30),
(7698,'BLAKE','MANAGER', 7839,'2020-05-01',2850,NULL,30),
(7782,'CLARK','MANAGER', 7839,'2018-06-09',2450,NULL,10),
(7788,'SCOTT','ANALYST', 7566,'2023-04-19',3000,NULL,20),
(7839,'KING','PRESIDENT',NULL,'1981-NOV-17',5000,NULL,10),
(7844,'TURNER','SALESMAN',7698,'2023-09-08',1500,0,30),
(7876,'ADAMS','CLERK',7788, '1987-04-23',1100,NULL,20),
(7900,'JAMES','CLERK',7698, '2016-12-03',950,NULL,30),
(7902,'FORD','ANALYST',7566,'1981-12-03',3000,NULL,20),
(7934,'MILLER','CLERK',7782,'1982-01-23',1300,NULL, 10)

--Ques-1
--1.Write a query to display your birthday( day of week)
declare @dob date
set @dob='1990-04-12'
select Datename(dw,@dob) as [Vikash-Birthday]

--Ques-2
--2 Write a query to display your age in days
declare @dob1 date
set @dob1='1990-04-12'
select datediff(dd,@dob1,getdate()) as [Vikash-Age in Days]

--Ques-3
-- Write a query to display all employees information those who joined before 5 years in the current month
 select *
	from Employees
		where DATEDIFF(yy,hiredate,getdate()) >5
			
 --Ques-4
 --4.Create table Employee with empno, ename, sal, doj columns and perform the following operations in a single transaction
	--a. First insert 3 rows 
	--b. Update the second row sal with 15% increment  
    --c. Delete first row.
	--After completing above all actions how to recall the deleted row without losing increment of second row.

--Employee Table
create table Employee
(Empno numeric(3) primary key,
EmpName varchar(30),
EmpSal float,
EmpDoj Date)
--creating transaction according to the given question
begin tran
	--insert
	insert into Employee values
		(101,'Avinash',26000,'2024-02-15'),
		(102,'Satyam',29000,'2020-8-12'),
		(103,'vikash',21000,'2018-09-20')
		select * from Employee
			save tran t1
	--update
	update Employee
		set EmpSal=EmpSal+(EmpSal*.15) where Empno like 102
		select * from Employee where Empno like 102
			save tran t2
	--delete
	delete Employee 
		where Empno like 103
		select * from Employee where Empno like 103
			save tran t3
	 rollback tran t2
 commit  
 select * from Employee

--Ques-5
--Create a user defined function calculate Bonus for all employees of a  given job using following conditions
	--a.     For Deptno 10 employees 15% of sal as bonus.
	--b.     For Deptno 20 employees  20% of sal as bonus
	--c      For Others employees 5%of sal as bonus

create or alter function calculate_bonus(@Deptno int,@salary int)
returns float
begin
    declare @bonus float
   --For Deptno 10 employees 15% of sal as bonus.
    if @Deptno = 10 
        set @bonus = @salary * 0.15
	--For Deptno 20 employees  20% of sal as bonus   ---??????
    else if @deptno = 20 
        set @bonus = @salary * 0.20
   --For Others employees 5%of sal as bonus
    else
        set @bonus = @salary * 0.05
   return @bonus;
end
select * from calculate_bonus (10,6000)
--Some error can't able to solve
