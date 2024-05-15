CREATE PROCEDURE [dbo].[Create]
	@Name NVARCHAR(255),
	@Username NVARCHAR(255),
	@Password NVARCHAR(255)
AS
BEGIN 
INSERT INTO [dbo].[Account]
([Name],[Username],[Password])
VALUES
(@Name,@Username,@Password)
END
