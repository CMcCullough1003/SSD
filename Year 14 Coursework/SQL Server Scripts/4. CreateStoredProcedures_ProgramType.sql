USE [Dogs]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

DROP PROC DeleteProgramTypeByID;
DROP PROC UpdateProgramTypeByID;
DROP PROC ReadProgramTypeByID;
DROP PROC CreateProgramType;
GO


CREATE PROC CreateProgramType(
  @ProgramTypeID int output,
  @Description varchar(20)
) AS
BEGIN
    INSERT INTO ProgramType(Description)
    VALUES (@Description);

    SET @ProgramTypeID = SCOPE_IDENTITY();
END
GO


CREATE PROC ReadProgramTypeByID(
  @ProgramTypeID int
) AS
BEGIN
	SELECT * FROM ProgramType
	WHERE ProgramTypeID = @ProgramTypeID
END
GO


CREATE PROC UpdateProgramTypeByID(
	@ProgramTypeID int,
	@Description varchar(20)
) AS
BEGIN
	UPDATE ProgramType
	SET Description = @Description
	WHERE ProgramTypeID = @ProgramTypeID
END
GO


CREATE PROC DeleteProgramTypeByID (
	@ProgramTypeID int
) AS
BEGIN
	DELETE FROM ProgramType
	WHERE ProgramTypeID = @ProgramTypeID
END
GO


CREATE PROC CountProgramType
AS
BEGIN
	SELECT * FROM ProgramType
END
GO


CREATE PROC DeleteProgramTypeAll 
AS
BEGIN
	DELETE FROM ProgramType
END
GO


/* Executing Stored Procedures */

DECLARE @ProgramTypeID int;

EXEC CreateProgramType
  @ProgramTypeID output,
  'Regular'

SELECT @ProgramTypeID 

EXEC ReadProgramTypeByID @ProgramTypeID

EXEC UpdateProgramTypeByID @ProgramTypeID, 'Advanced'

EXEC ReadProgramTypeByID @ProgramTypeID

EXEC DeleteProgramTypeByID @ProgramTypeID

EXEC ReadProgramTypeByID @ProgramTypeID
GO

EXEC CountProgramType
GO
