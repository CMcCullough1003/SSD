USE [Dogs]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

DROP PROC DeleteProgramAll;
DROP PROC CountProgram;
DROP PROC DeleteProgramByID;
DROP PROC UpdateProgramByID;
DROP PROC ReadProgramByID;
DROP PROC CreateProgram;
GO


CREATE PROC CreateProgram(
  @ProgramID int output,
  @ProgramTypeID int,
  @ProgramCostID int,
  @DogSpacesMaximum int,
  @NoOfClasses int
) AS
BEGIN
    INSERT INTO Program(ProgramTypeID, ProgramCostID, DogSpacesMaximum, NoOfClasses)
    VALUES (@ProgramTypeID, @ProgramCostID, @DogSpacesMaximum, @NoOfClasses);

    SET @ProgramID = SCOPE_IDENTITY();
END
GO


CREATE PROC ReadProgramByID(
  @ProgramID int
) AS
BEGIN
	SELECT * FROM Program
	WHERE ProgramID = @ProgramID
END
GO


CREATE PROC UpdateProgramByID(
	@ProgramID int,
	@ProgramTypeID int,
	@ProgramCostID int,
	@DogSpacesMaximum int,
	@NoOfClasses int
) AS
BEGIN
	UPDATE Program
	SET ProgramTypeID = @ProgramTypeID,
		ProgramCostID = @ProgramCostID,
		DogSpacesMaximum = @DogSpacesMaximum,
		NoOfClasses = @NoOfClasses

	WHERE ProgramID = @ProgramID
END
GO


CREATE PROC DeleteProgramByID (
	@ProgramID int
) AS
BEGIN
	DELETE FROM Program
	WHERE ProgramID = @ProgramID
END
GO


CREATE PROC CountProgram
AS
BEGIN
	SELECT * FROM Program
END
GO


CREATE PROC DeleteProgramAll 
AS
BEGIN
	DELETE FROM Program
END
GO


/* Executing Stored Procedures */

DECLARE @ProgramID int;

EXEC CreateProgram
  @ProgramID output, 
  9, 12, 9, 6

SELECT @ProgramID 

EXEC ReadProgramByID @ProgramID

EXEC UpdateProgramByID @ProgramID, 9, 12, 12, 5

EXEC ReadProgramByID @ProgramID

EXEC DeleteProgramByID @ProgramID

EXEC ReadProgramByID @ProgramID
GO

EXEC CountProgram
GO
