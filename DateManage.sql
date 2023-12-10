-- Table Books
CREATE TABLE Books (
    ISBN TEXT PRIMARY KEY,
    Title TEXT NOT NULL,
    AuthorId INTEGER,
    PublicationYear INTEGER,
    Genre TEXT,
    FOREIGN KEY (AuthorId) REFERENCES Authors(AuthorId)
);

-- Table Authors
CREATE TABLE Authors (
    AuthorId INTEGER PRIMARY KEY,
    FirstName TEXT NOT NULL,
    LastName TEXT NOT NULL,
    DateOfBirth TEXT
);

-- Table Borrowings
CREATE TABLE Borrowings (
    BorrowingId INTEGER PRIMARY KEY,
    ISBN TEXT,
    BorrowDate TEXT,
    ExpectedReturnDate TEXT,
    Status TEXT,
    FOREIGN KEY (ISBN) REFERENCES Books(ISBN)
);
