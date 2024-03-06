BULK INSERT [dbo].[Instructor]
FROM 'pathto\instructors.csv'
WITH (FIRSTROW = 3,
	FIELDTERMINATOR = ',',
	ROWTERMINATOR = '\n')

BULK INSERT [dbo].[Student]
FROM 'pathto\students.csv'
WITH (FIRSTROW = 3,
	FIELDTERMINATOR = ',',
	ROWTERMINATOR = '\n')

BULK INSERT [dbo].[Section]
FROM 'pathto\sections.csv'
WITH (FIRSTROW = 3,
	FIELDTERMINATOR = ',',
	ROWTERMINATOR = '\n')

BULK INSERT [dbo].[Course_Fact_Table]
FROM 'pathto\coursesFact (2).csv'
WITH (FIRSTROW = 3,
	FIELDTERMINATOR = ',',
	ROWTERMINATOR = '\n')

BULK INSERT [dbo].[Course]
FROM 'pathto\courses (2).csv'
WITH (FIRSTROW = 3,
	FIELDTERMINATOR = ',',
	ROWTERMINATOR = '\n')
