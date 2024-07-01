CREATE DATABASE Library;
GO

USE Library;
CREATE TABLE Books (
    Id INT PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    AuthorId INT NOT NULL,
    PageCount INT
);


CREATE TABLE Authors (
    Id INT PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL,
    Surname NVARCHAR(50) NOT NULL
);
USE Library;
GO

CREATE VIEW BooksAuthorsView AS
SELECT 
    b.Id AS BookId,
    b.Name AS BookName,
    b.PageCount,
    CONCAT(a.Name, ' ', a.Surname) AS AuthorFullName
FROM Books b
INNER JOIN Authors a ON b.AuthorId = a.Id;

USE Library;
GO

CREATE PROCEDURE SearchBooksByKeyword
    @SearchKeyword NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        b.Id AS BookId,
        b.Name AS BookName,
        b.PageCount,
        CONCAT(a.Name, ' ', a.Surname) AS AuthorFullName
    FROM Books b
    INNER JOIN Authors a ON b.AuthorId = a.Id
    WHERE 
        b.Name LIKE '%' + @SearchKeyword + '%' OR
        CONCAT(a.Name, ' ', a.Surname) LIKE '%' + @SearchKeyword + '%';
END;
GO

USE Library;
GO

CREATE VIEW AuthorsView AS
SELECT 
    a.Id AS AuthorId,
    CONCAT(a.Name, ' ', a.Surname) AS FullName,
    COUNT(b.Id) AS BooksCount,
    MAX(b.PageCount) AS MaxPageCount
FROM Authors a
LEFT JOIN Books b ON a.Id = b.AuthorId
GROUP BY a.Id, CONCAT(a.Name, ' ', a.Surname);


EXEC SearchBooksByKeyword 'Eli';


SELECT * FROM AuthorsView;