CREATE PROCEDURE [dbo].sp_SearchMembers
	@Search nvarchar(75)
AS
	SELECT LName from MEMBER
	where MEMBER.LName like @Search
RETURN 0
