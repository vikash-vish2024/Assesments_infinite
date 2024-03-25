use Assignment_2

--Assignment 4

--1.Write a T-SQL Program to find the factorial of a given number.
create or alter proc Factorial(@num int,@fact int output)
as 
begin
set @fact =1
	while(@num>1)
		begin
			set @fact=@fact*@num
			set @num=@num-1
		end 
	--select @fact as 'Factorial'
end
--execution of factorial function
declare @givennum int = 5
declare @fact_out int --output
execute Factorial @givenNum,@fact_out out
print 'Factorial of ' +cast(@givennum as varchar(5))+  ' is: ' +cast(@fact_out as varchar(10))

--2.Create a stored procedure to generate multiplication tables up to a given number.
create or alter proc TablePrint(@num int)
as
	begin
	 while(@num>=1)
		begin
		  declare @temp int=1
		  declare @temp1 int =10
			while(@temp1>=1)
				begin
					print cast(@num as varchar(2)) +'*'+cast(@temp as varchar(2)) +'='+
						cast(@num*@temp as varchar(5))
					set @temp1=@temp1-1
					set @temp=@temp+1
				end
			set @num=@num-1
			print' '
		end
	end
--Execution of table-print 
--table to be printed from 1 to given number
exec TablePrint 3 

--second way
create or alter proc TablePrint1(@num1 int,@num2 int)
as 
begin 
	declare @temp int=1
	while(@num2>=1)
		begin
			print cast(@num1 as varchar(2)) +'*'+cast(@temp as varchar(2)) +'='+
				  cast(@num1*@temp as varchar(5))
			set @temp=@temp+1
			set @num2=@num2-1
		end
	end
--execute table_print1
-- first number is table to be printed second number is until when to be printed
Exec TablePrint1 5,6

--4.Create a trigger to restrict data manipulation on EMP table during General holidays.
--Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manupulate" etc
create  table Holiday
(Holiday_Date date,
Holiday_Name varchar(30))

insert into Holiday values
('2024-01-01','New Year'),
('2024-01-15','Pongal'),
('2024-01-26','Republic Day'),
('2024-03-25','Holi'),
('2024-04-09','Ugadi'),
('2024-05-01','May Day/Maharashtra Day'),
('2024-08-15','Independance Day'),
('2024-08-19','Raksha-Bandhan')

--declare @t date
--set @t=(select Holiday_Date from Holiday where Holiday_Name='holi')
--declare @t1 int
--set @t1= datediff(dd,@t,getdate())
--if(@t1<=0)
--	print'holiday'

create or alter trigger Trg_restrict_changes_onHolidays
on Employees
instead of insert,update,delete
as
	begin
	--for new year 
		declare @date date
		select @date=Holiday_date from Holiday where holiday_name='New Year'
		declare @D_diff int
		set @D_diff= datediff(dd,@date,getdate())
			if(@D_diff<=0)
				raiserror('Today is Holiday for New-Year all changes are restricted',16,1)
			
	--For Pongal 
		declare @date1 date
		select @date1=Holiday_date from Holiday where holiday_name='Pongal'
		declare @D_diff1 int
		set @D_diff1= datediff(dd,@date1,getdate())
			if(@D_diff1<=0)
				raiserror('Today is Holiday for Pongal all changes are restricted',16,1)
			
	--Republic Day
		declare @date2 date
		select @date2=Holiday_date from Holiday where holiday_name='Republic Day'
		declare @D_diff2 int
		set @D_diff2= datediff(dd,@date2,getdate())
			if(@D_diff2<=0)
				raiserror('Today is Holiday for Republic-Day all changes are restricted',16,1)
			

	--Holi
		declare @date3 date
		select @date3=Holiday_date from Holiday where holiday_name='Holi'
		declare @D_diff3 int
		set @D_diff3= datediff(dd,@date3,getdate())
			if(@D_diff3<=0)
				raiserror('Today is Holiday for Holi all changes are restricted',16,1)

	--Ugadi
		declare @date4 date
		select @date4=Holiday_date from Holiday where holiday_name='Ugadi'
		declare @D_diff4 int
		set @D_diff4= datediff(dd,@date4,getdate())
			if(@D_diff4<=0)
				raiserror('Today is Holiday for Ugadi all changes are restricted',16,1)
	--May Day/Maharashtra Day
		declare @date5 date
		select @date5=Holiday_date from Holiday where holiday_name='May Day/Maharashtra Day'
		declare @D_diff5 int
		set @D_diff5= datediff(dd,@date5,getdate())
			if(@D_diff5<=0)
				raiserror('Today is Holiday for May Day/Maharastra Day all changes are restricted',16,1)
	--Independence Day
		declare @date6 date
		select @date6=Holiday_date from Holiday where holiday_name='Independence Day'
		declare @D_diff6 int
		set @D_diff6= datediff(dd,@date6,getdate())
			if(@D_diff6<=0)
				raiserror('Today is Holiday for Independence Day all changes are restricted',16,1)
	--Raksha-Bandhan
		declare @date7 date
		select @date7=Holiday_date from Holiday where holiday_name='Raksha-Bandhan'
		declare @D_diff7 int
		set @D_diff7= datediff(dd,@date7,getdate())
			if(@D_diff7<=0)
				raiserror('Today is Holiday for Raksha-Bandhan Day all changes are restricted',16,1)
		--else
		-- raiserror('Testing',16,1)
		-- rollback
	end

	insert into Employees values(222,null,null,null,null,null,null,null)

	select * from Employees
