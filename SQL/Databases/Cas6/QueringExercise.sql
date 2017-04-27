USE CompanyDB
GO
SELECT * FROM Customers
WHERE City = 'London'
GO
SELECT * FROM Customers
WHERE Country = 'Germany' AND City IN ('Berlin', 'Leipzig')
GO
SELECT * FROM Customers
WHERE Region IS NOT NULL
GO
SELECT * FROM Customers
WHERE Phone LIKE '(5%'
GO
SELECT * FROM Customers
WHERE Phone = Fax
GO
SELECT * FROM Customers
WHERE ContactTitle LIKE '%Manager'
GO
SELECT * FROM Customers
WHERE ContactTitle NOT LIKE '%Manager%'
GO
SELECT * FROM Customers
WHERE Country = 'UK'
ORDER BY CompanyName ASC
GO
SELECT * FROM Customers
WHERE City = 'Madrid'
ORDER BY CompanyName DESC
GO
SELECT * FROM Customers
WHERE ContactTitle LIKE '%Sales Representative%'
GO
SELECT * FROM Employees
GO
SELECT * FROM Employees
WHERE REportsTo IS NULL
GO
SELECT * FROM Employees
Where TitleOfCourtesy IN ('Mrs.', 'Mr.', 'Dr.')
GO
SELECT * FROM Categories
GO
SElECT * FROM Products
GO
SELECT p.*, c.CategoryName FROM Products AS p
JOIN Categories AS c
ON p.CategoryID = c.CategoryID
WHERE c.CategoryName IN ('Condiments', 'Confections')
GO
SELECT p.ProductName, c.CategoryName FROM
	Products AS p
		JOIN Categories as c
			ON p.CategoryID = c.CategoryID
	WHERE c.CategoryName NOT LIKE '%Meat%' AND c.CategoryName NOT LIKE '%Dairy%'
GO
SELECT * FROM Suppliers
SELECT * FROM Products

SELECT p.ProductName, s.CompanyName FROM
	Products AS p
		JOIN Suppliers AS s
			ON p.SupplierID = s.SupplierID
WHERE s.CompanyName = 'Exotic Liquids'
GO
SELECT p.ProductName, s.CompanyName FROM
	Products AS p
		JOIN Suppliers AS s
			ON p.SupplierID = s.SupplierID
WHERE s.CompanyName = 'Tokyo Traders'
GO
SELECT * FROM Suppliers
SELECT p.ProductName, c.CategoryName FROM
	Products p
		JOIN Categories c
			ON p.CategoryID = c.CategoryID
WHERE c.CategoryName LIKE '%Beverages%' AND p.UnitPrice > 50
GO
SELECT p.ProductName, c.CategoryName, s.Country FROM
	Products p
		JOIN Categories c
			ON p.CategoryID = c.CategoryID
			JOIN Suppliers s
				ON p.SupplierID = s.SupplierID
WHERE c.CategoryName LIKE '%Meat%' AND s.Country LIKE '%Australia%'
GO
SELECT * FROM Products
WHERE QuantityPerUnit LIKE '%bottles%'
GO
SELECT p.*, s.City FROM
	Products p
		JOIN Suppliers s
			ON p.SupplierID = s.SupplierID
WHERE s.City IN ('London', 'Tokyo')
GO
SELECT * FROM Orders
SELECT o.*, s.CompanyName FROM
	Orders o
		JOIN Shippers s
			ON o.ShipVia = s.ShipperID
WHERE s.CompanyName = 'Speedy Express'
GO
SELECT o.*, s.CompanyName FROM
	Orders o
		JOIN Shippers s
			ON o.ShipVia = s.ShipperID
WHERE o.Freight > 30 AND s.CompanyName = 'Federal Shipping' AND ShippedDate BETWEEN '1996-06-01' AND '1997-06-01'
GO
SELECT * FROM Orders
WHERE ShipCity = 'Stuttgart' AND YEAR(ShippedDate) = 1997 AND DATEPART(QUARTER, ShippedDate) < 3
GO
SELECT COUNT(*) FROM Employees

SELECT 
	SUM(Freight) as TotalFreight,
	MIN(Freight) as MinimumFreight,
	MAX(Freight) as MaximumFreight,
	AVG(Freight) as AverageFreight 
FROM Orders

SELECT COUNT(*) AS TotalOrders, SUM(Freight) as TotalFreight, ShipCountry FROM Orders
	 GROUP BY ShipCountry
	 ORDER BY ShipCountry

SELECT * FROM Orders
SELECT * FROM [Order Details]

SELECT 
	p.ProductName,
	AVG(od.Quantity) AS AverageQuantity
FROM [Order Details] od
		JOIN Products p
			ON od.ProductID = p.ProductID
GROUP BY p.ProductName
GO

SELECT OrderID, MIN(Freight) FROM Orders
GROUP BY OrderID
ORDER BY MIN(Freight)
GO

SELECT OrderID, MAX(ShippedDate) AS ShippedDate FROM Orders
	--WHERE ShippedDate IS NOT NULL
	GROUP BY OrderID
	HAVING MAX(ShippedDate) IS NOT NULL
	ORDER BY MAX(ShippedDate)	
GO

SELECT COUNT(*) FROM Orders
WHERE YEAR(OrderDate) = 1996
GO
SELECT * FROM Orders
SELECT COUNT(o.OrderID), e.FirstName FROM
	Orders o
		JOIN
			Employees e
				ON o.EmployeeID = e.EmployeeID
GROUP BY e.FirstName
GO
SELECT COUNT(o.OrderID) AS NumberOfOrders, c.ContactName FROM
	Orders o
		JOIN
			Customers c
				ON o.CustomerID = c.CustomerID
GROUP BY c.ContactName
ORDER BY COUNT(o.OrderID) DESC
GO
SELECT AVG(od.Quantity), p.ProductName FROM
	[Order Details] od
		JOIN Products p
			ON od.ProductID = p.ProductID
GROUP BY p.ProductName
ORDER BY AVG(od.Quantity) DESC
GO
SELECT MIN(OrderDate) FROM Orders
SELECT MAX(OrderDate) FROM Orders
SELECT COUNT(*), ShipCity FROM Orders
GROUP BY ShipCity
ORDER BY COUNT(*) DESC
GO
SELECT COUNT(*), ShipCity FROM Orders
GROUP BY ShipCity
HAVING COUNT(*) > 10
ORDER BY COUNT(*) DESC
GO
