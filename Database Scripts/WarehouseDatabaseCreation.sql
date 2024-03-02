create database CMPT391DataWarehouse



create table Course_Fact_Table (
	CourseID int,
	InstructorID int,
	SectionID int,
	StudentID int,
	Count int,
	PRIMARY KEY (CourseID, InstructorID, SectionID, StudentID)
);



create table Student (
	StudentID int,
	Name nvarchar(32),
	Major nvarchar(32),
	Gender nvarchar(32),
	PRIMARY KEY (StudentID)
);


create table Instructor (
	InstructorID int,
	Name nvarchar(32),
	Faculty nvarchar(32),
	Rank nvarchar(32),
	University nvarchar(32),
	PRIMARY KEY (InstructorID)
);


create table Course (
	CourseID int,
	Name nvarchar(32),
	Department nvarchar(32),
	University nvarchar(32),
	PRIMARY KEY (CourseID)
);


create table Section (
	SectionId int,
	Year int,
	Semester nvarchar(32),
	PRIMARY KEY(SectionID)
);


ALTER TABLE Course_Fact_Table ADD FOREIGN KEY (CourseID) REFERENCES Course(CourseID);
ALTER TABLE Course_Fact_Table ADD FOREIGN KEY (SectionID) REFERENCES Section(SectionID);
ALTER TABLE Course_Fact_Table ADD FOREIGN KEY (InstructorID) REFERENCES Instructor(InstructorID);
ALTER TABLE Course_Fact_Table ADD FOREIGN KEY (StudentID) REFERENCES Student(StudentID);
