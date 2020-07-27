USE [Dogs]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

DROP PROC DeleteEnrollmentAll;
DROP PROC CountEnrollment;
DROP PROC DeleteEnrollmentByID;
DROP PROC UpdateEnrollmentByID;
DROP PROC ReadEnrollmentByID;
DROP PROC CreateEnrollment;
GO


CREATE PROC CreateEnrollment(
  @EnrollmentID int output,
  @ClientID int,
  @DogID int,
  @ProgramID int
) AS
BEGIN
    INSERT INTO Enrollment(ClientID, DogID, ProgramID)
    VALUES (@ClientID, @DogID, @ProgramID);

    SET @EnrollmentID = SCOPE_IDENTITY();
END
GO


CREATE PROC ReadEnrollmentByID(
  @EnrollmentID int
) AS
BEGIN
	SELECT * FROM Enrollment
	WHERE EnrollmentID = @EnrollmentID
END
GO


CREATE PROC UpdateEnrollmentByID(
	@EnrollmentID int,
	@ClientID int,
	@DogID int,
	@ProgramID int
) AS
BEGIN
	UPDATE Enrollment
	SET ClientID = @ClientID,
		DogID = @DogID,
		ProgramID = @ProgramID

	WHERE EnrollmentID = @EnrollmentID
END
GO


CREATE PROC DeleteEnrollmentByID (
	@EnrollmentID int
) AS
BEGIN
	DELETE FROM Enrollment
	WHERE EnrollmentID = @EnrollmentID
END
GO


CREATE PROC CountEnrollment
AS
BEGIN
	SELECT * FROM Enrollment
END
GO


CREATE PROC DeleteEnrollmentAll 
AS
BEGIN
	DELETE FROM Enrollment
END
GO


/* Executing Stored Procedures */

DECLARE @EnrollmentID int;

EXEC CreateEnrollment
  @EnrollmentID output, 
  3, 4, 7

SELECT @EnrollmentID 

EXEC ReadEnrollmentByID @EnrollmentID

EXEC UpdateEnrollmentByID @EnrollmentID, 3, 4, 9

EXEC ReadEnrollmentByID @EnrollmentID

EXEC DeleteEnrollmentByID @EnrollmentID

EXEC ReadEnrollmentByID @EnrollmentID
GO

EXEC CountEnrollment
GO
