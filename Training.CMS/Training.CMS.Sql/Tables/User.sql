CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,  
    [UserName] NVARCHAR(50) NULL, 
    [Password] NVARCHAR(50) NULL, 
    [EmailAddress] NVARCHAR(100) NULL, 
    [Country] NVARCHAR(50) NULL, 
    [Region] NVARCHAR(50) NULL
)
