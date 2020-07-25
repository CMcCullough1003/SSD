USE [Dogs]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

DROP PROC DeleteClientAll;
DROP PROC CountClient;
DROP PROC DeleteClientByID;
DROP PROC UpdateClientByID;
DROP PROC ReadClientByID;
DROP PROC CreateClient;
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


CREATE PROC ReadClientByID(
  @ClientID int
) AS
BEGIN
	SELECT * FROM Client
	WHERE ClientID = @ClientID
END
GO


CREATE PROC UpdateClientByID(
	@ClientID int,
	@Name varchar(100),
	@Phone varchar(20),
	@Email varchar(50)
) AS
BEGIN
	UPDATE Client
	SET Name = @Name,
		Phone = @Phone,
		Email = @Email
	WHERE ClientID = @ClientID
END
GO


CREATE PROC DeleteClientByID (
	@ClientID int
) AS
BEGIN
	DELETE FROM Client
	WHERE ClientID = @ClientID
END
GO


CREATE PROC CountClient
AS
BEGIN
	SELECT * FROM Client
END
GO


CREATE PROC DeleteClientAll 
AS
BEGIN
	DELETE FROM Client
END
GO


/* Executing Stored Procedures */

DECLARE @ClientID int;

EXEC CreateClient
  @ClientID output,
  'Bob',
  '07561 465879',
  'bob@gmail.com'

SELECT @ClientID 

EXEC ReadClientByID @ClientID

EXEC UpdateClientByID @ClientID, 'Katie', '07561 101169', 'katie@gamil.com'

EXEC ReadClientByID @ClientID

EXEC DeleteClientByID @ClientID

EXEC ReadClientByID @ClientID
GO

EXEC CountClient
GO
