alter PROCEDURE [dbo].sp_SaveMember
	@PID nvarchar(7),
	@FName nvarchar(50),
	@LName nvarchar(75),
	@MI nvarchar(1),
	@Email nvarchar(50),
	@Phone nvarchar(13)
	,
	@PhotoPath nvarchar(300)
	/*@RoleID nvarchar(15)*/
AS

Declare @countExists int
Select @countExists = COUNT(0) from MEMBER where PID=@PID
if (@countExists=0)

begin 
insert into MEMBER
(PID,FName,LName,MI,Email,Phone,PhotoPath)
values
(@PID,@FName,@LName,@MI,@Email,@Phone,@PhotoPath)
end




Begin
update MEMBER
set FName=@FName,
LName=@LName,
MI=@MI,
Email=@Email,
Phone=@Phone,
PhotoPath=@PhotoPath

where MEMBER.PID=@PID



END
return @@ERROR