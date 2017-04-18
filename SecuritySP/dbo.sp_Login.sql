Create PROCEDURE [dbo].sp_Login
	@username varchar(15),
	@password varchar(8)
AS
	If exists(SELECT UserID, Password from SECURITY where UserID=@username and Password=@password)
		Begin
			INSERT INTO AUDIT (PID, ACCESSTIMESTAMP, SUCCESS)
			Values(
				(Select PID from Security where UserID=@username),
				SYSDATETIME(),
				1 
			)
		End
	Else If @username = 'Guest' and @password = 'Guest'
		Begin
			INSERT INTO AUDIT (PID, ACCESSTIMESTAMP, SUCCESS)
			Values(
				0000001,
				SYSDATETIME(),
				1 
			)
		End
	Else
		Begin
			INSERT INTO AUDIT (PID, ACCESSTIMESTAMP, SUCCESS)
			Values(
				9999999,
				SYSDATETIME(),
				0
			)
		End


RETURN 0