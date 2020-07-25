USE [Dogs]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

DROP PROC DeleteDogAll;
DROP PROC CountDog;
DROP PROC DeleteDogByID;
DROP PROC UpdateDogByID;
DROP PROC ReadDogByID;
DROP PROC CreateDog;
GO


CREATE PROC CreateDog(
  @DogID int output,
  @Name varchar(100),
  @RegularQualificationAchieved bit,
  @ExperienceForAdvancedProgram bit,
  @Experience text
) AS
BEGIN
    INSERT INTO Dog(Name, RegularQualificationAchieved, ExperienceForAdvancedProgram, Experience)
    VALUES (@Name, @RegularQualificationAchieved, @ExperienceForAdvancedProgram, @Experience);

    SET @DogID = SCOPE_IDENTITY();
END
GO


CREATE PROC ReadDogByID(
  @DogID int
) AS
BEGIN
	SELECT * FROM Dog
	WHERE DogID = @DogID
END
GO


CREATE PROC UpdateDogByID(
	@DogID int,
	@Name varchar(100),
	@RegularQualificationAchieved bit,
	@ExperienceForAdvancedProgram bit,
	@Experience text
) AS
BEGIN
	UPDATE Dog
	SET Name = @Name,
		RegularQualificationAchieved = @RegularQualificationAchieved,
		ExperienceForAdvancedProgram = @ExperienceForAdvancedProgram,
		Experience = @Experience
	WHERE DogID = @DogID
END
GO


CREATE PROC DeleteDogByID (
	@DogID int
) AS
BEGIN
	DELETE FROM Dog
	WHERE DogID = @DogID
END
GO


CREATE PROC CountDog
AS
BEGIN
	SELECT * FROM Dog
END
GO


CREATE PROC DeleteDogAll 
AS
BEGIN
	DELETE FROM Dog
END
GO


/* Executing Stored Procedures */

DECLARE @DogID int;

EXEC CreateDog
  @DogID output,
  'Ted',
  1,
  0,
  'None'

SELECT @DogID 

EXEC ReadDogByID @DogID

EXEC UpdateDogByID @DogID, 'Thor', 1, 1, 'Hammers'

EXEC ReadDogByID @DogID

EXEC DeleteDogByID @DogID

EXEC ReadDogByID @DogID
GO

EXEC CountDog
GO
