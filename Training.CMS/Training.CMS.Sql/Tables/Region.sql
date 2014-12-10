CREATE TABLE [dbo].[Region]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CountryId] INT NOT NULL, 
    [RegionName] NVARCHAR(50) NOT NULL
)
