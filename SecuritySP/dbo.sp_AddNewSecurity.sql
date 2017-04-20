CREATE PROCEDURE [dbo].sp_AddNewSecurity
	@PID int,
	@username nvarchar(15),
	@password nvarchar(8),
	@secrole nvarchar(10)
AS
	Insert INTO SECURITY VALUES (
		@PID,
		@username,
		@password,
		@secrole
	)
RETURN 0