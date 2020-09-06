/*This script creates all the stored procedures for the payment table*/

/*Specifies which database is being used*/
USE [Dogs]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*Drop all stored procedures*/
DROP PROC ReadPayment;
DROP PROC DeletePaymentAll;
DROP PROC CountPayment;
DROP PROC DeletePaymentByID;
DROP PROC UpdatePaymentByID;
DROP PROC ReadPaymentByID;
DROP PROC CreatePayment;
GO

/*Stored Procedures:
  Name: Createpayment
  Purpose: new record in table 
  Parameters: data required to create new record 
  Return: ID of new record
  
  Name: ReadpaymentByID
  Purpose: Read the record in the table with the specified ID
  Parameters: ID
  Return: A cursor with one record

  Name: Readpayments
  Purpose: Read all the records in the table
  Parameters: None
  Return: A cursor with multiple records

  Name: UpdatepaymentByID
  Purpose: Update the record in the table with the specified ID
  Parameters: ID and updated values
  Return: None

  Name: DeletepaymentByID
  Purpose: Delete the record in the table with the specified ID
  Parameters: ID
  Return: None

  Name: DeletepaymentAll
  Purpose: Delete all the records in the table
  Parameters: None
  Return: None

  Name: Countpayment
  Purpose: Count the number of records in the table
  Parameters: None
  Return: Cursor with one row and one column
*/

CREATE PROC CreatePayment(
  @PaymentID int output,
  @EnrollmentID int,
  @PaymentAmountDue float,
  @PaymentAmountDueDate date,
  @PaymentRecieved bit,
  @PaymentRecievedDate date,
  @RecieptIssued bit
) AS
BEGIN
    INSERT INTO Payment(EnrollmentID, PaymentAmountDue, PaymentAmountDueDate, PaymentRecieved, PaymentRecievedDate, RecieptIssued)
    VALUES (@EnrollmentID, @PaymentAmountDue, @PaymentAmountDueDate, @PaymentRecieved, @PaymentRecievedDate, @RecieptIssued);

    SET @PaymentID = SCOPE_IDENTITY();
END
GO


CREATE PROC ReadPaymentByID(
  @PaymentID int
) AS
BEGIN
	SELECT * FROM Payment
	WHERE PaymentID = @PaymentID
END
GO


CREATE PROC UpdatePaymentByID(
	@PaymentID int,
	@EnrollmentID int,
	@PaymentAmountDue float,
	@PaymentAmountDueDate date,
    @PaymentRecieved bit,
	@PaymentRecievedDate date,
	@RecieptIssued bit
) AS
BEGIN
	UPDATE Payment
	SET EnrollmentID = @EnrollmentID,
		PaymentAmountDue = @PaymentAmountDue,
		PaymentAmountDueDate = @PaymentAmountDueDate,
		PaymentRecieved = @PaymentRecieved,
		PaymentRecievedDate = @PaymentRecievedDate,
		RecieptIssued = @RecieptIssued
	WHERE PaymentID = @PaymentID
END
GO


CREATE PROC DeletePaymentByID (
	@PaymentID int
) AS
BEGIN
	DELETE FROM Payment
	WHERE PaymentID = @PaymentID
END
GO


CREATE PROC CountPayment
AS
BEGIN
	SELECT COUNT(*) FROM Payment
END
GO


CREATE PROC DeletePaymentAll 
AS
BEGIN
	DELETE FROM Payment
END
GO

CREATE PROC ReadPayment
AS
BEGIN
	Select * FROM Payment
END
GO


/* Testing Stored Procedures 

DECLARE @PaymentID int;
DECLARE @PaymentDueDate Date
DECLARE @PaymentRecievedDate Date
SET @PaymentDueDate = CONVERT(DATE, '2021-08-15')
SET @PaymentRecievedDate = CONVERT(DATE, '2021-08-15')

EXEC CreatePayment
  @PaymentID output,
  1, 60.00, @PaymentDueDate, 1, @PaymentRecievedDate, 1

SELECT @PaymentID 

EXEC ReadPaymentByID @PaymentID

EXEC ReadPayment

EXEC UpdatePaymentByID @PaymentID,  1, 60.00, @PaymentDueDate, 1, @PaymentRecievedDate, 1

EXEC ReadPaymentByID @PaymentID

EXEC DeletePaymentByID @PaymentID

EXEC ReadPaymentByID @PaymentID
GO

EXEC CountPayment
GO

*/