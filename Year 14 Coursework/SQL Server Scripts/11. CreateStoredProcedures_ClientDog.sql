USE [Dogs]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

DROP PROC ReadClientDog;
DROP PROC DeleteClientDogAll;
DROP PROC CountClientDog;
DROP PROC DeleteClientDogByDogID;
DROP PROC ReadClientDogByDogID;
DROP PROC ReadClientDogByClientID;
DROP PROC CreateClientDog;
GO


CREATE PROC CreateClientDog(
  @ClientID int,
  @DogID int
) AS
BEGIN
    INSERT INTO ClientDog(ClientID, DogID)
    VALUES (@ClientID, @DogID);
END
GO


CREATE PROC ReadClientDogByClientID(
  @ClientID int
) AS
BEGIN
	SELECT * FROM ClientDog
	WHERE ClientID = @ClientID
END
GO


CREATE PROC ReadClientDogByDogID(
  @DogID int
) AS
BEGIN
	SELECT * FROM ClientDog
	WHERE DogID = @DogID
END
GO


CREATE PROC DeleteClientDogByDogID (
	@DogID int
) AS
BEGIN
	DELETE FROM ClientDog
	WHERE DogID = @DogID
END
GO


CREATE PROC CountClientDog
AS
BEGIN
	SELECT * FROM ClientDog
END
GO


CREATE PROC DeleteClientDogAll 
AS
BEGIN
	DELETE FROM ClientDog
END
GO


CREATE PROC ReadClientDog
AS
BEGIN
	Select * FROM ClientDog
END
GO

/* Executing Stored Procedures */

DECLARE @ClientID int;
DECLARE @DogID int;

EXEC CreateClientDog
  21, 2 

EXEC ReadClientDogByClientID @ClientID

EXEC ReadClientDog

EXEC ReadClientDogByClientID @ClientID

EXEC DeleteClientDogByDogID @DogID

EXEC ReadClientDogByClientID @ClientID

EXEC CountClientDog
GO