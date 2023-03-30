-- Create the LoanedBooks table
CREATE TABLE LoanedBooks
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    BookId INT NOT NULL,
    CustomerId INT NOT NULL,
    LoanDate DATE NOT NULL,
    DueDate DATE NOT NULL,
    ReturnDate DATE,
    FOREIGN KEY(BookId) REFERENCES Books (Id),
    FOREIGN KEY(CustomerId) REFERENCES Customers(Id)
);