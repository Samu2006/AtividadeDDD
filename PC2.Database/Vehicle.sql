CREATE TABLE [dbo].[Vehicle]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Version] VARCHAR(50) NOT NULL, 
    [Year] INT NOT NULL, 
    [YearFabrication] INT NOT NULL, 
    [Color] VARCHAR(50) NOT NULL, 
    [Renavan] VARCHAR(50) NOT NULL, 
    [Brand] VARCHAR(50) NULL, 
    [CreateAt] DATETIME NOT NULL, 
	[ModelId] UNIQUEIDENTIFIER NOT NULL, 

    CONSTRAINT [FK_Vehicle_Model] FOREIGN KEY ([ModelId]) REFERENCES [Model]([Id])
)
