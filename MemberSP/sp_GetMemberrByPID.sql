CREATE PROCEDURE [dbo].sp_GetMemberByPID
@PID nvarchar(7)
AS
	SELECT * from MEMBER
	where PID=@PID
RETURN 0
