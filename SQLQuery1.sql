Create Database School
Use School

CREATE TABLE Groups (
    Id INT PRIMARY KEY,
    Name NVARCHAR(50)
)

CREATE TABLE Teachers (
    Id INT PRIMARY KEY,
    Name NVARCHAR(50),
    FullName NVARCHAR(100),
    Salary DECIMAL(10, 2)
)
CREATE TABLE Students (
    Id INT PRIMARY KEY,
    FullName NVARCHAR(100),
    TeacherId INT FOREIGN KEY REFERENCES Teachers(Id)
)
CREATE TABLE Grade (
    Id INT PRIMARY KEY,
    StudentFullName NVARCHAR(100),
    StudentGroup NVARCHAR(50),
    StudentTeacherFullName NVARCHAR(100),
    Grade INT
)
INSERT INTO Groups (Id, Name)
VALUES (1, 'Group A'),
       (2, 'Group B')

	   INSERT INTO Teachers (Id, Name, FullName, Salary)
VALUES (1, 'Teacher 1', 'akif', 5000.00),
       (2, 'Teacher 2', 'cemile', 4500.00)
	 
	 INSERT INTO Grade (Id, StudentFullName, StudentGroup, StudentTeacherFullName, Grade)
VALUES (1, 'Ali', 'Group A', 'arif', 85),
       (2, 'mosu', 'Group B', 'akif', 78),
       (3, 'Cavid', 'Group A', 'cemile', 92);

	   SELECT g.Id, g.StudentFullName AS StudentFullname, g.StudentGroup AS StudentGroup, g.StudentTeacherFullName AS StudentTeacherFullname, g.Grade
FROM Grade g
ORDER BY g.Id

