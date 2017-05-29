USE CompanyDB

INSERT INTO Employees ( LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode,
						Country, HomePhone, Extension, Photo, Notes, ReportsTo, PhotoPath )
VALUES ( N'Iliev', -- LastName - nvarchar(20)
		 N'Kritijan', -- FirstName - nvarcar(10)
		 N'Programmer', -- Title - nvarchar(30)
		 N'Mr.', -- TitleOfCourtesy - nvarchar(25)
		 '1990-06-24', -- BirthDate - datetime
		 GETDATE(), -- HireDate - datetime
		 N'Ljupco Santov 0', -- Address - nvarchar(60)
		 N'Kochani', -- City - nvarchar(15)
		 N'East', -- Region - nvarchar(15)
		 N'2310', -- PostalCode - nvarchar(10)
		 N'Macedonia', -- Country - nvarchar(15)
		 N'033 276 206', -- HomePhone - nvarchar(24)
		 N'033', -- Extension - nvarchar(4)
		 NULL, -- Photo - image
		 N'Graduated programmer at FINKI', -- Notes - ntext
		 2, -- ReportsTo - int
		 NULL -- PhotoPath - nvarchar(255) 
		 )
GO


INSERT INTO Orders ( CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity,
					ShipRegion, ShipPostalCode, ShipCountry )
VALUES ( 'ANATR', 27, '2000-05-04', '2000-06-03', '2000-05-07', 1, 24.38, 'Igor Igeto Mitkovski', 'Ruzveltova 5a-1/22', 'Skopje', 'Karpos 1', '1000', 'Macedonia' )
GO

INSERT INTO [Order Details] ( OrderID, ProductID, UnitPrice, Quantity, Discount )
VALUES ( 11085, 18, 22, 4, 0 )
GO

SELECT * FROM Employees

UPDATE Employees
SET 
	FirstName = 'Kristijan',
	Title = 'Senior Developer',
	Address = 'ul. Ljupco Santov 12'
WHERE EmployeeID = 27
GO

UPDATE [Order Details]
SET
	UnitPrice = 19.6,
	Quantity = 10
WHERE OrderID = 10249
GO

UPDATE Products
SET
	QuantityPerUnit = '12 boxes x 20 bags',
	UnitPrice = 20,
	UnitsInStock = 60
WHERE ProductID = 1
GO

SELECT * FROM Employees

DELETE FROM Employees
WHERE EmployeeID = 23

CREATE PROC spInsertTerritory
(
	@T_ID nvarchar(20),
	@T_Desc nchar(50),
	@R_ID int
)
AS
INSERT INTO
	Territories ( TerritoryID, TerritoryDescription, RegionID )
VALUES
	( @T_ID, @T_Desc, @R_ID )
GO

EXEC spInsertTerritory '66564', 'Testing Stored Procedure', 2
SELECT * FROM Territories

CREATE PROC spUpdateTerritory
(
	@T_ID nvarchar(20)
)
AS
UPDATE Territories
	SET TerritoryDescription = 'New Territory'
WHERE TerritoryID = @T_ID
GO

EXEC spUpdateTerritory '66564'

CREATE PROC spDeleteTerritory
(
	@T_ID nvarchar(20)
)
AS
DELETE FROM Territories
WHERE TerritoryID = @T_ID
GO

EXEC spDeleteTerritory '66564'

CREATE PROC spInsertSupplier
(
	@CompanyName nvarchar(40),
	@ContactName nvarchar(30),
	@ContactTitle nvarchar(30),
	@Address nvarchar(60),
	@City nvarchar(15),
	@Region nvarchar(15),
	@PostalCode nvarchar(10),
	@Country nvarchar(15),
	@Phone nvarchar(24),
	@Fax nvarchar(24),
	@HomePage ntext
)
AS
INSERT INTO 
	Suppliers ( CompanyName, ContactName, ContactTitle, [Address], City, Region, PostalCode, Country, Phone, Fax, HomePage )
VALUES
	( @CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax, @HomePage )
GO

CREATE PROC spUpdateSuppliers
(
	@SupplierID INT,
	@ContactName nvarchar(30),
	@ContactTitle nvarchar(30)
)
AS
UPDATE Suppliers
	SET 
		ContactName = @ContactName,
		ContactTitle = @ContactTitle
	WHERE SupplierID = @SupplierID
GO

CREATE PROC spDeleteSuppliers
(
	@SupplierID INT
)
AS
DELETE FROM Suppliers
WHERE SupplierID = @SupplierID
GO

EXEC spInsertSupplier 'TestCompany', 'TestContact', 'TestContactTitle', 'TestAddress', 'TestCity', 'TestRegion', 'TestPostal', 'TestCountry',
						'TestPhone', 'TestFax', NULL

						
EXEC spUpdateSuppliers 30, 'MyNewCompany', 'MyFuckingName'

EXEC spDeleteSuppliers 30

SELECT * FROM Suppliers

