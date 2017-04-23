CREATE PROCEDURE [dbo].sp_SearchMemberByLastName
	@LName nvarchar(75)
AS
	SELECT * from MEMBER where LName like(CONCAT(@LName, '%'))
RETURN 0