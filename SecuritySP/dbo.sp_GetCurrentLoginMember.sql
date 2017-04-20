CREATE PROCEDURE [dbo].sp_GetCurrentLoginMember
	@username nvarchar(15)
AS
	SELECT * FROM SECURITY WHERE SECURITY.UserID = @username
RETURN 0