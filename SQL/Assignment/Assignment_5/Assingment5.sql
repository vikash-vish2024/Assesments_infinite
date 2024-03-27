use Assignment

-- Write a T-Sql based procedure to generate complete payslip of a given employee with respect to the following condition

  -- a) HRA as 10% of Salary
   --b) DA as 20% of Salary
   --c) PF as 8% of Salary
   --d) IT as 5% of Salary
   --e) Deductions as sum of PF and IT
   --f) Gross Salary as sum of Salary,HRA,DA
   --g) Net Salary as Gross Salary - Deductions
create or alter proc CalculatePayslip
    @EmployeeID int,
    @Salary float
as
begin
    declare @HRA float
    declare @DA float
    declare @PF float
    declare @IT float
    declare @Deductions float
    declare @GrossSalary float
    declare @NetSalary float

    -- Calculate individual components
    set @HRA = 0.10 * @Salary;
    set @DA = 0.20 * @Salary;
    set @PF = 0.08 * @Salary;
    set @IT = 0.05 * @Salary;

    -- Calculate deductions
    set @Deductions = @PF + @IT;

    -- Calculate gross salary
    set @GrossSalary = @Salary + @HRA + @DA;

    -- Calculate net salary
    set @NetSalary = @GrossSalary - @Deductions;

    --Output
    select @Salary as [Emp-Salary]
    select @HRA as [HRA-Employee]
    select @DA as [DA-Employee]
    select @PF as [PF-Employee]
    select @IT as [IT-Employee]
    select @Deductions as [Deduction-Employee]
    select @GrossSalary as [Gross Salary-Employee]
    select @NetSalary as [Net Salary-Employee]
end

Execute CalculatePayslip 101,25000