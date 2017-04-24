CREATE PROCEDURE [dbo].sp_SaveSemester
	@semesterID nvarchar(4),
	@semesterDescription nvarchar(100)
AS
	Declare @countExists int
	Select @countExists = Count(0) FROM SEMESTER WHERE SemesterID = @semesterID
	if (@countExists = 0)
	BEGIN
		INSERT INTO SEMESTER
		(SemesterID
		,SemesterDescription
		)
		VALUES
		(@semesterID
		,@semesterDescription
		)
		END
		ELSE
		BEGIN
			UPDATE SEMESTER
			SET SemesterDescription = @semesterDescription
			WHERE SemesterID = @semesterID
		END
RETURN @@error