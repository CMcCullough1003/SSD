/*This script creates all the stored procedures for the programType table*/

/*Specifies which database is being used*/
USE [Dogs]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*Drop all stored procedures*/
DROP PROC ReadProgramType;
DROP PROC DeleteProgramTypeAll;
DROP PROC CountProgramType;
DROP PROC DeleteProgramTypeByID;
DROP PROC UpdateProgramTypeByID;
DROP PROC ReadProgramTypeByID;
DROP PROC CreateProgramType;
GO

/*Stored Procedures:
  Name: CreateprogramType
  Purpose: new record in table 
  Parameters: data required to create new record 
  Return: ID of new record
  
  Name: ReadprogramTypeByID
  Purpose: Read the record in the table with the specified ID
  Parameters: ID
  Return: A cursor with one record

  Name: ReadprogramTypes
  Purpose: Read all the records in the table
  Parameters: None
  Return: A cursor with multiple records

  Name: UpdateprogramTypeByID
  Purpose: Update the record in the table with the specified ID
  Parameters: ID and updated values
  Return: None

  Name: DeleteprogramTypeByID
  Purpose: Delete the record in the table with the specified ID
  Parameters: ID
  Return: None

  Name: DeleteprogramTypeAll
  Purpose: Delete all the records in the table
  Parameters: None
  Return: None

  Name: CountprogramType
  Purpose: Count the number of records in the table
  Parameters: None
  Return: Cursor with one row and one column
*/

CREATE PROC CreateProgramType(
  @ProgramTypeID int output,
  @Description varchar(20)
) AS
BEGIN
    INSERT INTO ProgramType(Description)
    VALUES (@Description);

    SET @ProgramTypeID = SCOPE_IDENTITY();
END
GO


CREATE PROC ReadProgramTypeByID(
  @ProgramTypeID int
) AS
BEGIN
	SELECT * FROM ProgramType
	WHERE ProgramTypeID = @ProgramTypeID
END
GO


CREATE PROC UpdateProgramTypeByID(
	@ProgramTypeID int,
	@Description varchar(20)
) AS
BEGIN
	UPDATE ProgramType
	SET Description = @Description
	WHERE ProgramTypeID = @ProgramTypeID
END
GO


CREATE PROC DeleteProgramTypeByID (
	@ProgramTypeID int
) AS
BEGIN
	DELETE FROM ProgramType
	WHERE ProgramTypeID = @ProgramTypeID
END
GO


CREATE PROC CountProgramType
AS
BEGIN
	SELECT COUNT(*) FROM ProgramType
END
GO


CREATE PROC DeleteProgramTypeAll 
AS
BEGIN
	DELETE FROM ProgramType
END
GO

CREATE PROC ReadProgramType
AS
BEGIN
	Select * FROM ProgramType
END
GO


/* Testing Stored Procedures 

DECLARE @ProgramTypeID int;

EXEC CreateProgramType
  @ProgramTypeID output,
  'Regular'

SELECT @ProgramTypeID 

EXEC ReadProgramTypeByID @ProgramTypeID

EXEC UpdateProgramTypeByID @ProgramTypeID, 'Advanced'

EXEC ReadProgramTypeByID @ProgramTypeID

EXEC ReadProgramType

EXEC DeleteProgramTypeByID @ProgramTypeID

EXEC ReadProgramTypeByID @ProgramTypeID

EXEC CountProgramType
GO

*/