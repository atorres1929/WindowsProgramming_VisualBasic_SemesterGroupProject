CREATE PROCEDURE [dbo].sp_SaveMemberRole
	@PID nvarchar(7),
	@RoleID nvarchar(15),
	@SemesterID nvarchar(4)
AS

Declare @countExists int
Select @countExists = COUNT(0) from MEMBER_ROLE where PID=@PID
if (@countExists=0)

begin 
insert into MEMBER_ROLE
(PID,RoleID,SemesterID)
values
(@PID,@RoleID,@SemesterID)
end

begin 
update MEMBER_ROLE
set
PID=@PID,
RoleID=@RoleID,
SemesterID=@SemesterID

where MEMBER_ROLE.PID=@PID

end
RETURN @@error
