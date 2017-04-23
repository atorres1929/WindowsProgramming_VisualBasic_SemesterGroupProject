CREATE PROCEDURE [dbo].sp_GetAllMembersInSecurity
AS
	SELECT 
		dbo.Member.Pid, 
		dbo.SECURITY.UserID, 
		dbo.SECURITY.Password, 
		dbo.SECURITY.SecRole 
		FROM SECURITY Right JOIN MEMBER 
		ON SECURITY.PID = MEMBER.PID
RETURN 0