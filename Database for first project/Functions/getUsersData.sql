
CREATE FUNCTION getUsersData()
RETURNS TABLE AS RETURN
	SELECT 
		ud.Id,
		ud.Name,
		ud.LastName,
		ud.Email,
		ud.SexId,
		ud.SexType,
		ud.Description
	FROM dbo.allUsersData ud