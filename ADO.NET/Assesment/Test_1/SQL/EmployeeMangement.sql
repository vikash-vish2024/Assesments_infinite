create database Employeemanagement

create table Employee_Details 
(
    Empno int primary key,
    EmpName varchar(30) NOT NULL,
    Empsal numeric(10,2) check (Empsal >= 25000),
    Emptype char(1) check (Emptype in('P','C'))
)

--procedure to add data into Employee table and generate new Employee number
create or alter proc AddEmployee
    @EmpName varchar(30),
    @Empsal numeric(10,2),
    @Emptype char(1)
as
	begin
		-- generating new employee number using the maxing available employee
		declare @NewEmpno int=0;
		--set @NewEmpno = @NewEmpno+(select (MAX(Empno)) + 1 from Employee_Details)
		select @NewEmpno = (count(Empno)) + 1 from Employee_Details
		-- Inserting details into Employee_Details
		insert into Employee_Details 
		values (@NewEmpno, @EmpName, @Empsal, @Emptype);
	end

execute AddEmployee 'vikash',26000.00,'P'--for adding an emp
execute AddEmployee 'avinash',24000,'C'--checking whether check contraint for salary >=25000
execute AddEmployee 'satyam',29000,'Y'--checking whether check contraint for EmpType is 'P' or 'C'
select * from Employee_Details
execute AddEmployee 'Ramiya',27000,'C'