CREATE PROCEDURE [dbo].sp_UpdateSecurity
	@PID int,
	@username nvarchar(15),
	@password nvarchar(8),
	@secrole nvarchar(10)
AS
	UPDATE dbo.SECURITY
	SET 
	dbo.SECURITY.PID = @PID,
	dbo.SECURITY.UserID = @username,
	dbo.SECURITY.Password = @password,
	dbo.SECURITY.SecRole = @secrole
	WHERE PID = @PID
RETURN 0