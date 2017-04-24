CREATE PROCEDURE [dbo].sp_CheckUserNameAndPassword
	@username NVARCHAR(15),
	@password NVARCHAR(8)
AS
	SELECT dbo.SECURITY.UserID, dbo.SECURITY.Password FROM dbo.SECURITY WHERE dbo.SECURITY.UserID = @username AND dbo.SECURITY.Password = @password
RETURN 0