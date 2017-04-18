CREATE PROCEDURE [dbo].sp_CheckMemberPID
	@PID nvarchar(7),
	@recCount int = 0 OUTPUT

AS
	set @recCount= (Select count (0) from MEMBER where PID=@PID)
	select @recCount as RecordCount
RETURN 0