CREATE PROCEDURE [dbo].sp_SaveRSVP
	@eventID nvarchar(15),
	@fName nvarchar(50),
	@lName nvarchar(75),
	@email nvarchar(50)
AS
	BEGIN
		INSERT INTO EVENT_RSVP
		(EventID
		,FName
		,LName
		,Email
		)
		VALUES
		(@eventID
		,@fName
		,@lName
		,@email
		)
	END
RETURN @@error