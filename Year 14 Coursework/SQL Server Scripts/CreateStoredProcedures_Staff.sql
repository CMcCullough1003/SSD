USE [Dogs]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

DROP PROC DeleteStaffAll;
DROP PROC CountStaff;
DROP PROC DeleteStaffByID;
DROP PROC UpdateStaffByID;
DROP PROC ReadStaffByID;
DROP PROC CreateStaff;
GO


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
	SELECT * FROM Staff
END
GO


CREATE PROC DeleteStaffAll 
AS
BEGIN
	DELETE FROM Staff
END
GO


/* Executing Stored Procedures */

DECLARE @StaffID int;

EXEC CreateStaff
  @StaffID output,
  'Bob'

SELECT @StaffID 

EXEC ReadStaffByID @StaffID

EXEC UpdateStaffByID @StaffID, 'Katie'

EXEC ReadStaffByID @StaffID

EXEC DeleteStaffByID @StaffID

EXEC ReadStaffByID @StaffID
GO

EXEC CountStaff
GO
