
CREATE PROCEDURE CreateUser(
	@Name NVARCHAR(50), 
	@LastName NVARCHAR(50), 
	@Email NVARCHAR(50), 
	@Description NVARCHAR(50), 
	@Age INT,
	@SexId INT 
) 
AS BEGIN
	INSERT INTO dbo.UserData (
		Name, 
		LastName, 
		Email, 
		Description, 
		Age,
		SexId
	)
    VALUES (
		@Name, 
		@LastName, 
		@Email, 
		@Description, 
		@Age,
		@SexId
	);
END