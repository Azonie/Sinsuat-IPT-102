CREATE PROCEDURE [dbo].[Find]
@Search NVARCHAR(255)
AS
BEGIN
	IF (SELECT COUNT(*)FROM [dbo].[Account])=0
		BEGIN
			INSERT INTO [dbo].[Account]([Name],[Username],[Password])VALUES('Sinsuat','a','a')
		END

SELECT * FROM [dbo].[Account] WHERE 
[Name]like @Search or
[Username]like @Search or
[Password]like @Search

END