CREATE TABLE [dbo].[tblteacher]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [email] NVARCHAR(50) NULL, 
    [username] NVARCHAR(50) NULL, 
    [password] NVARCHAR(50) NULL
)
