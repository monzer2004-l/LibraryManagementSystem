CREATE TABLE Users
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL
);
Go
-- Create the BookCategories table
CREATE TABLE BookCategories
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
    Description NVARCHAR(MAX) NOT NULL,
);
Go
-- Create the Books table
CREATE TABLE Books
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(255) NOT NULL,
    Author NVARCHAR(255) NOT NULL,
    PublicationDate DATE NOT NULL,
    Price MONEY NOT NULL DEFAULT(0),
    AvailableCopies INT NOT NULL DEFAULT(0),
    ISBN NVARCHAR (255) NULL,
    CategoryId INT NOT NULL,
    FOREIGN KEY (CategoryId) REFERENCES BookCategories (Id)
);

Go
-- Create the Customers table
CREATE TABLE Customers
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) NOT NULL UNIQUE,
    PhoneNumber NVARCHAR(20) NOT NULL
);
Go
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
GO
-- Insert sample data into the Users table
INSERT INTO Users
    (Name, Email, Password)
VALUES
    ('John Doe', 'johndoe@gmail.com', 'password1'),
    ('Jane Smith', 'janesmith@gmail.com', 'password2'),
    ('Bob Johnson', 'bjohnson@yahoo.com', 'password3'),
    ('Emily Davis', 'emilydavis@hotmail.com', 'password4'),
    ('Michael Brown', 'mbrown@gmail.com', 'password5'),
    ('Alicia Rodriguez', 'arodriguez@yahoo.com', 'password6'),
    ('Tom Wilson', 'twilson@gmail.com', 'password7'),
    ('Samantha Lee', 'samanthalee@gmail.com', 'password8'),
    ('David Martin', 'dmartin@yahoo.com', 'password9'),
    ('Julie Chen', 'juliechen@hotmail.com', 'password10')


-- Insert 10 rows into BookCategories table
INSERT INTO BookCategories
    (CategoryName, Description)
VALUES
    ('Fiction', 'Books that are not based on true events'),
    ('Non-fiction', 'Books that are based on true events'),
    ('Science Fiction', 'Books that are based on imagined future scientific or technological advances'),
    ('Mystery', 'Books that involve solving a crime or puzzle'),
    ('Romance', 'Books that focus on romantic relationships'),
    ('Horror', 'Books that aim to create feelings of fear or dread'),
    ('Biography', 'Books that describe the life of a person'),
    ('History', 'Books that describe past events'),
    ('Religion', 'Books that focus on religious beliefs and practices'),
    ('Self-help', 'Books that provide advice and guidance on personal improvement'),
    ('Political Satire', 'Political Satire');

-- Insert 10 rows into Books table
INSERT INTO Books
    (Title, Author, PublicationDate, ISBN, CategoryId, AvailableCopies, Price)
VALUES
    ('The Great Gatsby', 'F. Scott Fitzgerald', '1925-04-10', '978-3-16-148410-0', 8, 5, 9.99),
    ('To Kill a Mockingbird', 'Harper Lee', '1960-07-11', '978-3-16-148420-0', 1, 9, 19.99),
    ('1984', 'George Orwell', '1949-06-08', '978-3-16-148430-0', 3, 6, 9.99),
    ('Pride and Prejudice', 'Jane Austen', '1813-01-28', '978-3-16-148440-0', 6, 0, 8.99),
    ('The Hobbit', 'J.R.R. Tolkien', '1937-09-21', '978-3-16-148450-0', 8, 3, 14.99),
    ('Brave New World', 'Aldous Huxley', '1932-06-14', '978-3-16-148460-0', 3, 7, 24.99),
    ('The Catcher in the Rye', 'J.D. Salinger', '1951-07-16', '978-3-16-148470-0', 1, 2, 29.99),
    ('Animal Farm', 'George Orwell', '1945-08-17', '978-3-16-148480-0', 11, 1, 14.99),
    ('The Lord of the Rings', 'J.R.R. Tolkien', '1954-07-29', '978-3-16-148490-0', 8, 0, 14.99),
    ('One Hundred Years of Solitude', 'Gabriel García Márquez', '1967-05-30', '978-3-16-148500-0', 5, 20, 24.99);


-- Insert 10 rows into Books table
INSERT INTO Customers
    (Name, Email, PhoneNumber)
VALUES
    ('John Doe', 'johndoe@email.com', '123-456-7890'),
    ('Jane Smith', 'janesmith@email.com', '234-567-8901'),
    ('Bob Johnson', 'bjohnson@email.com', '345-678-9012'),
    ('Sara Lee', 'saralee@email.com', '456-789-0123'),
    ('Mike Brown', 'mikebrown@email.com', '567-890-1234'),
    ('Lisa Davis', 'lisadavis@email.com', '678-901-2345'),
    ('Tom Wilson', 'tomwilson@email.com', '789-012-3456'),
    ('Amy Green', 'amygreen@email.com', '890-123-4567'),
    ('Dan Carter', 'dancarter@email.com', '901-234-5678'),
    ('Jill Taylor', 'jilltaylor@email.com', '012-345-6789');
