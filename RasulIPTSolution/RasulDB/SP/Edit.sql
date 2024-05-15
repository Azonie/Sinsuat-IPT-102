CREATE PROCEDURE [dbo].[Edit]
	@Id int ,
	@Name NVARCHAR(255),
	@Username NVARCHAR(255),
	@Password NVARCHAR(255)
AS
BEGIN
UPDATE [dbo].[Account]
SET 
[Name] = @Name,
[Username] = @Username,
[Password] = @Password
WHERE [Id] = @Id


END