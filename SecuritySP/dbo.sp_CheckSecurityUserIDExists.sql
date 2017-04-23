CREATE PROCEDURE [dbo].sp_CheckSecurityUserIDExists
	@username NVARCHAR(15)
AS
	SELECT dbo.SECURITY.UserID FROM dbo.SECURITY WHERE dbo.SECURITY.UserID = @username
RETURN 0