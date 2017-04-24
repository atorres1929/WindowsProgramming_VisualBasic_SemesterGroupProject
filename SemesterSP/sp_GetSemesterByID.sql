CREATE PROCEDURE [dbo].sp_GetSemesterByID
	@semesterID nvarchar(4)
AS
	SELECT * FROM SEMESTER
	WHERE semesterID = @semesterID
RETURN 0