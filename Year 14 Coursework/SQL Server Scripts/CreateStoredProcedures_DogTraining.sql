USE [Dogs]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

DROP PROC InsertStaffMember;
GO

CREATE PROC InsertStaffMember(
  @StaffID int output,
  @Name varchar(100)
) AS
BEGIN
    INSERT INTO Staff(Name)
    VALUES (@Name);

    SET @StaffID = SCOPE_IDENTITY();
END
GO

DECLARE @StaffID int;

EXEC InsertStaffMember
  @StaffID output,
  'Bob'

SELECT @StaffID 