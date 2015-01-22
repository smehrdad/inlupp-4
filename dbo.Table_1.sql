CREATE TABLE [dbo].[Mammal]
(
	[Id_fk] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [species] NVARCHAR(50) NULL, 
    [teeth] INT NULL, 
    [quarantine] INT NULL, 
    CONSTRAINT [FK_Mammal_ToAnimal] FOREIGN KEY ([id_fk]) REFERENCES [Animal]([id]) 
	   
)

GO
