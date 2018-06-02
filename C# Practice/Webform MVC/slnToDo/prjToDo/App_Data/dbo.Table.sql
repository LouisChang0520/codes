CREATE TABLE [dbo].[tToDo]
(
	[fId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [fTitle] NVARCHAR(50) NULL, 
    [fImage] NVARCHAR(50) NULL, 
    [fDate] DATE NULL
)
