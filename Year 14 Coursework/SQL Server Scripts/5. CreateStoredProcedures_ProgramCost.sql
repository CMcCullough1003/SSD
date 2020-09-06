/*This script creates all the stored procedures for the programCost table*/

/*Specifies which database is being used*/
USE [Dogs]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*Drop all stored procedures*/
DROP PROC ReadProgramCost
DROP PROC DeleteProgramCostAll;
DROP PROC CountProgramCost;
DROP PROC DeleteProgramCostByID;
DROP PROC UpdateProgramCostByID;
DROP PROC ReadProgramCostByID;
DROP PROC CreateProgramCost;
GO

/*Stored Procedures:
  Name: CreateprogramCost
  Purpose: new record in table 
  Parameters: data required to create new record 
  Return: ID of new record
  
  Name: ReadprogramCostByID
  Purpose: Read the record in the table with the specified ID
  Parameters: ID
  Return: A cursor with one record

  Name: ReadprogramCosts
  Purpose: Read all the records in the table
  Parameters: None
  Return: A cursor with multiple records

  Name: UpdateprogramCostByID
  Purpose: Update the record in the table with the specified ID
  Parameters: ID and updated values
  Return: None

  Name: DeleteprogramCostByID
  Purpose: Delete the record in the table with the specified ID
  Parameters: ID
  Return: None

  Name: DeleteprogramCostAll
  Purpose: Delete all the records in the table
  Parameters: None
  Return: None

  Name: CountprogramCost
  Purpose: Count the number of records in the table
  Parameters: None
  Return: Cursor with one row and one column
*/

CREATE PROC CreateProgramCost(
  @ProgramCostID int output,
  @DepositAmount float,
  @SessionCost float,
  @FullPaymentPercentageDiscount float
) AS
BEGIN
    INSERT INTO ProgramCost(DepositAmount, SessionCost, FullPaymentPercentageDiscount)
    VALUES (@DepositAmount, @SessionCost, @FullPaymentPercentageDiscount);

    SET @ProgramCostID = SCOPE_IDENTITY();
END
GO


CREATE PROC ReadProgramCostByID(
  @ProgramCostID int
) AS
BEGIN
	SELECT * FROM ProgramCost
	WHERE ProgramCostID = @ProgramCostID
END
GO


CREATE PROC UpdateProgramCostByID(
	@ProgramCostID int,
	@DepositAmount float,
	@SessionCost float,
	@FullPaymentPercentageDiscount int
) AS
BEGIN
	UPDATE ProgramCost
	SET DepositAmount = @DepositAmount,
		SessionCost = @SessionCost,
		FullPaymentPercentageDiscount = @FullPaymentPercentageDiscount

	WHERE ProgramCostID = @ProgramCostID
END
GO


CREATE PROC DeleteProgramCostByID (
	@ProgramCostID int
) AS
BEGIN
	DELETE FROM ProgramCost
	WHERE ProgramCostID = @ProgramCostID
END
GO


CREATE PROC CountProgramCost
AS
BEGIN
	SELECT COUNT(*) FROM ProgramCost
END
GO


CREATE PROC DeleteProgramCostAll 
AS
BEGIN
	DELETE FROM ProgramCost
END
GO

CREATE PROC ReadProgramCost
AS
BEGIN
	Select * FROM ProgramCost
END
GO


/* Testing Stored Procedures 

DECLARE @ProgramCostID int;

EXEC CreateProgramCost
  @ProgramCostID output, 
  99, 25, 10

SELECT @ProgramCostID 

EXEC ReadProgramCostByID @ProgramCostID

EXEC ReadProgramCost

EXEC UpdateProgramCostByID @ProgramCostID, 80, 30, 30

EXEC ReadProgramCostByID @ProgramCostID

EXEC DeleteProgramCostByID @ProgramCostID

EXEC ReadProgramCostByID @ProgramCostID

EXEC CountProgramCost
GO

*/