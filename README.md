# CRUD-Operations-In-MVC-Using-Dapper
ASP.NET MVC app using Dapper ORM for CRUD operations

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
