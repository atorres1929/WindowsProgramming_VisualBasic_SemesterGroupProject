CREATE PROCEDURE [dbo].sp_SaveEvent
	@eventID nvarchar(15),
	@eventDescription nvarchar(500),
	@eventTypeID nvarchar(15),
	@semesterID nvarchar(4),
	@startDate smalldatetime,
	@endDate smalldatetime,
	@location nvarchar(50)
AS
	Declare @countExists int
	Select @countExists = Count(0) FROM EVENT WHERE EventID=@eventID
	if (@countExists=0)
	BEGIN
		INSERT INTO EVENT
		(EventID
		,EventDescription
		,EventTypeID
		,SemesterID
		,StartDate
		,EndDate
		,Location
		)
		VALUES
		(@eventID
		,@eventDescription
		,@eventTypeID
		,@semesterID
		,@startDate
		,@endDate
		,@location
		)
	END
	ELSE
	BEGIN
		UPDATE EVENT
		SET EventDescription=@eventDescription,
			EventTypeID=@eventTypeID, 
			SemesterID=@semesterID,
			StartDate=@startDate,
			EndDate=@endDate,
			Location=@location
		WHERE EventID=@eventID
	END
RETURN @@error