-- 1. Case 1
SELECT o.OrderID, s.CompanyName FROM Orders o
	JOIN Shippers s
		ON o.ShipVia = s.ShipperID
WHERE ShipCity = 'Rio de Janeiro' AND ShipAddress = '59 rue de l"Abbaye'
GO
-- 1. Case 2
SELECT o.OrderID, s.CompanyName FROM Orders o
	JOIN Shippers s
		ON o.ShipVia = s.ShipperID
WHERE ShipCity LIKE '%Rio de Janeiro%' OR ShipAddress LIKE '%59 rue de l"Abbaye%'
GO
-- 2.
SELECT 
	MONTH(OrderDate) AS OrderMonth, YEAR(OrderDate) AS OrderYear, COUNT(*) AS NumberOfOrders 
FROM Orders
	GROUP BY MONTH(OrderDate), YEAR(OrderDate)
	ORDER BY YEAR(OrderDate) ASC, MONTH (OrderDate) ASC
GO
-- 3.
SELECT
	c.CategoryName AS Category,
	MIN(p.UnitPrice) AS [Minimal price of existing product],
	AVG(p.UnitPrice) AS [Average price of existing product],
	MAX(p.UnitPrice) AS [Maximal price of existing product]
FROM Products p 
	JOIN Categories c ON c.CategoryID = p.CategoryID
	GROUP BY c.CategoryName
	ORDER BY MAX(p.UnitPrice) ASC
GO
-- 4.
--USE CompanyDB
--IF OBJECT_ID('tempdb..#DiscountedProducts') IS NOT NULL	
--DROP TABLE #DiscountedProducts
--CREATE TABLE #DiscountedProducts (
--	ProductID INT,
--	DiscountedPrice INT
--)
--GO
--INSERT INTO #DiscountedProducts
--	SELECT ProductID, UnitPrice FROM Products
--GO
--SELECT * FROM #DiscountedProducts

--SELECT p.ProductName, p.UnitPrice, dp.DiscountedPrice FROM Products p
--	JOIN #DiscountedProducts dp ON p.ProductID = dp.ProductID
--CASE 
--	WHEN dp.DiscountedPrice > 100
--		THEN dp.DiscountedPrice = dp.DiscountedPrice - dp.DiscountedPrice / 10
--	END AS dp.DiscountedPrice

SELECT 
	ProductName, UnitPrice, 
	IIF (UnitPrice > 100, UnitPrice - UnitPrice / 10, UnitPrice) 
		AS DiscountedPrice 
FROM 
	Products
ORDER BY UnitPrice DESC
GO
-- 5.
SELECT e.FirstName, e.LastName, COUNT(o.OrderID) AS NumberOfOrders FROM Orders o
	JOIN Employees e ON e.EmployeeID = o.EmployeeID
GROUP BY e.LastName, e.FirstName
ORDER BY NumberOfOrders DESC
GO
-- 6.
SELECT ContactName, City FROM Customers
WHERE City LIKE 'S%' AND CHARINDEX('t', City, 5) = 5
GO
-- 7.
SELECT TOP (1)
	e.EmployeeID, 
	e.FirstName, 
	e.LastName, 
	MAX(od.UnitPrice * od.Quantity * od.Discount) AS MostIncome 
FROM Orders o
	JOIN Employees e ON o.EmployeeID = e.EmployeeID
		JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY e.EmployeeID, e.FirstName, e.LastName
ORDER BY MostIncome DESC
GO
-- 8.
SELECT e.*, o.EmployeeID FROM Employees e
	LEFT JOIN Orders o ON e.EmployeeID = o.EmployeeID
WHERE o.EmployeeID IS NULL
GO
-- 9.
SELECT c.ContactName, e.FirstName, e.LastName FROM Orders o
	JOIN Customers c ON o.CustomerID = c.CustomerID
		JOIN Employees e ON e.EmployeeID = o.EmployeeID
WHERE e.City = o.ShipCity
GO
-- 10.
SELECT EmployeeID, COUNT(CustomerID) AS Customers FROM Orders
GROUP BY EmployeeID
HAVING COUNT(CustomerID) > 50
GO
	