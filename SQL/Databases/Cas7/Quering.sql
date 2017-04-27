USE CompanyDB
GO

--DECLARE
DECLARE @d1 DATE, @t1 TIME, @dt1 DATETIME;
SET @d1 = GETDATE();
SET @t1 = GETDATE();
SET @dt1 = GETDATE();

--CONVERT
SELECT @dt1 AS [datetime],
	CONVERT(DATE, @dt1) AS [datetime as date],
	CONVERT(TIME, @dt1) AS [datetime as time];

--CAST from one type to another
SELECT @d1 AS [date],
	CAST (@d1 AS DATETIME) AS [date as datetime];

SELECT @dt1 AS [datetime],
	CAST(@dt1 AS DATE) AS [datetime as date],
	CAST(@dt1 AS TIME) AS [datetime as time];

SELECT
	CAST(10.6496 AS INT) AS trunc1, --Zaokruzuva na pomaloto
	CAST(-10.6496 AS INT) AS trunc2, --Zaokruzuva na pomaloto
	CAST(10.6496 AS NUMERIC(18, 2)) AS round1, --Zaokruzuva na pogolemoto
	CAST(-10.6496 AS NUMERIC(38, 3)) AS round2; --Zaokruzuva na pogolemoto

--ISNULL

DECLARE @balance DECIMAL(18, 2)
SET @balance = NULL;
SELECT @balance [Balance NULL],
ISNULL(@balance, NULL) [Balance replaced]
GO

DECLARE @balance NVARCHAR (18)
SET @balance = NULL;
SELECT @balance [Balance Null],
ISNULL(@balance, 'string') [Balance replaced]
GO -- Can replace with string

/*
Msg 8114, level 16, State 5, Line 45 */
SELECT OrderDate, RequiredDate, ShippedDate FROM Orders
WHERE ShippedDate IS NULL
SELECT OrderDate, RequiredDate, ISNULL(ShippedDate, RequiredDate) ShippedDate
FROM Orders

--EXISTS
-- Find all employees that have realized orders

SELECT * FROM Employees e
WHERE
	EXISTS(SELECT * FROM Orders o
		WHERE o.EmployeeID = e.EmployeeID)
GO

-- Find all employees that have NOT realized orders
SELECT * FROM Employees e
WHERE
	NOT EXISTS(SELECT * FROM Orders o
		WHERE o.EmployeeID = e.EmployeeID)
GO

--EXISTS replaced with IN
--Find all employees that have realized orders
SELECT * FROM Employees e
WHERE e.EmployeeID IN (SELECT o.EmployeeID FROM Orders o)

--Find all employees that have NOT realized orders
SELECT * FROM Employees e
WHERE e.EmployeeID NOT IN (SELECT o.EmployeeID FROM Orders o)

--UNION AND UNION ALL
/* Create First Table */
CREATE TABLE #Table1(ColDetail VARCHAR(10))
INSERT INTO #Table1
SELECT 'First' UNION ALL
SELECT 'Second' UNION ALL
SELECT 'Third' UNION ALL
SELECT 'Fourth' UNION ALL
SELECT 'Fifth'

SELECT * FROM #Table1
GO

/* Create Second Table */
CREATE TABLE #Table2(ColDetail VARCHAR(10))
INSERT INTO #Table2
SELECT 'First' UNION ALL
SELECT 'Third' UNION ALL
SELECT 'Fifth'

SELECT * FROM #Table1
SELECT * FROM #Table2
GO

/* UNION ALL */
SELECT * FROM #Table1
UNION ALL
SELECT * FROM #Table2
/* UNION */
SELECT * FROM #Table1
UNION
SELECT * FROM #Table2

--DISTINCT
SELECT EmployeeID FROM Orders
ORDER BY EmployeeID
GO
SELECT DISTINCT EmployeeID
FROM Orders
ORDER BY EmployeeID
GO

--LEN, LEFT, RIGHT
DECLARE @myString NVARCHAR(100)
SET @myString = 'This is a simple sentence.'

SELECT LEN(@myString) [String length],
LEFT(@myString, 4) [First 4 chars],
RIGHT(@myString, 9) [Last 9 chars]

SELECT LEN(@myString) [String length],
LEN(LEFT(@myString, 4)) [First 4 chars],
LEN(RIGHT(@myString, 9)) [Last 9 chars]
GO

--SUBSTRING + CONCATENATION
SELECT FirstName, LastName,
SUBSTRING(FirstName, 1, 1) + '.' AS Initial,
FirstName + ' ' + SUBSTRING(FirstName, 1, 1) + '. ' + LastName 
AS [Full Name] 
FROM Employees
WHERE LastName LIKE '%an'
ORDER BY LastName
GO

--REPLACE
--REPLACE (string_expression, string_pattern, string_replacement)
SELECT
	REPLACE('I do not study the database lessons.', 'not ', '');
--Output
--I do study the database lessons.

--If you really do study the database lessons, then you'd do the following
SELECT
	REPLACE(REPLACE('I do not study the database lessons.', 'not ', ''), '.','!');
--Output
--I do study the database lessons!

--Some extra system functions
SELECT @@VERSION
SELECT @@SERVERNAME
SELECT @@SERVICENAME
SELECT @@TRANCOUNT
USE CompanyDB
--1.
SELECT CategoryID, CategoryName, Description FROM Categories

--2.
SELECT OrderDate, RequiredDate, ShippedDate FROM orders
WHERE ShippedDate IS NULL

--3.
SELECT e.* FROM Employees e
WHERE
	NOT EXISTS(SELECT o.* FROM Orders o
		WHERE e.EmployeeID = o.EmployeeID)

--4.
SELECT r.RegionDescription, COUNT(*) FROM Territories t
	JOIN Region r ON t.RegionID = r.RegionID
GROUP BY r.RegionDescription

--5.
SELECT OrderID, SUM(UnitPrice * Quantity) AS SummedOrdersSubtotal FROM [Order Details]
GROUP BY OrderID

--6.
SELECT c.ContactName AS Customer, e.FirstName + ' ' + e.LastName AS Seller FROM Orders o
	JOIN Employees e ON e.EmployeeID = o.EmployeeID
		JOIN Customers c ON c.CustomerID = o.CustomerID
WHERE e.City = o.ShipCity
GO

--7.
SELECT e.EmployeeID, COUNT(o.CustomerID) AS [Number of Customers] FROM Orders o
	JOIN Employees e ON e.EmployeeID = o.EmployeeID
GROUP BY e.EmployeeID
HAVING COUNT(o.CustomerID) > 50
GO

--8.
SELECT MONTH(OrderDate) AS [Month], YEAR(OrderDate) AS [Year], COUNT(*) AS [Number of orders] FROM Orders
GROUP BY YEAR(OrderDate), MONTH(OrderDate)
ORDER BY YEAR(OrderDate), MONTH(OrderDate)
GO