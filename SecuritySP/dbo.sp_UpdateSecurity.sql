CREATE PROCEDURE [dbo].sp_UpdateSecurity
	@PID int,
	@username nvarchar(15),
	@password nvarchar(8),
	@secrole nvarchar(10)
AS
	UPDATE SECURITY SET 
	SECURITY.PID = @PID, 
	SECURITY.UserID = @username,
	SECURITY.Password = @password, 
	SECURITY.SecRole = @secrole
	where Security.PID = @PID
RETURN 0