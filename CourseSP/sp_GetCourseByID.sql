CREATE PROCEDURE [dbo].sp_GetCourseByID
	@courseID nvarchar(10)
AS
	SELECT * FROM COURSE
	WHERE courseID = @courseID
RETURN 0