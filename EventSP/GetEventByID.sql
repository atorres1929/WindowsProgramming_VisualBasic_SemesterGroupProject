CREATE PROCEDURE [dbo].sp_GetEventByID
	@eventID nvarchar(4)
AS
	SELECT * FROM EVENT
	WHERE EventID=@eventID
RETURN 0