create database Assesment
use Assesment

--Create a book table with id as primary key and provide the appropriate data type to other attributes 
--.isbn no should be unique for each book
create table Books
(BookId int primary key,
Title text,
author varchar(20),
isbn numeric(12) unique,
Publish_Date datetime)

--Insert data in  book
insert into Books values
	(1,'My first SQL Book','Mary Parker',981483029127,'2012-02-22 12:08:17'),
	(2,'My Second SQL Book','John Mayer',857300923712,'1972-07-18 09:22:45'),
	(3,'My Third SQL Book','Cary Flint',523120967812,'2015-10-18 14:05:44')

select * from Books

--Write a query to fetch the details of the books written by author whose name ends with er.
select * from Books 
	where author like '%er'

create table Review
(id int primary key,
BookId int references Books(BookId),
ReviewerName varchar(20),
Content text,
rating int,
PublishDate datetime)

insert into Review values
(1,1,'John Smith','My First Review',4,'2017-12-10 05:50:22'),
(2,2,'John Smith','My Second Review',5,'2017-10-13 15:05:12'),
(3,3,'Alice walker','Another Review',1,'2017-10-22 23:47:10')

--Display the reviewer name who reviewed more than one book.
select ReviewerName from Review
where ReviewerName in (
	select ReviewerName
		from Review								--??????
		group by ReviewerName
		having count(distinct ReviewerName) > 1
		)


-- creating Employee table
create table Employees
(Eid int primary key,
EName varchar(20),
Age int,
Address varchar(20),
salary float)

-- insert into Employee table
insert into Employees values
	(1,'Ramesh',32,'Ahmedabad',2000),
	(2,'Khilan',25,'Delhi',1500),
	(3,'Kaushik',23,'Kota',2000),
	(4,'Chaitali',25,'Mumbai',6500),
	(5,'Hardik',27,'Bhopal',8500),
	(6,'Komal',22,'MP',null),
	(7,'Muffy',24,'Indore',null)

--Display the Names of the Employee in lower case, whose salary is null
select lower(Ename) from Employees
 where salary is null
	
--Creating Customer table
create table Customer
(id int primary key,
Cname varchar(20),
Age int,
Address varchar(15),
Salary float)

--inserting Customer data
insert into Customer values
	(1,'Ramesh',32,'Ahmedabad',2000),
	(2,'Khilan',25,'Delhi',1500),
	(3,'Kaushik',23,'Kota',2000),
	(4,'Chaitali',25,'Mumbai',6500),
	(5,'Hardik',27,'Bhopal',8500),
	(6,'Komal',22,'MP',4500),
	(7,'Muffy',24,'Indore',10000)

--Order table
create table Orders
(Oid numeric(3),
OrDate datetime,
CuestId int references Customer(id),
Amount int)

--inserting data into order table
insert into Orders values
(102,'2009-10-08 00:00:00',3,3000),
(100,'2009-10-08 00:00:00',3,1500),
(101,'2009-11-20 00:00:00',2,1560),
(103,'2008-05-20 00:00:00',4,2060)

--Write a query to display the Date,Total no of customer placed order on same Date
select ordate, count(distinct Oid) as 'Total Orders'
	from Orders
		group by OrDate
		

--Student details table
create table StudentDetails
(RegisterNo int primary key,
SName varchar(20),
Age int,
Qualification varchar(8),
Mobileno numeric(10) unique,
MailId varchar(20) Unique,
Location varchar(15),
Gender Varchar(5))

--data into student
insert into StudentDetails values
(2,'Sai',22,'B.E',9952836777,'Sai@gmail.com','Chennai','M'),
(3,'Kumar',20,'BSC',7890125648,'Kumar@gmail.com','Madurai','M'),
(4,'Selvi',22,'B.tech',8904567342,'Selvi@gmail.com','Selam','F'),
(5,'Nisha',25,'M.E',7834672310,'Nisha@gmail.com','Theni','F'),
(6,'Saisaran',21,'B.A',7890345678,'Saran@gmail.com','Madurai','F'),
(7,'Tom',23,'BCA',8901234675,'Tom@gmail.com','pune','M')


--Write a sql server query to display the Gender,Total no of male and female from the above
--relation .
select Gender, count(Gender) as 'Total Gender'
	from StudentDetails
		group by Gender
	