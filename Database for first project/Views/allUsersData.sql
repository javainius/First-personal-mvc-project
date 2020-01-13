CREATE VIEW allUsersData AS
SELECT u.Id,
	   u.Name,
	   u.LastName,
	   u.Email,
	   u.Description,
	   u.SexId,
	   s.SexType
FROM dbo.UserData u
JOIN dbo.Sex s ON u.SexId = s.Id