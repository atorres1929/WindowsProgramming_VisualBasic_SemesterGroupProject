﻿CREATE PROCEDURE [dbo].sp_GetRoleByID
	@roleID NVARCHAR(15)
AS
	SELECT * FROM dbo.ROLE WHERE RoleID = @roleID
RETURN 0