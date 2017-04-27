--CREATE DATABASE SalesData
--GO

--USE SalesData
--GO

--CREATE TABLE [dbo].[Customers] (
--	[CustomerID] [nchar](5) NOT NULL,
--	[CopanyName] [nvarchar](40) NOT NULL,
--	[ContactName] [nvarchar] (30) NULL,
--	[Address] [nvarchar](60) NULL,
--	[City] [nvarchar](15) NULL,
--	[Region] [nvarchar](15) NULL,
--	[PostalCode] [nvarchar](10) NULL,
--	[Country] [nvarchar](15) NULL,
--	[Phone] [nvarchar](24) NULL
--	CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([CustomerID] ASC)
--)
--GO
--CREATE TABLE [dbo].[Orders] (
--	[OrderID] [int] IDENTITY(1, 1) NOT NULL CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([OrderID] ASC),
--	[CustomerID] [nchar](5) NULL,
--	[EmployeeID] [int] NULL,
--	[OrderDate] [datetime] NULL,
--	[ShippedDate] [datetime] NULL,
--	[ShipVia] [int] NULL,
--	[Freight] [money] NULL CONSTRAINT [DF_Orders_Freight] DEFAULT ((0)),
--	[ShipName] [nvarchar](40) NULL,
--	[ShipAddress] [nvarchar](60) NULL,
--	[ShipCity] [nvarchar](15) NULL,
--	[ShipRegion] [nvarchar](15) NULL,
--	[ShipPostalCode] [nvarchar](10) NULL,
--	[ShipCountry] [nvarchar](15) NULL,
--	 --rule
--)
--GO

--INSERT INTO Orders (CustomerID, EmployeeID, OrderDate, ShippedDate, ShipVia, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry)
--VALUES ('111', 1, NULL, NULL, 2, 'TestShip', 'TestAddress', 'Skopje', 'Skopje', '1000', 'Macedonia')
--GO

--CREATE TABLE [dbo].[Order Details] (
--	OrderID int NOT NULL,
--	ProductID [int] NOT NULL,
--	UnitPrice money NOT NULL CONSTRAINT DF_Order_Details_UnitPrice DEFAULT ((0)),
--	Quantity smallint NOT NULL CONSTRAINT DF_Order_Details_Quantity DEFAULT ((1)),
--	Discount real NOT NULL CONSTRAINT DF_Order_Details_Discount DEFAULT ((0)),
--	CONSTRAINT PK_Order_Details PRIMARY KEY CLUSTERED
--		( OrderID ASC,
--		  ProductID ASC
--		)
--)
--GO

--INSERT INTO [Order Details] (OrderID, ProductID, UnitPrice, Discount)
--VALUES (1, 1, 10, 2)
--GO

--USE MyTestDb
--GO

--INSERT INTO Employee(EmployeeID, FullName, Title, BirthDate, HireDate, Address, City, ReportsTo, Phone, Country)
--SELECT 6 AS EmployeeID, 'Petar Petrov' AS FullName, 'Sales Manager' AS Title, 1963-10-01 AS BirthDate, 2010-07-01 AS HireDate, 'Bul. Kuzma' AS Address, 'Skopje' AS City, 
--null AS ReportsTo, 02310544 AS Phone, 'Macedonia' AS Country
--GO
--INSERT INTO Employee (EmployeeID, FullName, Title, BirthDate, HireDate, Address, City, ReportsTo, Phone, Country)
--VALUES (7, 'Vasil Vasilev', 'Techincal Staff', '1992-05-10', '2011-05-01', 'Todor Aleksandrov 11', 'Stip',null, 032366, 'Macedonia')
--GO

--INSERT INTO Employee (EmployeeID, FullName, Title, BirthDate, HireDate, Address, City, ReportsTo, Phone, Country)
--VALUES (8, 'Elvir Mekic', 'Vice President', '1962-05-10', '2010-05-01', 'st. Young 1145', null, null, 90534343, 'Canada')
--GO

--INSERT INTO Employee (EmployeeID, FullName, Title, BirthDate, HireDate, Address, City, ReportsTo, Phone, Country)
--VALUES (9, 'Jovan Jovanov', 'Sales Representative', '1969-04-12', '2012-12-01', 'Pero Nakov bb', 'Bitola', null, 3535, 'Macedonia')
--GO

--INSERT INTO Employee (EmployeeID, FullName, Title, BirthDate, HireDate, Address, City, ReportsTo, Phone, Country)
--VALUES (10, 'Pero Deformero', 'Inside Man at CIA', '1970-04-03', '2017-12-01', 'Enver Hodza 100', 'Gostivar', 8, 043257, NULL)
--GO

--INSERT INTO Employee (EmployeeID, FullName, Title, BirthDate, HireDate, Address, City, ReportsTo, Phone, Country)
--VALUES (11, 'Igor Igeto Mitkovski', 'Ruler Of The Galaxy', '1988-02-19', '2016-10-17', 'Ruzveltova 3', 'Skopje', null, 666, 'Macedonia')
--GO

--SELECT * FROM Employee
--WHERE Country = 'Macedonia'
--GO
--SELECT * FROM Employee
--WHERE Country != 'Macedonia'

--SELECT * FROM Employee
--WHERE Country IS NULL

--SELECT * FROM Employee
--WHERE City NOT IN ('Skopje', 'Tetovo', 'Bitola')

--SELECT * FROM Employee
--WHERE Title LIKE '%sales%'

--SELECT * FROM Employee
--WHERE Title LIKE '%DEVELOPER'

--SELECT * FROM Employee
--WHERE 1 = 1  --Returns all

--SELECT * FROM Employee
--WHERE YEAR(BirthDate) > 1980

--SELECT * FROM Employee
--WHERE MONTH(BirthDate) != 12

--SELECT * FROM Employee
--WHERE LEN(FullName) <= 10 --checks string length

--SELECT * FROM Employee
--WHERE EmployeeID % 2 = 0

--SELECT * FROM Employee
--WHERE EmployeeID % 2 <> 0

--SELECT EmployeeID, FullName, City, Country FROM Employee
--WHERE EmployeeID % 2 != 0

DECLARE @a bit
	set @a = 0
DECLARE @b bit = 1
DECLARE @c bit
DECLARE @d bit

set @c = @a & @b
set @d = @a | @b

SELECT @a [a], @b [b], @c [a AND b], @d [a OR b]