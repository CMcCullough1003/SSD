/*This script creates all the stored procedures for the client table*/

/*Specifies which database is being used*/
USE [Dogs]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*Drop all stored procedures*/
DROP PROC ReadClients;
DROP PROC DeleteClientAll;
DROP PROC CountClients;
DROP PROC DeleteClientByID;
DROP PROC UpdateClientByID;
DROP PROC ReadClientByID;
DROP PROC CreateClient;
GO

/*Stored Procedures:
  Name: Createclient
  Purpose: new record in table 
  Parameters: data required to create new record 
  Return: ID of new record
  
  Name: ReadclientByID
  Purpose: Read the record in the table with the specified ID
  Parameters: ID
  Return: A cursor with one record

  Name: Readclients
  Purpose: Read all the records in the table
  Parameters: None
  Return: A cursor with multiple records

  Name: UpdateclientByID
  Purpose: Update the record in the table with the specified ID
  Parameters: ID and updated values
  Return: None

  Name: DeleteclientByID
  Purpose: Delete the record in the table with the specified ID
  Parameters: ID
  Return: None

  Name: DeleteclientAll
  Purpose: Delete all the records in the table
  Parameters: None
  Return: None

  Name: Countclient
  Purpose: Count the number of records in the table
  Parameters: None
  Return: Cursor with one row and one column
*/

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

CREATE PROC ReadClients
AS
BEGIN
	Select * FROM Client
END
GO


/* Testing Stored Procedures 

DECLARE @ClientID int;

EXEC CreateClient
  @ClientID output,
  'Bob',
  '07561 465879',
  'bob@gmail.com'

SELECT @ClientID 

EXEC ReadClientByID @ClientID

EXEC ReadClients

EXEC UpdateClientByID @ClientID, 'Katie', '07561 101169', 'katie@gamil.com'

EXEC ReadClientByID @ClientID

EXEC DeleteClientByID @ClientID

EXEC ReadClientByID @ClientID
GO

*/
