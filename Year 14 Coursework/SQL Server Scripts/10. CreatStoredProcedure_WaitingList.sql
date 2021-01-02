/*This script creates all the stored procedures for the waitingList table*/

/*Specifies which database is being used*/
USE [Dogs]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*Drop all stored procedures*/
DROP PROC ReadWaitingList;
DROP PROC DeleteWaitingListAll;
DROP PROC CountWaitingList;
DROP PROC DeleteWaitingListByID;
DROP PROC UpdateWaitingListByID;
DROP PROC ReadWaitingListByID;
DROP PROC CreateWaitingList;
GO

/*Stored Procedures:
  Name: CreatewaitingList
  Purpose: new record in table 
  Parameters: data required to create new record 
  Return: ID of new record
  
  Name: ReadwaitingListByID
  Purpose: Read the record in the table with the specified ID
  Parameters: ID
  Return: A cursor with one record

  Name: ReadwaitingLists
  Purpose: Read all the records in the table
  Parameters: None
  Return: A cursor with multiple records

  Name: UpdatewaitingListByID
  Purpose: Update the record in the table with the specified ID
  Parameters: ID and updated values
  Return: None

  Name: DeletewaitingListByID
  Purpose: Delete the record in the table with the specified ID
  Parameters: ID
  Return: None

  Name: DeletewaitingListAll
  Purpose: Delete all the records in the table
  Parameters: None
  Return: None

  Name: CountwaitingList
  Purpose: Count the number of records in the table
  Parameters: None
  Return: Cursor with one row and one column
*/

CREATE PROC CreateWaitingList(
  @WaitingListID int output,
  @ClientID int,
  @DogID int,
  @ProgramVarietyID int,
  @JoinDate dateTime,
  @InviteIssued bit
) AS
BEGIN
    INSERT INTO WaitingList(ClientID, DogID, ProgramVarietyID, JoinDate, InviteIssued)
    VALUES (@ClientID, @DogID, @ProgramVarietyID, @JoinDate, @InviteIssued);

    SET @WaitingListID = SCOPE_IDENTITY();
END
GO


CREATE PROC ReadWaitingListByID(
  @WaitingListID int
) AS
BEGIN
	SELECT * FROM WaitingList
	WHERE WaitingListID = @WaitingListID
END
GO


CREATE PROC UpdateWaitingListByID(
	@WaitingListID int,
	@ClientID int,
	@DogID int,
	@ProgramVarietyID int,
	@JoinDate dateTime,
	@InviteIssued bit
) AS
BEGIN
	UPDATE WaitingList
	SET ClientID = @ClientID,
		DogID = @DogID,
		ProgramVarietyID = @ProgramVarietyID,
		JoinDate = @JoinDate,
		InviteIssued = @InviteIssued

	WHERE WaitingListID = @WaitingListID
END
GO


CREATE PROC DeleteWaitingListByID (
	@WaitingListID int
) AS
BEGIN
	DELETE FROM WaitingList
	WHERE WaitingListID = @WaitingListID
END
GO


CREATE PROC CountWaitingList
AS
BEGIN
	SELECT COUNT(*) FROM WaitingList
END
GO


CREATE PROC DeleteWaitingListAll 
AS
BEGIN
	DELETE FROM WaitingList
END
GO


CREATE PROC ReadWaitingList
AS
BEGIN
	Select * FROM WaitingList
END
GO

/* Testing Stored Procedures

DECLARE @WaitingListID int;
DECLARE @WLJoinDate Date
SET @WLJoinDate = CONVERT(DATE, '2021-08-15')

EXEC CreateWaitingList
  @WaitingListID output, 
  21, 2, 9, @WLJoinDate, 1

SELECT @WaitingListID 

EXEC ReadWaitingListByID @WaitingListID

EXEC ReadWaitingList

EXEC UpdateWaitingListByID @WaitingListID, 21, 4, 9, @WLJoinDate, 1

EXEC ReadWaitingListByID @WaitingListID

EXEC DeleteWaitingListByID @WaitingListID

EXEC ReadWaitingListByID @WaitingListID
GO

EXEC CountWaitingList
GO

*/