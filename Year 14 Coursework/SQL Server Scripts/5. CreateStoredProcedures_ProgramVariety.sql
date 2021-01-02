/*This script creates all the stored procedures for the ProgramVariety table*/

/*Specifies which database is being used*/
USE [Dogs]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*Drop all stored procedures*/
DROP PROC ReadProgramVariety
DROP PROC DeleteProgramVarietyAll;
DROP PROC CountProgramVariety;
DROP PROC DeleteProgramVarietyByID;
DROP PROC UpdateProgramVarietyByID;
DROP PROC ReadProgramVarietyByID;
DROP PROC CreateProgramVariety;
GO

/*Stored Procedures:
  Name: CreateProgramVariety
  Purpose: new record in table 
  Parameters: data required to create new record 
  Return: ID of new record
  
  Name: ReadProgramVarietyByID
  Purpose: Read the record in the table with the specified ID
  Parameters: ID
  Return: A cursor with one record

  Name: ReadProgramVarietys
  Purpose: Read all the records in the table
  Parameters: None
  Return: A cursor with multiple records

  Name: UpdateProgramVarietyByID
  Purpose: Update the record in the table with the specified ID
  Parameters: ID and updated values
  Return: None

  Name: DeleteProgramVarietyByID
  Purpose: Delete the record in the table with the specified ID
  Parameters: ID
  Return: None

  Name: DeleteProgramVarietyAll
  Purpose: Delete all the records in the table
  Parameters: None
  Return: None

  Name: CountProgramVariety
  Purpose: Count the number of records in the table
  Parameters: None
  Return: Cursor with one row and one column
*/

CREATE PROC CreateProgramVariety(
  @ProgramVarietyID int output,
  @Name text,
  @DepositAmount float,
  @SessionCost float,
  @FullPaymentPercentageDiscount float
) AS
BEGIN
    INSERT INTO ProgramVariety(Name, DepositAmount, SessionCost, FullPaymentPercentageDiscount)
    VALUES (@Name, @DepositAmount, @SessionCost, @FullPaymentPercentageDiscount);

    SET @ProgramVarietyID = SCOPE_IDENTITY();
END
GO


CREATE PROC ReadProgramVarietyByID(
  @ProgramVarietyID int
) AS
BEGIN
	SELECT * FROM ProgramVariety
	WHERE ProgramVarietyID = @ProgramVarietyID
END
GO


CREATE PROC UpdateProgramVarietyByID(
	@ProgramVarietyID int,
	@Name text,
	@DepositAmount float,
	@SessionCost float,
	@FullPaymentPercentageDiscount float
) AS
BEGIN
	UPDATE ProgramVariety
	SET Name = @Name,
		DepositAmount = @DepositAmount,
		SessionCost = @SessionCost,
		FullPaymentPercentageDiscount = @FullPaymentPercentageDiscount

	WHERE ProgramVarietyID = @ProgramVarietyID
END
GO


CREATE PROC DeleteProgramVarietyByID (
	@ProgramVarietyID int
) AS
BEGIN
	DELETE FROM ProgramVariety
	WHERE ProgramVarietyID = @ProgramVarietyID
END
GO


CREATE PROC CountProgramVariety
AS
BEGIN
	SELECT COUNT(*) FROM ProgramVariety
END
GO


CREATE PROC DeleteProgramVarietyAll 
AS
BEGIN
	DELETE FROM ProgramVariety
END
GO

CREATE PROC ReadProgramVariety
AS
BEGIN
	Select * FROM ProgramVariety
END
GO


/* Testing Stored Procedures 

DECLARE @ProgramVarietyID int;

EXEC CreateProgramVariety
  @ProgramVarietyID output, 
  99, 25, 10

SELECT @ProgramVarietyID 

EXEC ReadProgramVarietyByID @ProgramVarietyID

EXEC ReadProgramVariety

EXEC UpdateProgramVarietyByID @ProgramVarietyID, 80, 30, 30

EXEC ReadProgramVarietyByID @ProgramVarietyID

EXEC DeleteProgramVarietyByID @ProgramVarietyID

EXEC ReadProgramVarietyByID @ProgramVarietyID

EXEC CountProgramVariety
GO

*/