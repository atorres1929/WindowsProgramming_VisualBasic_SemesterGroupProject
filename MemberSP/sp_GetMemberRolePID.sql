CREATE PROCEDURE [dbo].sp_GetMemberRolePID
@PID nvarchar(7),
@recCount int =0 OUTPUT

AS
	set @recCount= (Select count (0) from MEMBER_ROLE where PID=@PID)
	select @recCount as RecordCount
RETURN 0
