
CREATE FUNCTION getUsersData()
RETURNS TABLE AS RETURN
	SELECT 
		Id,
		Name,
		LastName,
		Email,
		Description,
		Age
	FROM dbo.allUserData