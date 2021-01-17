USE [Dogs]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

DROP PROC ScheduleReport;
DROP PROC AttendeesReport;
DROP PROC BillingReport;
DROP PROC EnrollmentReport;
DROP PROC ProgramReport;
GO

CREATE PROC ScheduleReport
AS
BEGIN
	SELECT ClassID
	, CLassDate
	, StartTime
	, EndTime
	, ProgramVariety.ProgramVarietyID
	, ProgramVariety.Name AS ProgramVarietyName
	, Program.ProgramID
	, Program.Name AS ProgramName
	, Staff.StaffID
	, Staff.Name AS StaffName
	FROM Class
	INNER JOIN Staff ON Staff.StaffID = Class.StaffID
	INNER JOIN Program ON Program.ProgramID = Class.ProgramID
	INNER JOIN ProgramVariety ON ProgramVariety.ProgramVarietyID = Program.ProgramVarietyID
	ORDER BY ClassDate, StartTime;
END
GO

CREATE PROC AttendeesReport(
  @ProgramID int
)
AS
BEGIN
	SELECT Client.DisplayName
	, Dog.Name
	FROM Enrollment
	INNER JOIN Client ON Client.ClientID = Enrollment.ClientID
	INNER JOIN Dog ON Dog.DogID = Enrollment.DogID
	WHERE Enrollment.ProgramID = @ProgramID
END

GO

CREATE PROC BillingReport
AS
BEGIN
	SELECT Payment.PaymentID
	, Client.DisplayName AS ClientName
	, Payment.PaymentType
	, Payment.PaymentAmountDue AS AmountDue
	, Payment.PaymentAmountDueDate AS DueDate
	, DATEDIFF(day, Payment.PaymentAmountDueDate, GetDate())
	, Payment.PaymentRecieved
	, Program.ProgramID
	, Program.Name AS ProgramName
	FROM Payment
	INNER JOIN Enrollment ON Payment.EnrollmentID = Enrollment.EnrollmentID
	INNER JOIN Client ON Enrollment.ClientID = Client.ClientID
	INNER JOIN Program ON Enrollment.ProgramID = Program.ProgramID
	WHERE PaymentAmountDueDate < GetDate()
	ORDER BY PaymentAmountDueDate;
END
GO

CREATE PROC EnrollmentReport
AS
BEGIN
	SELECT Program.Name AS ProgramName
	, ProgramVariety.Name AS ProgramVarietyName
	, (SELECT MIN(ClassDate) FROM Class WHERE Class.ProgramID = Program.ProgramID) AS FirstClassDate
	, (SELECT Count(*) FROM Enrollment WHERE Enrollment.ProgramID = Program.ProgramID) AS NumberEnrolled
	, ProgramVariety.DogSpacesMaximum AS MaxSpaces
	, (DogSpacesMaximum - (SELECT Count(*) FROM Enrollment WHERE Enrollment.ProgramID = Program.ProgramID)) AS FreeSpaces
	FROM Program
	INNER JOIN ProgramVariety ON Program.ProgramVarietyID = ProgramVariety.ProgramVarietyID
	WHERE (SELECT Count(*) FROM Enrollment WHERE Enrollment.ProgramID = Program.ProgramID) != DogSpacesMaximum
END
GO

CREATE PROC ProgramReport
AS
BEGIN
	SELECT Program.Name AS ProgramName
	, ProgramVariety.Name AS ProgramVariety
	, ProgramVariety.NoOfClasses
	, (SELECT Count(*) FROM Class WHERE Class.ProgramID = Program.ProgramID) AS NumberOfClassesArranged
	, ProgramVariety.NoOfClasses - (SELECT Count(*) FROM Class WHERE Class.ProgramID = Program.ProgramID) AS MissingClasses
	FROM Program
	INNER JOIN ProgramVariety ON Program.ProgramVarietyID = ProgramVariety.ProgramVarietyID
	WHERE (SELECT Count(*) FROM Class WHERE Class.ProgramID = Program.ProgramID) != NoOfClasses
END
GO
