USE BusinessDB;


CREATE TABLE People (
    PersonId INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(25) NOT NULL,
    SecondName NVARCHAR(25),
    ThirdName NVARCHAR(25),
    LastName NVARCHAR(25) NOT NULL,
    Phone NVARCHAR(15),
    Email NVARCHAR(50),
    Gender tinyint DEFAULT 0
);

CREATE TABLE Users (
    UserId INT PRIMARY KEY IDENTITY(1,1),
    PersonId INT NOT NULL FOREIGN KEY REFERENCES People(PersonId),
    Username NVARCHAR(25) NOT NULL UNIQUE,
    Password NVARCHAR(50) NOT NULL,
    IsActive BIT NOT NULL DEFAULT 1
);

CREATE TABLE Accounts (
    AccountId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    PersonId INT FOREIGN KEY REFERENCES People(PersonId),
    Type TINYINT NOT NULL
);

CREATE TABLE SMS_Log (
    SmsLogId INT PRIMARY KEY IDENTITY(1,1),
    AccountId INT NOT NULL FOREIGN KEY REFERENCES Accounts(AccountId),
    Phone NVARCHAR(15) NOT NULL,
    Content NVARCHAR(255) NOT NULL,
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE UnitTypes ( 
    UnitTypeId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50) NOT NULL UNIQUE
);  

CREATE TABLE Items (
    ItemId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    UnitTypeId INT FOREIGN KEY REFERENCES UnitTypes(UnitTypeId),
);

CREATE TABLE Vouchers (
    VoucherId INT PRIMARY KEY IDENTITY(1,1),
    Type TINYINT NOT NULL,
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
    Amount DECIMAL(18,2) NOT NULL,
    AccountId INT NOT NULL FOREIGN KEY REFERENCES Accounts(AccountId),
    Notes NVARCHAR(255)
);

CREATE TABLE Invoices (
    InvoiceId INT PRIMARY KEY IDENTITY(1,1),
    Type TINYINT NOT NULL,
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
    PaymentMethod TINYINT NOT NULL,
    AccountId INT NOT NULL FOREIGN KEY REFERENCES Accounts(AccountId),
    Notes NVARCHAR(255),
    TotalAmount MONEY NOT NULL,
    CreatedBy INT NOT NULL FOREIGN KEY REFERENCES Users(UserId)
);

CREATE TABLE InvoiceDetails (
    InvoiceDetailId INT PRIMARY KEY IDENTITY(1,1),
    InvoiceId INT NOT NULL FOREIGN KEY REFERENCES Invoices(InvoiceId),
    ItemId INT NOT NULL FOREIGN KEY REFERENCES Items(ItemId),
    Quantity INT NOT NULL,
    UnitPrice MONEY NOT NULL,
    UnitType NVARCHAR(100) NOT NULL
);


-- Insert into People first
INSERT INTO People (FirstName, SecondName, ThirdName, LastName, Phone, Gender, Email)
VALUES ('Amjad', NULL, NULL, 'Al-Hakimi', '777123456', 1 , 'amjad@example.com');

-- Capture the generated PersonId
DECLARE @NewPersonId INT = SCOPE_IDENTITY();

-- Insert into Users using the new PersonId
INSERT INTO Users (PersonId, Username, Password, IsActive)
VALUES (@NewPersonId, 'admin', '123456', 1);

