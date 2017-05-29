USE CompanyDB

CREATE TRIGGER trgAfterDelete ON Region
FOR INSERT
AS
	DECLARE @region nvarchar(50)
	SET @region = (SELECT i.RegionDescription
	FROM inserted i)
	PRINT 'New region was inserted: ' + @region
GO

INSERT INTO Region VALUES (6, 'South-Western');

SELECT * FROM Region

CREATE TRIGGER trgInsteadOfInsert ON dbo.Territories
INSTEAD OF DELETE
AS
	UPDATE Territories SET isActive = 0
		WHERE TerritoryID = (SELECT TerritoryID FROM deleted)
GO

DELETE FROM Territories WHERE TerritoryID = 01581

CREATE NONCLUSTERED INDEX IX_Orders_CustomerID_igeto ON Orders(CustomerID);

CREATE NONCLUSTERED INDEX IX_Orders_EmployeeID_igeto ON Orders(EmployeeID);

CREATE NONCLUSTERED INDEX IX_Orders_ShipVia_igeto ON Orders (ShipVia);

CREATE NONCLUSTERED INDEX IX_Shippers_ShipperID ON Shippers(ShipperID);
CREATE NONCLUSTERED INDEX IX_Shippers_CompanyName ON Shippers(CompanyName);

CREATE NONCLUSTERED INDEX IX_Territories_TerritoryID_igeto ON Territories(TerritoryID);
CREATE NONCLUSTERED INDEX IX_Territories_TerritoryDescription ON Territories(TerritoryDescription);

CREATE TABLE UnstructuredData(
	ID INT PRIMARY KEY,
	XmlData xml,
	JsonData NVARCHAR(max)
)
GO

INSERT INTO dbo.UnstructuredData ( ID, XmlData, JsonData )
VALUES   ( 1, -- ID - int
-- XmlData - nvarchar(max)
           N'<?xml version="1.0"?>
		<Order>
			<Number>SO43659</Number>
			<Date>2011-05-31T00:00:00</Date>
		</Order>
		<AccountNumber>AW29825</AccountNumber>
		<Item>
			<Price>2024.994</Price>
			<Quantity>1</Quantity>
		</Item>
		<Order>
			<Number>SO43661</Number>
			<Date>2011-06-01T00:00:00</Date>
		</Order>
		<AccountNumber>AW73565</AccountNumber>
		<Item>
			<Price>2024.994</Price>
			<Quantity>3</Quantity>
		</Item>
'-- XmlData - nvarchar(max)

,

		   -- JsonData - nvarchar(max)
           N'[  
        {  
          "Order": {  
            "Number":"SO43659",  
            "Date":"2011-05-31T00:00:00"  
          },  
          "AccountNumber":"AW29825",  
          "Item": {  
            "Price":2024.9940,  
            "Quantity":1  
          }  
        },  
        {  
          "Order": {  
            "Number":"SO43661",  
            "Date":"2011-06-01T00:00:00"  
          },  
          "AccountNumber":"AW73565",  
          "Item": {  
            "Price":2024.9940,  
            "Quantity":3  
          }  
       }  
  ]'  -- JsonData - nvarchar(max)
           
)


SELECT * FROM dbo.UnstructuredData

-- 1. Present the average Freight from table Orders, covering only orders shipped to Switzerland

SELECT OrderID, AVG(Freight) AS [Average Freight] FROM Orders
WHERE ShipCountry = 'Switzerland'
GROUP BY OrderID

-- 2. Count number of orders per Country, ordered by the country in descending order

SELECT ShipCountry, COUNT(*) AS [Number Of Orders] FROM Orders
GROUP BY ShipCountry
ORDER BY ShipCountry DESC

-- 3. Show the Employee name and surname as one column, their BirthDate, and the difference in years between their HireDate and BirthDate

SELECT FirstName + ' ' + LastName AS [Full Name], BirthDate, HireDate, DATEDIFF(year, BirthDate, HireDate) AS [Hired At Age] FROM Employees

-- 4. Create a function that will perform task 3 by providing single parameter (EmployeeID)

CREATE FUNCTION dbo.HiredAtDate(@employeeID INT)
RETURNS INT
AS
BEGIN
	DECLARE @age INT;
	SELECT @age = (
		SELECT 
			DATEDIFF(year, BirthDate, HireDate) AS [Hired At Age] 
		FROM Employees
		WHERE EmployeeID = @employeeID
	);
	RETURN @age;
END

SELECT dbo.HiredAtDate(1)

-- 5. Write a stored procedure that will perform selection of employees born before 1950

CREATE PROCEDURE spWorldWarTwoEmployees
AS
SELECT * FROM Employees
WHERE YEAR(BirthDate) < 1950

EXEC spWorldWarTwoEmployees

-- 6. Create a trigger that will prevent deleting an employee, by displaying message to the user 'Ha ha.. you wish!'

CREATE TRIGGER trgInsteadOfDelete ON Employees
INSTEAD OF DELETE
AS
	PRINT 'Ha Ha.. you wish!'
GO

DELETE FROM Employees WHERE EmployeeID = 1