USE CompanyDB

;WITH cte AS
(
	SELECT c.CustomerID, c.CompanyName, c.ContactName
	FROM dbo.Customers c
)

SELECT COUNT(*) FROM cte
GO


;WITH cte_my_orders AS
(
	SELECT o.CustomerID, COUNT(*) [Count Orders]
	FROM [Order Details] od
		INNER JOIN Orders o ON o.OrderID = od.OrderID
	GROUP BY o.CustomerID
)

SELECT MAX([Count Orders]) AS [Max Orders] FROM cte_my_orders
GO

CREATE VIEW DescriptionView 
AS
	SELECT p.ProductName, c.CategoryName, s.CompanyName FROM Products p
		JOIN Categories c ON p.CategoryID = c.CategoryID
			JOIN Suppliers s ON p.SupplierID = s.SupplierID
GO
SELECT * FROM DescriptionView
GO

CREATE FUNCTION dbo.CountTerritoriesByRegion (@region NVARCHAR(30))
RETURNS INT
AS
BEGIN
	DECLARE @counter INT
	SELECT @counter = COUNT(*) FROM Territories t
		JOIN Region r ON t.RegionID = r.RegionID
	WHERE @region = r.RegionDescription
	RETURN @counter
END
SELECT dbo.CountTerritoriesByRegion('Eastern')
GO

CREATE FUNCTION dbo.OrdersByCustomer(@customer NVARCHAR(30))
RETURNS INT
AS 
BEGIN
	DECLARE @counter INT
	SELECT @counter = COUNT(*) FROM Orders o
		JOIN Customers c ON c.CustomerID = o.CustomerID
	WHERE @customer = c.ContactName
	RETURN @counter
END
SELECT dbo.OrdersByCustomer('Maria Anders')
GO



ALTER FUNCTION dbo.MostLoyalCustomer21()
RETURNS NVARCHAR(30)
AS 
BEGIN
	DECLARE @customerName NVARCHAR(30)
	;WITH cte_orders_by_customer AS
(
	SELECT TOP 1 c.CustomerID, c.ContactName, COUNT(OrderID) AS [Number Of Orders] FROM Customers c
		JOIN Orders o ON o.CustomerID = c.CustomerID
	GROUP BY c.CustomerID, c.ContactName
	ORDER BY [Number Of Orders] DESC
)			
	SELECT @customerName = (SELECT ContactName FROM cte_orders_by_customer)
	RETURN @customerName
END

SELECT dbo.MostLoyalCustomer21()
GO

--IF/ELSE and CASE

DECLARE @bool BIT
SET @bool = 0
IF @bool = 1
	PRINT 'The @bool has TRUE'
ELSE
	PRINT 'The @bool has FALSE'
GO

SELECT
	RegionID,
	RegionDescription, 
CASE
	RegionID
		WHEN 1 THEN 'One'
		WHEN 2 THEN 'Two'
		WHEN 3 THEN 'Three'
		WHEN 4 THEN 'Four'
	ELSE 'No region'
END AS [Region Abbrevation]
FROM dbo.Region

DECLARE @date DATE = GETDATE();
DECLARE @isLeap int = 0;
IF(YEAR(@date) % 400 = 0
	OR (YEAR(@date) % 4 = 0
		AND YEAR(@date) % 100 <> 0))
	SET @isLeap = 1
SELECT @isLeap AS [Is Leap Year]

DECLARE @month INT = MONTH(GETDATE());
DECLARE @days INT;

SELECT @days = CASE
	WHEN @month = 1 THEN 31
	WHEN @month = 2 THEN 28 + @isLeap
	WHEN @month = 3 THEN 31
	WHEN @month = 4 THEN 30
	WHEN @month = 5 THEN 31
	WHEN @month = 6 THEN 30
	WHEN @month = 7 THEN 31
	WHEN @month = 8 THEN 31
	WHEN @month = 9 THEN 30
	WHEN @month = 10 THEN 31
	WHEN @month = 11 THEN 30
	WHEN @month = 12 THEN 31
