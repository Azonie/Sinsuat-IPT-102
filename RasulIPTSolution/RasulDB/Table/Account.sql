CREATE TABLE [dbo].[Account]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(255) NULL Unique,
    [Username] NVARCHAR(255) NULL,
    [Password] NVARCHAR(255) NULL
)
