CREATE PROCEDURE [dbo].CheckGoodLogin
	@ukid int
AS
	SELECT * FROM AUDIT where ukid = @ukid
RETURN 0
