/*This script creates all the stored procedures for the dog table*/

/*Specifies which database is being used*/
USE [Dogs]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*Drop all stored procedures*/
DROP PROC ReadDogs;
DROP PROC DeleteDogAll;
DROP PROC CountDog;
DROP PROC DeleteDogByID;
DROP PROC UpdateDogByID;
DROP PROC ReadDogByID;
DROP PROC CreateDog;
GO

/*Stored Procedures:
  Name: Createdog
  Purpose: new record in table 
  Parameters: data required to create new record 
  Return: ID of new record
  
  Name: ReaddogByID
  Purpose: Read the record in the table with the specified ID
  Parameters: ID
  Return: A cursor with one record

  Name: Readdogs
  Purpose: Read all the records in the table
  Parameters: None
  Return: A cursor with multiple records

  Name: UpdatedogByID
  Purpose: Update the record in the table with the specified ID
  Parameters: ID and updated values
  Return: None

  Name: DeletedogByID
  Purpose: Delete the record in the table with the specified ID
  Parameters: ID
  Return: None

  Name: DeletedogAll
  Purpose: Delete all the records in the table
  Parameters: None
  Return: None

  Name: Countdog
  Purpose: Count the number of records in the table
  Parameters: None
  Return: Cursor with one row and one column
*/

CREATE PROC CreateDog(
  @DogID int output,
  @ClientID int,
  @Name varchar(100),
  @RegularQualificationAchieved bit,
  @ExperienceForAdvancedProgram bit,
  @Experience text
) AS
BEGIN
    INSERT INTO Dog(ClientID, Name, RegularQualificationAchieved, ExperienceForAdvancedProgram, Experience)
    VALUES (@ClientID, @Name, @RegularQualificationAchieved, @ExperienceForAdvancedProgram, @Experience);

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
	@ClientID int,
	@Name varchar(100),
	@RegularQualificationAchieved bit,
	@ExperienceForAdvancedProgram bit,
	@Experience text
) AS
BEGIN
	UPDATE Dog
	SET Name = @Name,
		ClientID = @ClientID,
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
	SELECT COUNT(*) FROM Dog
END
GO


CREATE PROC DeleteDogAll 
AS
BEGIN
	DELETE FROM Dog
END
GO


CREATE PROC ReadDogs
AS
BEGIN
	Select * FROM Dog
END
GO


/* Testing Stored Procedures 

DECLARE @DogID int;

EXEC CreateDog
  @DogID output,
  'Ted',
  1,
  0,
  'None'

SELECT @DogID 

EXEC ReadDogByID @DogID

EXEC ReadDogs

EXEC UpdateDogByID @DogID, 'Thor', 1, 1, 'Hammers'

EXEC ReadDogByID @DogID

EXEC DeleteDogByID @DogID

EXEC ReadDogByID @DogID

SELECT * FROM Dog
GO

*/