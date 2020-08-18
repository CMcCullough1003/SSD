USE [Dogs]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

DROP PROC ReadWaitingList;
DROP PROC DeleteWaitingListAll;
DROP PROC CountWaitingList;
DROP PROC DeleteWaitingListByID;
DROP PROC UpdateWaitingListByID;
DROP PROC ReadWaitingListByID;
DROP PROC CreateWaitingList;
GO


CREATE PROC CreateWaitingList(
  @WaitingListID int output,
  @ClientID int,
  @DogID int,
  @ProgramTypeID int,
  @JoinDate dateTime,
  @InviteIssued bit
) AS
BEGIN
    INSERT INTO WaitingList(ClientID, DogID, ProgramTypeID, JoinDate, InviteIssued)
    VALUES (@ClientID, @DogID, @ProgramTypeID, @JoinDate, @InviteIssued);

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
	@ProgramTypeID int,
	@JoinDate dateTime,
	@InviteIssued bit
) AS
BEGIN
	UPDATE WaitingList
	SET ClientID = @ClientID,
		DogID = @DogID,
		ProgramTypeID = @ProgramTypeID,
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
	SELECT * FROM WaitingList
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

/* Executing Stored Procedures */

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

/* EXEC DeleteWaitingListByID @WaitingListID */

EXEC ReadWaitingListByID @WaitingListID
GO

EXEC CountWaitingList
GO