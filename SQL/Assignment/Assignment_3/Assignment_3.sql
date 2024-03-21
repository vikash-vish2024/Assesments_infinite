use Assignment_2
select * from Employees
select * from Department
--ASSIGNMENT 3

--1. Retrieve a list of MANAGERS.
select Ename,salary from Employees
	where job='Manager'

--2. Find out the names and salaries of all employees earning more than 1000 per month.
select Ename,salary from Employees
	where salary>1000

--3. Display the names and salaries of all employees except JAMES.
select Ename,salary from Employees 
	where Ename!='James'

--4. Find out the details of employees whose names begin with ‘S’.
select * 
	from Employees
		where Ename like 'S%'

--5. Find out the names of all employees that have ‘A’ anywhere in their name.
select Ename 
	from Employees
		where Ename like '%a%'
	
--6. Find out the names of all employees that have ‘L’ as their third character in their name. 
select * from Employees
	where Ename like '__L%'

--7. Compute daily salary of JONES. 
select Ename,salary as MonthlySal,salary/30 as DailySal 
	from Employees
		where Ename='Jones'

--8. Calculate the total monthly salary of all employees.
select sum(salary) as totalSal 
	from Employees

--9. Print the average annual salary 
select avg(salary*12) as 'Avarage Annual Salary'
	from Employees
	
--or we can declare local variable and print
declare @sal int
set @sal=(select avg(salary*12) from Employees)
print 'The avarage annual salary for employees ->'+' '+cast(@sal as varchar(10))

--10. Select the name, job, salary, department number of all employees except 
--SALESMAN from department number 30.
select Ename,job,salary,deptno 
	from Employees
		where job not like 'Salesman' 
			and deptno  not like 30

--11. List unique departments of the EMP table.
select distinct deptno from Employees
select distinct dname from Department
	
--12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. 
 --Label the columns Employee and Monthly Salary respectively
select Ename as Employee, salary as 'Monthly Salary',deptno as Department
	from Employees
		where salary>1500 
			and deptno in (10,30)

--13. Display the name, job, and salary of all the employees whose job is MANAGER or 
 --ANALYST and their salary is not equal to 1000, 3000, or 5000.
select Ename,job,salary
 from Employees
	where job in('Analyst','Manager') 
		and salary not in(1000,3000,5000)

--14. Display the name, salary and commission for all employees whose commission 
 --amount is greater than their salary increased by 10%
select Ename,salary as 'Old Salary',comm as 'commision',(salary*1.10)as'10% Hike'
	from Employees
		where salary<comm

--15. Display the name of all employees who have two Ls in their name and are in 
 --department 30 or their manager is 7782.
select Ename	
	from Employees
		where Ename like '%l%l%' 
			and deptno=30
				or Mgr_id=7782

--16. Display the names of employees with experience of over 30 years and under 40 yrs.
 --Count the total number of employees. 
 select Ename
	from Employees
		where DATEDIFF(yy,hiredate,getdate()) 
			between 30 and 40 
			
--17. Retrieve the names of departments in ascending order and their employees in 
--descending order. 
select dname,ename 
	from Employees join Department 
	on Department.deptno=Employees.deptno
	order by dname asc,ename desc

--18. Find out experience of MILLER. 
declare @experince date

select @experince=hiredate
	from Employees 
		where Ename like 'Miller'
select datediff(YY,@experince,getdate()) as Experience


