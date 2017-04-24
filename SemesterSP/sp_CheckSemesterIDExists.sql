CREATE PROCEDURE [dbo].sp_CheckSemesterIDExists
	@SemesterID nvarchar(4),
	@recCount int=0 OUTPUT
AS
	SET @recCount = (Select count(0) FROM SEMESTER WHERE SemesterID = @SemesterID)

	SELECT @recCount as RecordCount

RETURN 0