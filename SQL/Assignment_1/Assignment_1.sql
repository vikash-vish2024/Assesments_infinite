use Assignment_1

--Department Table
create table Department

(Deptno numeric(2) primary key,
Dname varchar(15) not null, Loc varchar(20))

--Client Table
create table Clients

(Client_id int primary key,
Cname varchar(30) not null,
Address varchar(40),Email varchar(30) unique,
phone numeric(10),Business varchar(20) ) 

--Employee Table
create table Employee
(Empno numeric(4) primary key,
Ename varchar(20) not null,
job varchar(15),
salary numeric(7),
Deptno numeric(2) foreign key references department(Deptno))

create table Project
(Project_ID numeric(3) primary key,
Descr varchar(30) not null,
Start_date date,
Planned_End_Date date,
Actual_End_Date date )

alter table Project 
add constraint CK_Actual_End_Date
check(Actual_End_Date>Planned_End_Date)