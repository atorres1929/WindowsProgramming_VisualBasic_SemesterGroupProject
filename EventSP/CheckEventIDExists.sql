CREATE PROCEDURE [dbo].sp_CheckEventIDExists
	@eventID nvarchar(15),
	@recCount int=0 OUTPUT
AS
	SET @recCount = (Select count(0) FROM EVENT WHERE Eventid=@eventID)
	select @recCount as RecordCount
RETURN 0