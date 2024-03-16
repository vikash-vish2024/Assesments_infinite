Create database Assignment
use Assignment

--Department Table
create table Department

(Deptno numeric(2) primary key,
Dname varchar(15) not null, Loc varchar(20))

--Client Table
create table Clients

(Client_id numeric(4) primary key,
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

--Project Table
create table Project
(Project_ID numeric(3) primary key,
Descr varchar(30) not null,
Start_date date,
Planned_End_Date date,
Actual_End_Date date, 
Budget numeric(10),
Client_ID numeric(4) foreign key references Clients(client_Id))

--Adding constrain to date
alter table Project 
add constraint CK_Actual_End_Date
check(Actual_End_Date>Planned_End_Date)

--Employee Project Task Table
create table Emp_Project_Task(
Project_ID numeric(3),
Empno numeric(4),
Start_Date date,
End_Date date,
Task varchar(25),
Status varchar(15),
primary key(Project_ID,Empno),
foreign key (Project_ID)references Project(Project_ID),
foreign key (Empno)references Employee(Empno))


--(-------------------------------------------------------)--
--inserting client data
insert into clients values
(1001,'ACME utilities','Noida','Contact@acmeutil.com','9567880032','Manufacturing'),
(1002,'Trackon Consultant','Mumbai','Consult@trackon.com','8734210090','Consultant'),
(1003,'MoneySaver Distributors','Kolkata','save@moneysaver.com','7799886655','Reseller'),
(1004,'Lawful Crop','Chennai','justice@lawful.com','9210342219','Professional')

select * from clients

--inserting Department information
insert into Department values
(10,'Design','Pune'),
(20,'Development','pune'),
(30,'Testing','Mumbai'),
(40,'Document','Mumbai')

--inserting Employees data
insert into Employee values
(7001,'Sandeep','Analyst',25000,10),
(7002,'Rajesh','Designer',30000,10),
(7003,'Madhav','Developer',40000,20),
(7004,'Manoj','Developer',40000,20),
(7005,'Abhay','Designer',35000,10),
(7006,'Uma','Tester',30000,30),
(7007,'Gita','Tech. Writer',30000,40),
(7008,'Priya','Tester',35000,30),
(7009,'Nutan','Developer',45000,20),
(7010,'Smita','Analyst',20000,10),
(7011,'Anand','Project Mgr',65000,10)


--Project Information
insert into Project values
(401,'Inventory','2011-04-01','2011-10-01','2011-10-31',150000,1001),
(402,'Accounting','2011-08-01','2012-01-01',null,150000,1002),
(403,'Payroll','2011-12-11','2011-12-31',null,150000,1003),
(404,'Contact mgmt','2011-11-01','2011-12-31',null,150000,1004)

select * from project

--insert EmpProject task 
insert into Emp_Project_Task values
(401,7001,'2011-04-01','2011-04-20','System Analysis','Completed'),
(401,7002,'2011-04-21','2011-05-30','System Design','Completed'),
(401,7003,'2011-06-01','2011-07-15','Coding','Completed'),
(401,7004,'2011-07-18','2011-09-01','Coding','Completed'),
(401,7006,'2011-09-03','2011-09-15','Testing','Completed'),
(401,7009,'2011-09-18','2011-10-05','Code Change','Completed'),
(401,7008,'2011-10-06','2011-10-16','Testing','Completed'),
(401,7007,'2011-10-06','2011-10-22','Documentation','Completed'),
(402,7011,'2011-10-22','2011-10-31','Sign Off','Completed'),
(402,7010,'2011-08-01','2011-08-20','System Analysis','Completed'),
(402,7002,'2011-08-22','2011-09-30','System Design','Completed'),
(402,7004,'2011-10-01',null,'Coding','in Process')
