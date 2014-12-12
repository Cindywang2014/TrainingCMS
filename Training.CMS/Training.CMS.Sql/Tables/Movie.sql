CREATE TABLE [dbo].[Movie]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MovieTypeId] INT NOT NULL, 
    [MovieName] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(50) NOT NULL, 
    [Actor] NVARCHAR(50) NOT NULL, 
    [Image] NVARCHAR(50) NOT NULL, 
    [UploadDate] DATETIME NOT NULL, 
    [IsAudit] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_MovieTypeId_MovieType] FOREIGN KEY ([MovieTypeId]) REFERENCES [dbo].[MovieType]([Id]), 
)