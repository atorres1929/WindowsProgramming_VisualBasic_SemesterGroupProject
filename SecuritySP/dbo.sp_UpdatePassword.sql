CREATE PROCEDURE [dbo].sp_UpdatePassword
	@username nvarchar(15),
	@password nvarchar(8),
	@newPassword nvarchar(8)
AS
	Update Security
	set Password = @newPassword
	where UserID = @username and
	Password = @password
RETURN 0