
CREATE DATABASE PB201N	
USE PB201N


CREATE TABLE Academies (
    Id INT PRIMARY KEY,
    Name VARCHAR(100) 
);

CREATE TABLE Groups (
    Id INT PRIMARY KEY,
    Name VARCHAR(100), 
    AcademyId INT,
    FOREIGN KEY (AcademyId) REFERENCES Academies(Id)
);
CREATE TABLE Students (
    Id INT PRIMARY KEY,
    Name VARCHAR(100), 
    Surname VARCHAR(100), 
    Age INT,
    Grant DECIMAL(10, 2), 
    GroupId INT,
    FOREIGN KEY (GroupId) REFERENCES Groups(Id)
);



