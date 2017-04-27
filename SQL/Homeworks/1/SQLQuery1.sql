CREATE DATABASE MyTestDb
GO

USE MyTestDb
GO

CREATE TABLE Region(
RegionID int NOT NULL PRIMARY KEY,
RegionDescription nvarchar(100) NOT NULL
)
GO
CREATE TABLE Territories(
TerritoryID int NOT NULL PRIMARY KEY,
TerritoryDescription nvarchar(100) NOT NULL,
RegionID int NOT NULL
)
GO
CREATE TABLE EmployeeTerritories(
EmployeeID int NOT NULL PRIMARY KEY,
FirstName nvarchar(50) NOT NULL,
MiddleName nvarchar(50),
LastName nvarchar(75) NOT NULL,

TerritoryID int NOT NULL
)
GO

INSERT INTO Region(RegionID, RegionDescription)
VALUES(1, 'Skopje')
GO
INSERT INTO Region(RegionID, RegionDescription)
VALUES(2, 'Bitola')
GO
INSERT INTO Region(RegionID, RegionDescription)
VALUES(3, 'Ohrid')
GO
INSERT INTO Territories(TerritoryID, TerritoryDescription, RegionID)
VALUES(1, 'Kisela Voda', 1)
GO
INSERT INTO Territories(TerritoryID, TerritoryDescription, RegionID)
VALUES(2, 'Aerodrom', 1)
GO
INSERT INTO Territories(TerritoryID, TerritoryDescription, RegionID)
VALUES(3, 'Centar', 1)
GO
INSERT INTO Territories(TerritoryID, TerritoryDescription, RegionID)
VALUES(4, 'Genimale', 2)
GO
INSERT INTO Territories(TerritoryID, TerritoryDescription, RegionID)
VALUES(5, 'Simpo', 2)
GO
INSERT INTO Territories(TerritoryID, TerritoryDescription, RegionID)
VALUES(6, 'Karposh', 2)
GO
INSERT INTO Territories(TerritoryID, TerritoryDescription, RegionID)
VALUES(7, 'Varoshani', 3)
GO
INSERT INTO Territories(TerritoryID, TerritoryDescription, RegionID)
VALUES(8, 'Peshtani', 3)
GO
INSERT INTO Territories(TerritoryID, TerritoryDescription, RegionID)
VALUES(9, 'Krani', 3)
GO

