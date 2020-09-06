/*This script creates all the stored procedures for the staff table*/

/*Specifies which database is being used*/
USE [Dogs]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*Drop all stored procedures*/
DROP PROC ReadStaff;
DROP PROC DeleteStaffAll;
DROP PROC CountStaff;
DROP PROC DeleteStaffByID;
DROP PROC UpdateStaffByID;
DROP PROC ReadStaffByID;
DROP PROC CreateStaff;
GO

/*Stored Procedures:
  Name: Createstaff
  Purpose: new record in table 
  Parameters: data required to create new record 
  Return: ID of new record
  
  Name: ReadstaffByID
  Purpose: Read the record in the table with the specified ID
  Parameters: ID
  Return: A cursor with one record

  Name: Readstaffs
  Purpose: Read all the records in the table
  Parameters: None
  Return: A cursor with multiple records

  Name: UpdatestaffByID
  Purpose: Update the record in the table with the specified ID
  Parameters: ID and updated values
  Return: None

  Name: DeletestaffByID
  Purpose: Delete the record in the table with the specified ID
  Parameters: ID
  Return: None

  Name: DeletestaffAll
  Purpose: Delete all the records in the table
  Parameters: None
  Return: None

  Name: Countstaff
  Purpose: Count the number of records in the table
  Parameters: None
  Return: Cursor with one row and one column
*/

CREATE PROC CreateStaff(
  @StaffID int output,
  @Name varchar(100)
) AS
BEGIN
    INSERT INTO Staff(Name)
    VALUES (@Name);

    SET @StaffID = SCOPE_IDENTITY();
END
GO


CREATE PROC ReadStaffByID(
  @StaffID int
) AS
BEGIN
	SELECT * FROM Staff
	WHERE StaffID = @StaffID
END
GO


CREATE PROC UpdateStaffByID(
	@StaffID int,
	@Name varchar(100)
) AS
BEGIN
	UPDATE Staff
	SET Name = @Name
	WHERE StaffID = @StaffID
END
GO


CREATE PROC DeleteStaffByID (
	@StaffID int
) AS
BEGIN
	DELETE FROM Staff
	WHERE StaffID = @StaffID
END
GO


CREATE PROC CountStaff
AS
BEGIN
	SELECT COUNT(*) FROM Staff
END
GO


CREATE PROC DeleteStaffAll 
AS
BEGIN
	DELETE FROM Staff
END
GO


CREATE PROC ReadStaff
AS
BEGIN
	Select * FROM Staff
END
GO


/* Testing Stored Procedures 

DECLARE @StaffID int;

EXEC CreateStaff
  @StaffID output,
  'Bob'

SELECT @StaffID 

EXEC ReadStaffByID @StaffID

EXEC UpdateStaffByID @StaffID, 'Katie'

EXEC ReadStaffByID @StaffID

EXEC ReadStaff

EXEC DeleteStaffByID @StaffID

EXEC ReadStaffByID @StaffID
GO

*/