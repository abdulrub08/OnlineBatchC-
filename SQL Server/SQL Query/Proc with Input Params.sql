Alter proc spInsertEmployee
@FirstName varchar(50)='Abdul',
@LastName varchar(50)='Rub',
@Age int=34,
@Salary money=10000.00
As
Begin
Insert into Employee values(@FirstName,@LastName,@Age,@Salary,GETDATE());
Select * from Employee
END

sp_helptext spInsertEmployee

spInsertEmployee 'TEst',35,36,12000
Execute spDemo
exec spDemo