END

SELECT @days [Days in current month]

DECLARE @date DATE = '2016-2-1'
SELECT
	CASE
		WHEN MONTH(@date) IN (1, 3, 5, 7, 8, 10, 12) THEN 31
		WHEN MONTH(@date) IN (4, 6, 9, 11) THEN 30
	ELSE
		CASE
			WHEN (YEAR(@date) % 400 = 0
				OR (YEAR(@date) % 4 = 0
					AND YEAR(@date) % 100 <> 0)) 
			THEN 29
		ELSE 28
		END
	END AS [Current month's days]

--CREATE PROCEDURE spGetOrdersByDate
--	@dateType INT,
--	@dateFrom DATE,
--	@dateTo DATE
--AS
--SELECT 
--CASE
--	@dateType
--		WHEN 1 THEN	(
--			SELECT * FROM Orders
--			WHERE OrderDate BETWEEN @dateFrom AND @dateTo
--		)
--		WHEN 2 THEN (
--			SELECT * FROM Orders
--			WHERE RequiredDate BETWEEN @dateFrom AND @dateTo
--		)
--		WHEN 3 THEN (
--			SELECT * FROM Orders
--			WHERE ShippedDate BETWEEN @dateFrom AND @dateTo
--		)
--END
ALTER PROCEDURE spGetOrdersByDate
	@dateType INT,
	@dateFrom DATE,
	@dateTo DATE
AS
IF @dateType = 1 (
			SELECT * FROM Orders
			WHERE OrderDate BETWEEN @dateFrom AND @dateTo
			
		)ORDER BY OrderDate DESC
IF @dateType = 2 (
			SELECT * FROM Orders
			WHERE RequiredDate BETWEEN @dateFrom AND @dateTo

		)ORDER BY RequiredDate DESC
IF @dateType = 3 (
			SELECT * FROM Orders
			WHERE ShippedDate BETWEEN @dateFrom AND @dateTo
		)ORDER BY ShippedDate DESC


EXEC spGetOrdersByDate 1, '1996-04-1', '1996-8-1'


SELECT
	CustomerID,
	CompanyName,
	City,
	Country,
CASE
	WHEN Country IN ('Germany', 'UK', 'Sweden', 'France', 'Spain', 
					'Switzerland', 'Austria', 'Italy', 'Portugal', 
					'Ireland', 'Belgium', 'Norway', 'Denmark', 'Finland', 'Poland') THEN 'Europe'
	WHEN Country IN ('Mexico') THEN 'Central America'
	WHEN Country IN ('Canada', 'USA') THEN 'North America'
	WHEN Country IN ('Brazil', 'Argentina', 'Venezuela') THEN 'South America'
END AS Continent
FROM Customers

CREATE PROCEDURE usp_ExampleProc
AS
	SELECT * FROM NonexistentTable;
GO

BEGIN TRY
	EXECUTE usp_ExampleProc;
END TRY
BEGIN CATCH
	SELECT
		ERROR_NUMBER() AS ErrorNumber,
		ERROR_MESSAGE() AS ErrorMessage;
END CATCH

CREATE FUNCTION dbo.CountOrdersByDateType(@dateType INT, @dateFrom DATE, @dateTo DATE)
RETURNS INT
AS
BEGIN
	DECLARE @counter INT;
	IF @dateType = 1 SELECT @counter = (
			SELECT COUNT(*) FROM Orders
			WHERE OrderDate BETWEEN @dateFrom AND @dateTo			
		)
	IF @dateType = 2 SELECT @counter = (
				SELECT COUNT(*) FROM Orders
				WHERE RequiredDate BETWEEN @dateFrom AND @dateTo

		)
	IF @dateType = 3 SELECT @counter = (
				SELECT COUNT(*) FROM Orders
				WHERE ShippedDate BETWEEN @dateFrom AND @dateTo
		)
	RETURN @counter
END
GO
SELECT dbo.CountOrdersByDateType(3, '1996-7-1', '1996-10-1')
GO
	