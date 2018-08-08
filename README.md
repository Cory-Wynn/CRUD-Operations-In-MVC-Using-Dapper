# CRUD-Operations-In-MVC-Using-Dapper
ASP.NET MVC app using Dapper ORM for CRUD operations, implemented with the Repository pattern.

# Setup
Database Schema
```SQL
CREATE TABLE [dbo].[Employee]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY,
	[Name] VARCHAR(50),
	[City] VARCHAR(50),
	[Address] VARCHAR(50)
)
```
Stored Procedures

Insert Employee
```SQL
Create procedure [dbo].[AddNewEmpDetails]  
(  
   @Name varchar (50),  
   @City varchar (50),  
   @Address varchar (50),
   @EmpId INT
)  
as  
begin  
   Insert into [dbo].[Employee] values(@Name,@City,@Address)  
End 
```
View Employee
```SQL
CREATE Procedure [dbo].[GetEmployees]  
as  
begin  
select Id as Empid,Name,City,Address from Employee
End   
```
Update Employee
```SQL
Create procedure [dbo].[UpdateEmpDetails]
(
@EmpId int,
@Name varchar (50),
@City varchar (50),
@Address varchar (50)
)
as
begin
Update Employee
set Name=@Name,
City=@City,
Address=@Address
where Id=@EmpId
End 
```
Delete Employee
```SQL
Create procedure [dbo].[DeleteEmpById]
(
@EmpId int
)
as
begin
Delete from Employee where Id=@EmpId
End 
```
