-- Create a new table called '[Clients]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[Clients]', 'U') IS NOT NULL
DROP TABLE [dbo].[Clients]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[Clients]
(
    [Id] INT NOT NULL PRIMARY KEY, -- Primary Key column
    [AccountNumber] NVARCHAR(50) NOT NULL,
    [Name] NVARCHAR(50) NOT NULL,
    [Surname] NVARCHAR(50) NOT NULL,
    [TaxCode] NVARCHAR(50) NOT NULL,
    [LegalAddress] NVARCHAR(255) NOT NULL,
    [ActualAddress] NVARCHAR(255) NOT NULL,
    [ChiefInitials] NVARCHAR(255) NOT NULL,
    [Rating] FLOAT,
    [LastUpdated] DATE NOT NULL default GETDATE()
);
GO



-- Create a new table called '[Credits]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[Credits]', 'U') IS NOT NULL
DROP TABLE [dbo].[Credits]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[Credits]
(
    [Id] INT NOT NULL PRIMARY KEY, -- Primary Key column
    [ClientId] INT NOT NULL,
    [StartDate] DATE NOT NULL,
    [Amount] FLOAT NOT NULL,
    [Duration] INT NOT NULL,
    [AnnualInterestRate] FLOAT NOT NULL,
    [Pledge] NVARCHAR(255) NOT NULL,
    [LastUpdated] DATE NOT NULL default GETDATE(),
    [IsOutdated] BIT NOT NULL,
    FOREIGN KEY(ClientId) REFERENCES Clients(Id)
    ON DELETE CASCADE
    ON UPDATE CASCADE
);
GO

-- Create a new table called '[PaymentSchedule]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[PaymentSchedule]', 'U') IS NOT NULL
DROP TABLE [dbo].[PaymentSchedule]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[PaymentSchedule]
(
    [Id] INT NOT NULL PRIMARY KEY, -- Primary Key column
    [CreditId] INT NOT NULL,
    [PaymentDate] DATE NOT NULL,
    [Amount] FLOAT NOT NULL,
    [InterestRate] FLOAT NOT NULL,
    [IsPaid] BIT NOT NULL,
    [LastUpdated] DATE NOT NULL default GETDATE(),
    FOREIGN KEY(CreditId) REFERENCES Credits(Id)
    ON DELETE CASCADE
    ON UPDATE CASCADE
);
GO