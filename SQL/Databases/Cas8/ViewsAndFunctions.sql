USE CompanyDB

SELECT * FROM TestView

CREATE VIEW TestView22
AS
	SELECT 
		FirstName + ' ' + LastName AS FullName,
		Title,
		City,
		Country
	FROM 
		Employees
GO
SELECT * FROM TestView22

CREATE VIEW Top5Subtotals12
AS
	SELECT TOP 5
		o.OrderId,
		o.ShippedDate,
		os.Subtotal
	FROM 
		Orders o
	JOIN
		[Order Subtotals] os ON o.OrderID = os.OrderID
	ORDER BY Subtotal DESC
GO
SELECT * FROM Top5Subtotals12
GO

CREATE PROCEDURE dbo.SalesByYearIgor
	@Beginning_Date DATETIME,
	@Ending_Date DATETIME
AS
SELECT o.ShippedDate, o.OrderID, YEAR(o.ShippedDate) AS [Year]
FROM Orders o
WHERE o.ShippedDate BETWEEN @Beginning_Date AND @Ending_Date

EXEC SalesByYearIgor @Beginning_Date='1996-06-01', @Ending_Date='1997-06-01'

CREATE PROCEDURE OrdersByCity1
	@ShipCity nvarchar(50)
AS
SELECT * FROM Orders
WHERE ShipCity = @ShipCity

EXEC OrdersByCity1 @ShipCity='Lyon'


SELECT * FROM Orders
WHERE ShipCity = 'Lyon'

CREATE FUNCTION dbo.CountOrdersByCity (@City NVARCHAR(30))
RETURNS INT
AS 
BEGIN
	DECLARE @theCount INT = 0;
	SELECT @theCount = (SELECT COUNT(*) FROM dbo.Orders WHERE ShipCity = @City)
	RETURN @theCount
END
GO

SELECT dbo.CountOrdersByCity('Lyon') OrderCounts

CREATE FUNCTION dbo.CountOrdersByDateRange(@beginningDate DATETIME, @endDate DATETIME)
RETURNS INT
AS
BEGIN
	DECLARE @counter INT = 0
	SELECT @counter =  COUNT(*) FROM Orders WHERE ShippedDate BETWEEN @beginningDate AND @endDate
	RETURN @counter
END
GO

SELECT dbo.CountOrdersByDateRange('1997-06-01', '1997-7-01') [Number Of Orders]