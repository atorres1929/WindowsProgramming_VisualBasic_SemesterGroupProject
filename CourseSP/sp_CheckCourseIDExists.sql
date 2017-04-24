CREATE PROCEDURE [dbo].sp_CheckCourseIDExists
	@CourseID nvarchar(10),
	@recCount int=0 OUTPUT
AS
	SET @recCount = (Select count(0) FROM COURSE WHERE CourseID = @CourseID)

	SELECT @recCount as RecordCount

RETURN 0