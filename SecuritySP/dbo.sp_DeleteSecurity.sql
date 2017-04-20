CREATE PROCEDURE [dbo].sp_DeleteSecurity
	@PID int,
	@username nvarchar(15),
	@password nvarchar(8),
	@secrole nvarchar(10)
AS
	DELETE FROM SECURITY
	WHERE SECURITY.PID = @PID AND
	SECURITY.UserID = @username AND
	SECURITY.Password = @password AND
	SECURITY.SecRole = @secrole
RETURN 0