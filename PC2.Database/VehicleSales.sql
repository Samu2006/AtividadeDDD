CREATE TABLE [dbo].[VehicleSales]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Note] VARCHAR(50) NOT NULL, 
    [InputPrice] DECIMAL(7, 2) NOT NULL, 
	[InputDate] DATETIME NOT NULL, 
    [LicensePlate] UNIQUEIDENTIFIER NULL, 
    [CreateAt] DATETIME NOT NULL, 
	[VehicleId] UNIQUEIDENTIFIER NOT NULL, 
	[BuyerId] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [FK_VehicleSales_Vehicle] FOREIGN KEY ([VehicleId]) REFERENCES [Vehicle]([Id]), 
    CONSTRAINT [FK_VehicleSales_Buyer] FOREIGN KEY ([BuyerId]) REFERENCES [Buyer]([Id])
)
