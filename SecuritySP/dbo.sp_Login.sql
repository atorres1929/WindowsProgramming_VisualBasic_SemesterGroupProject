CREATE PROCEDURE [dbo].sp_Login
	@username varchar(15),
	@password varchar(8)
AS
	DECLARE @PID int
	DECLARE @currentTime DateTime = SYSDATETIME()
	If exists(SELECT UserID, Password from SECURITY where UserID=@username and Password=@password)
		Begin
			SELECT @PID = PID from Security where UserID=@username
			INSERT INTO AUDIT (PID, ACCESSTIMESTAMP, SUCCESS)
			Values(
				@PID,
				@currentTime,
				1 
			)
		End
	Else If @username = 'Guest' and @password = 'Guest'
		Begin
			SET @PID = 0000001
			INSERT INTO AUDIT (PID, ACCESSTIMESTAMP, SUCCESS)
			Values(
				@PID,
				@currentTime,
				1 
			) 
		End
	Else
		Begin
			SET @PID = 9999999
			INSERT INTO AUDIT (PID, ACCESSTIMESTAMP, SUCCESS)
			Values(
				@PID,
				@currentTime,
				0
			)
		End
RETURN 0