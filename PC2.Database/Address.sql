CREATE TABLE [dbo].[Address]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Number] VARCHAR(50) NOT NULL, 
    [Street] VARCHAR(50) NOT NULL, 
    [PublicPlace] VARCHAR(50) NOT NULL, 
    [City] VARCHAR(50) NOT NULL, 
    [State] VARCHAR(50) NOT NULL, 
    [ZipCode] VARCHAR(50) NOT NULL, 
    [Complement] VARCHAR(50) NULL, 
    [CreateAt] DATETIME NOT NULL
)
