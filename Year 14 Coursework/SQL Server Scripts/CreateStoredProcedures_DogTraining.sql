USE [Dogs]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

DROP PROC CreateClient;
DROP PROC CreateDog;

GO


CREATE PROC CreateDog(
  @DogID int output,
  @Name varchar(100),
  @RegularQualificationAchieved bit,
  @ExperienceForAdvancedProgram bit,
  @Experience text
) AS
BEGIN
    INSERT INTO Dog(Name, RegularQualificationAchieved, ExperienceForAdvancedProgram, Experience)
    VALUES (@Name, @RegularQualificationAchieved, @ExperienceForAdvancedProgram, @Experience);

    SET @DogID = SCOPE_IDENTITY();
END
GO

DECLARE @DogID int;

EXEC CreateDog
  @DogID output,
  'Ted',
  1,
  0,
  'None'

SELECT @DogID 
GO


CREATE PROC CreateClient(
  @ClientID int output,
  @Name varchar(100),
  @Phone varchar(20),
  @Email varchar(50)
) AS
BEGIN
    INSERT INTO Client(Name, Phone, Email)
    VALUES (@Name, @Phone, @Email);

    SET @ClientID = SCOPE_IDENTITY();
END
GO

DECLARE @ClientID int;

EXEC CreateClient
  @ClientID output,
  'Cameron',
  '07561101169',
  'cmcc1003@gmail.com'

SELECT @ClientID 
GO