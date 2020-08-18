USE [Dogs]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

DROP PROC ReadClass;
DROP PROC DeleteClassAll;
DROP PROC CountClass;
DROP PROC DeleteClassByID;
DROP PROC UpdateClassByID;
DROP PROC ReadClassByID;
DROP PROC CreateClass;
GO


CREATE PROC CreateClass(
  @ClassID int output,
  @ProgramID int,
  @StaffID int,
  @ClassDate date,
  @StartTime time,
  @EndTime time
) AS
BEGIN
    INSERT INTO Class(ProgramID, StaffID, ClassDate, StartTime, EndTime)
    VALUES (@ProgramID, @StaffID, @ClassDate, @StartTime, @EndTime);

    SET @ClassID = SCOPE_IDENTITY();
END
GO


CREATE PROC ReadClassByID(
  @ClassID int
) AS
BEGIN
	SELECT * FROM Class
	WHERE ClassID = @ClassID
END
GO


CREATE PROC UpdateClassByID(
	@ClassID int,
	@ProgramID int,
	@StaffID int,
	@ClassDate date,
	@StartTime time,
    @EndTime time
) AS
BEGIN
	UPDATE Class
	SET ProgramID = @ProgramID,
		StaffID = @StaffID,
		ClassDate = @ClassDate,
		StartTime = @StartTime,
		EndTime = @EndTime

	WHERE ClassID = @ClassID
END
GO


CREATE PROC DeleteClassByID (
	@ClassID int
) AS
BEGIN
	DELETE FROM Class
	WHERE ClassID = @ClassID
END
GO


CREATE PROC CountClass
AS
BEGIN
	SELECT * FROM Class
END
GO


CREATE PROC DeleteClassAll 
AS
BEGIN
	DELETE FROM Class
END
GO


CREATE PROC ReadClass
AS
BEGIN
	Select * FROM Class
END
GO


/* Executing Stored Procedures */

DECLARE @ClassID int;
DECLARE @ClassDate Date
DECLARE @StartTime Time
DECLARE @EndTime Time
SET @ClassDate = CONVERT(DATE, '2021-08-15')
SET @StartTime = CONVERT(TIME, '11:00')
SET @EndTime = CONVERT(TIME, '13:00')


EXEC CreateClass @ClassID output, 9, 5, @ClassDate, @StartTime,  @EndTime

SELECT @ClassID 

EXEC ReadClassByID @ClassID

EXEC ReadClass

EXEC UpdateClassByID @ClassID, 9, 5,  @ClassDate, @StartTime,  @EndTime

EXEC ReadClassByID @ClassID

EXEC DeleteClassByID @ClassID

EXEC ReadClassByID @ClassID
GO

EXEC CountClass
GO
