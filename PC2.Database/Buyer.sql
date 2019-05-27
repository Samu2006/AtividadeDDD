CREATE TABLE [dbo].[Buyer]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [Birthday] DATETIME NOT NULL, 
    [Gender] TINYINT NOT NULL, 
    [Phone] VARCHAR(50) NOT NULL, 
    [Nationality] VARCHAR(50) NULL, 
    [CPF] VARCHAR(50) NULL, 
    [CreateAt] DATETIME NOT NULL, 
	[AddressId] UNIQUEIDENTIFIER NOT NULL, 

    CONSTRAINT [FK_Buyer_Address] FOREIGN KEY ([AddressId]) REFERENCES [Address]([Id])
)
