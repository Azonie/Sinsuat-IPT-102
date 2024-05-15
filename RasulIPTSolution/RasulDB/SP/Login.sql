CREATE PROCEDURE [dbo].[Login]
	@Username NVARCHAR(255),
	@Password NVARCHAR(255)
AS
BEGIN
SELECT * FROM [dbo].[Account]
WHERE 
[Username]like @Username 
and 
[Password] like @Password
END
