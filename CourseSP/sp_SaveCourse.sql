CREATE PROCEDURE [dbo].sp_SaveCourse
	@courseID nvarchar(10),
	@courseName nvarchar(50)
AS
	Declare @countExists int
	Select @countExists = Count(0) FROM COURSE WHERE CourseID = @courseID
	if (@countExists = 0)
	BEGIN
		INSERT INTO COURSE
		(CourseID
		,CourseName
		)
		VALUES
		(@courseID
		,@courseName
		)
		END
		ELSE
		BEGIN
			UPDATE COURSE
			SET CourseName = @courseName
			WHERE CourseID = @courseID
		END
RETURN @@error