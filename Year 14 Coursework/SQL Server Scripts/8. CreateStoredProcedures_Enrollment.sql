/*This script creates all the stored procedures for the enrollment table*/

/*Specifies which database is being used*/
USE [Dogs]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*Drop all stored procedures*/
DROP PROC ReadEnrollment;
DROP PROC DeleteEnrollmentAll;
DROP PROC CountEnrollment;
DROP PROC DeleteEnrollmentByID;
DROP PROC UpdateEnrollmentByID;
DROP PROC ReadEnrollmentByID;
DROP PROC CreateEnrollment;
GO

/*Stored Procedures:
  Name: Createenrollment
  Purpose: new record in table 
  Parameters: data required to create new record 
  Return: ID of new record
  
  Name: ReadenrollmentByID
  Purpose: Read the record in the table with the specified ID
  Parameters: ID
  Return: A cursor with one record

  Name: Readenrollments
  Purpose: Read all the records in the table
  Parameters: None
  Return: A cursor with multiple records

  Name: UpdateenrollmentByID
  Purpose: Update the record in the table with the specified ID
  Parameters: ID and updated values
  Return: None

  Name: DeleteenrollmentByID
  Purpose: Delete the record in the table with the specified ID
  Parameters: ID
  Return: None

  Name: DeleteenrollmentAll
  Purpose: Delete all the records in the table
  Parameters: None
  Return: None

  Name: Countenrollment
  Purpose: Count the number of records in the table
  Parameters: None
  Return: Cursor with one row and one column
*/

CREATE PROC CreateEnrollment(
  @EnrollmentID int output,
  @ClientID int,
  @DogID int,
  @ProgramID int,
  @PaymentMethod int
) AS
BEGIN
    INSERT INTO Enrollment(ClientID, DogID, ProgramID, PaymentMethod)
    VALUES (@ClientID, @DogID, @ProgramID, @PaymentMethod);

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
	@ProgramID int,
	@PaymentMethod int
) AS
BEGIN
	UPDATE Enrollment
	SET ClientID = @ClientID,
		DogID = @DogID,
		ProgramID = @ProgramID,
		PaymentMethod = @PaymentMethod

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
	SELECT COUNT(*) FROM Enrollment
END
GO


CREATE PROC DeleteEnrollmentAll 
AS
BEGIN
	DELETE FROM Enrollment
END
GO

CREATE PROC ReadEnrollment
AS
BEGIN
	Select * FROM Enrollment
END
GO


/* Testing Stored Procedures 

DECLARE @EnrollmentID int;

EXEC CreateEnrollment
  @EnrollmentID output, 
  3, 4, 7

SELECT @EnrollmentID 

EXEC ReadEnrollmentByID @EnrollmentID

EXEC ReadEnrollment

EXEC UpdateEnrollmentByID @EnrollmentID, 3, 4, 9

EXEC ReadEnrollmentByID @EnrollmentID

EXEC DeleteEnrollmentByID @EnrollmentID

EXEC ReadEnrollmentByID @EnrollmentID
GO

EXEC CountEnrollment
GO

*/