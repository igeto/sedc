/****** Object: Table [dbo].[Employee] Script Date: 4/19/2017 7:42:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Employeee](
[EmployeeID] [int] NOT NULL,
[FullName] [nvarchar](50) NOT NULL,
[Title] [nvarchar](30) NULL,
[BirthDate] [datetime] NOT NULL,
[HireDate] [datetime] NULL,
[Address] [nvarchar](100) NULL,
[City] [nvarchar](25) NULL,
[Phone] [varchar](15) NULL,
[ReportsTo] [int] NULL,
[Country] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Employeee] WITH CHECK ADD CONSTRAINT [CK_Birthdatee] CHECK (([BirthDate]<getdate()))
GO

ALTER TABLE [dbo].[Employeee] CHECK CONSTRAINT [CK_Birthdatee]
GO


USE [MyTestDb]
GO
TRUNCATE TABLE [dbo].[Employeee]
GO
INSERT [dbo].[Employeee] ([EmployeeID], [FullName], [Title], [BirthDate], [HireDate], [Address], [City], [Phone], [ReportsTo], [Country]) 
VALUES (1, N'Igor Micev', N'Database expert', CAST(N'1983-12-09 00:00:00.000' AS DateTime), CAST(N'2007-01-01 00:00:00.000' AS DateTime), N'Dimitar Vlahov 19', NULL, N'078/ 445 - 588', NULL, NULL)
GO
INSERT [dbo].[Employeee] ([EmployeeID], [FullName], [Title], [BirthDate], [HireDate], [Address], [City], [Phone], [ReportsTo], [Country]) 
VALUES (2, N'Dejan Angelov', N'Junior developer', CAST(N'1993-12-09 00:00:00.000' AS DateTime), CAST(N'2016-01-01 00:00:00.000' AS DateTime), N'bul. Partizanski odr. 12', N'Skopje', NULL, 1, N'Macedonia')
GO
INSERT [dbo].[Employeee] ([EmployeeID], [FullName], [Title], [BirthDate], [HireDate], [Address], [City], [Phone], [ReportsTo], [Country]) 
VALUES (3, N'Aleksandar Petrov', N'sales associate', CAST(N'1995-12-09 00:00:00.000' AS DateTime), CAST(N'2016-04-01 00:00:00.000' AS DateTime), N'Roza Luxemburg 10', N'Tetovo', NULL, NULL, N'Macedonia')
GO
INSERT [dbo].[Employeee] ([EmployeeID], [FullName], [Title], [BirthDate], [HireDate], [Address], [City], [Phone], [ReportsTo], [Country]) 
VALUES (4, N'Milan Milanov', N'web developer', CAST(N'1989-12-09 00:00:00.000' AS DateTime), CAST(N'2017-04-01 00:00:00.000' AS DateTime), N'Oslovska 10', N'Veles', N'(1) 458-452', NULL, N'Macedonia')
GO
INSERT [dbo].[Employeee] ([EmployeeID], [FullName], [Title], [BirthDate], [HireDate], [Address], [City], [Phone], [ReportsTo], [Country]) 
VALUES (5, N'Tim Duncan', N'other', CAST(N'1990-12-09 00:00:00.000' AS DateTime), CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'Avn. 5 455', N'NYC', N'(1) 458-452', NULL, N'USA')
GO
INSERT [dbo].[Employeee] ([EmployeeID], [FullName], [Title], [BirthDate], [HireDate], [Address], [City], [Phone], [ReportsTo], [Country]) 
VALUES (6, N'Petar Petrov', N'sales manager', CAST(N'1963-01-10 00:00:00.000' AS DateTime), CAST(N'2010-07-01 00:00:00.000' AS DateTime), N'bul. Kuzman', N'Skopje', N'02 3105 6', NULL, NULL)
GO
INSERT [dbo].[Employeee] ([EmployeeID], [FullName], [Title], [BirthDate], [HireDate], [Address], [City], [Phone], [ReportsTo], [Country]) 
VALUES (7, N'Vasil', N'technical stuff', '1992-05-10', '2011-05-01', N'Todor Aleksandrov 11', N'Stip', 0323666985, NULL, N'Mac')
go
INSERT [dbo].[Employeee] ([EmployeeID], [FullName], [Title], [BirthDate], [HireDate], [Address], [City], [Phone], [ReportsTo], [Country]) 
VALUES (8, N'George Jovanov', N'Vice president', CAST(N'1962-05-10 00:00:00.000' AS DateTime), CAST(N'2010-05-01 00:00:00.000' AS DateTime), N'St. Young 1145', N'Toronto', N'(905) 34 343', NULL, N'Canada')
GO
INSERT [dbo].[Employeee] ([EmployeeID], [FullName], [Title], [BirthDate], [HireDate], [Address], [City], [Phone], [ReportsTo], [Country]) 
VALUES (9, N'Kosta Nakov', N'Sales Representative', CAST(N'1969-04-12 00:00:00.000' AS DateTime), CAST(N'2012-12-01 00:00:00.000' AS DateTime), N'Pero Nakov bb', N'Bitola', N'044 215 ', NULL, NULL)
GO
INSERT [dbo].[Employeee] ([EmployeeID], [FullName], [Title], [BirthDate], [HireDate], [Address], [City], [Phone], [ReportsTo], [Country]) 
VALUES (10, N'Arben Kadriu', N'Inside Sales Coordinator', CAST(N'1970-04-03 00:00:00.000' AS DateTime), CAST(N'2013-12-01 00:00:00.000' AS DateTime), N'Enver Hodza 100', N'Gostivar', N'043 257 ', 8, NULL)
GO

SELECT * FROM Employeee
WHERE YEAR(BirthDate) BETWEEN 1985 AND 1991

SELECT * FROM Employeee
WHERE Country IS NULL

SELECT * FROM Employeee
WHERE Title LIKE '%DEVELOPER%'

SELECT * FROM Employeee
WHERE City = 'Skopje' AND Country = 'Macedonia'

SELECT * FROM Employeee
WHERE YEAR(HireDate) > 2013 AND Country = 'USA'
