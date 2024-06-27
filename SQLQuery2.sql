
CREATE DATABASE Kitabxana;


USE Kitabxana;


CREATE TABLE Authors (
    Id INT PRIMARY KEY,
    Name NVARCHAR(100),
    Surname NVARCHAR(100)
)


INSERT INTO Authors (Id, Name, Surname) VALUES
(1, 'Ali', 'Mmemedov'),
(2, 'Huseyn', 'Mkidr'),
(3, 'Ilham', 'Slaqbaun');


CREATE TABLE Books (
    Id INT PRIMARY KEY,
    Name NVARCHAR(100),
    AuthorId INT,
    PageCount INT,
    CostPrice DECIMAL(10, 2),
    SalePrice DECIMAL(10, 2),
    FOREIGN KEY (AuthorId) REFERENCES Authors(Id)
);


INSERT INTO Books (Id, Name, AuthorId, PageCount, CostPrice, SalePrice) VALUES
(101, 'Harry Potter and the Philosopher''s Stone', 1, 336, 10.50, 19.99),
(102, '1984', 2, 328, 12.75, 24.99),
(103, 'One Hundred Years of Solitude', 3, 417, 11.25, 20.99)


CREATE TABLE Tags (
    Id INT PRIMARY KEY,
    Name NVARCHAR(50)
)

INSERT INTO Tags (Id, Name) VALUES
(1, 'BestSeller'),
(2, 'Featured'),
(3, 'New')


CREATE TABLE BooksTags (
    BookId INT,
    TagId INT,
    PRIMARY KEY (BookId, TagId),
    FOREIGN KEY (BookId) REFERENCES Books(Id),
    FOREIGN KEY (TagId) REFERENCES Tags(Id)
)


INSERT INTO BooksTags (BookId, TagId) VALUES
(101, 1), -- Harry Potter - BestSeller
(101, 2), -- Harry Potter - Featured
(101, 3), -- Harry Potter - New
(102, 2), -- 1984 - Featured
(102, 3), -- 1984 - New
(103, 3); -- One Hundred Years of Solitude - New


CREATE VIEW BookDetails AS
SELECT b.Id AS BookId,
       CONCAT(a.Name, ' ', a.Surname) AS AuthorFullName,
       b.Name AS BookName,
       b.SalePrice AS BookPrice,
       b.PageCount,
       t.Name AS TagName
FROM Books b
INNER JOIN Authors a ON b.AuthorId = a.Id
INNER JOIN BooksTags bt ON b.Id = bt.BookId
INNER JOIN Tags t ON bt.TagId = t.Id

SELECT * FROM BookDetails;