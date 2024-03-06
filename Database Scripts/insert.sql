BULK INSERT [dbo].[Instructor]
FROM 'C:\Users\Eric\source\repos\E-Carstensen\CMPT391DataWarehouse\Database Scripts\instructors.csv'
WITH (FIRSTROW = 3,
	FIELDTERMINATOR = ',',
	ROWTERMINATOR = '\n')

BULK INSERT [dbo].[Student]
FROM 'C:\Users\Eric\source\repos\E-Carstensen\CMPT391DataWarehouse\Database Scripts\students.csv'
WITH (FIRSTROW = 3,
	FIELDTERMINATOR = ',',
	ROWTERMINATOR = '\n')

BULK INSERT [dbo].[Section]
FROM 'C:\Users\Eric\source\repos\E-Carstensen\CMPT391DataWarehouse\Database Scripts\sections.csv'
WITH (FIRSTROW = 3,
	FIELDTERMINATOR = ',',
	ROWTERMINATOR = '\n')

BULK INSERT [dbo].[Course_Fact_Table]
FROM 'C:\Users\Eric\source\repos\E-Carstensen\CMPT391DataWarehouse\Database Scripts\courseFact (3).csv'
WITH (FIRSTROW = 3,
	FIELDTERMINATOR = ',',
	ROWTERMINATOR = '\n')

BULK INSERT [dbo].[Course]
FROM 'C:\Users\Eric\source\repos\E-Carstensen\CMPT391DataWarehouse\Database Scripts\courses (2).csv'
WITH (FIRSTROW = 3,
	FIELDTERMINATOR = ',',
	ROWTERMINATOR = '\n')
