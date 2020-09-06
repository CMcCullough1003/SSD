/*This script creates all the stored procedures for the program table*/

/*Specifies which database is being used*/
USE [Dogs]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*Drop all stored procedures*/
DROP PROC ReadProgram;
DROP PROC DeleteProgramAll;
DROP PROC CountProgram;
DROP PROC DeleteProgramByID;
DROP PROC UpdateProgramByID;
DROP PROC ReadProgramByID;
DROP PROC CreateProgram;
GO

/*Stored Procedures:
  Name: Createprogram
  Purpose: new record in table 
  Parameters: data required to create new record 
  Return: ID of new record
  
  Name: ReadprogramByID
  Purpose: Read the record in the table with the specified ID
  Parameters: ID
  Return: A cursor with one record

  Name: Readprograms
  Purpose: Read all the records in the table
  Parameters: None
  Return: A cursor with multiple records

  Name: UpdateprogramByID
  Purpose: Update the record in the table with the specified ID
  Parameters: ID and updated values
  Return: None

  Name: DeleteprogramByID
  Purpose: Delete the record in the table with the specified ID
  Parameters: ID
  Return: None

  Name: DeleteprogramAll
  Purpose: Delete all the records in the table
  Parameters: None
  Return: None

  Name: Countprogram
  Purpose: Count the number of records in the table
  Parameters: None
  Return: Cursor with one row and one column
*/

CREATE PROC CreateProgram(
  @ProgramID int output,
  @ProgramTypeID int,
  @ProgramCostID int,
  @DogSpacesMaximum int,
  @NoOfClasses int
) AS
BEGIN
    INSERT INTO Program(ProgramTypeID, ProgramCostID, DogSpacesMaximum, NoOfClasses)
    VALUES (@ProgramTypeID, @ProgramCostID, @DogSpacesMaximum, @NoOfClasses);

    SET @ProgramID = SCOPE_IDENTITY();
END
GO


CREATE PROC ReadProgramByID(
  @ProgramID int
) AS
BEGIN
	SELECT * FROM Program
	WHERE ProgramID = @ProgramID
END
GO


CREATE PROC UpdateProgramByID(
	@ProgramID int,
	@ProgramTypeID int,
	@ProgramCostID int,
	@DogSpacesMaximum int,
	@NoOfClasses int
) AS
BEGIN
	UPDATE Program
	SET ProgramTypeID = @ProgramTypeID,
		ProgramCostID = @ProgramCostID,
		DogSpacesMaximum = @DogSpacesMaximum,
		NoOfClasses = @NoOfClasses

	WHERE ProgramID = @ProgramID
END
GO


CREATE PROC DeleteProgramByID (
	@ProgramID int
) AS
BEGIN
	DELETE FROM Program
	WHERE ProgramID = @ProgramID
END
GO


CREATE PROC CountProgram
AS
BEGIN
	SELECT COUNT(*) FROM Program
END
GO


CREATE PROC DeleteProgramAll 
AS
BEGIN
	DELETE FROM Program
END
GO


CREATE PROC ReadProgram
AS
BEGIN
	Select * FROM Program
END
GO


/* Testing Stored Procedures 

DECLARE @ProgramID int;

EXEC CreateProgram
  @ProgramID output, 
  9, 12, 9, 6

SELECT @ProgramID 

EXEC ReadProgramByID @ProgramID

EXEC ReadProgram

EXEC UpdateProgramByID @ProgramID, 9, 12, 12, 5

EXEC ReadProgramByID @ProgramID

EXEC DeleteProgramByID @ProgramID

EXEC ReadProgramByID @ProgramID

EXEC CountProgram
GO

*/