USE [Dogs]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

DROP TABLE WaitingList;
DROP TABLE Payment;
DROP TABLE Enrollment;
DROP TABLE ClientDog;
DROP TABLE Class;
DROP TABLE Program;
DROP TABLE ProgramCost;
DROP TABLE ProgramType;
DROP TABLE Staff;
DROP TABLE Dog;
DROP TABLE Client;

CREATE TABLE Client (
	ClientID int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(100) NOT NULL,
	Phone varchar(20),
	Email varchar(50)
)

CREATE TABLE Dog (
	DogID int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(100) NOT NULL,
	RegularQualificationAchieved bit DEFAULT 0 NOT NULL,
	ExperienceForAdvancedProgram bit DEFAULT 0 NOT NULL,
	Experience text
)

CREATE TABLE Staff (
	StaffID int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(100) NOT NULL
) 

CREATE TABLE ProgramType (
	ProgramTypeID int IDENTITY(1,1) PRIMARY KEY,
	Description varchar(20) NOT NULL
)

CREATE TABLE ProgramCost (
	ProgramCostID int IDENTITY(1,1) PRIMARY KEY,
	DepositAmount float NOT NULL,
	SessionCost float NOT NULL,
	FullPaymnetPercentageDiscount float NOT NULL
) 

CREATE TABLE Program (
	ProgramID int IDENTITY(1,1) PRIMARY KEY,
	ProgramTypeID int FOREIGN KEY REFERENCES ProgramType(ProgramTypeID),
	ProgramCostID int FOREIGN KEY REFERENCES ProgramCost(ProgramCostID),
	DogSpacesMaximum int NOT NULL,
	NoOfClasses int NOT NULL
)

CREATE TABLE Class (
	ClassID int IDENTITY(1,1) PRIMARY KEY,
	ProgramID int FOREIGN KEY REFERENCES Program(ProgramID),
	StaffID int FOREIGN KEY REFERENCES Staff(StaffID),
	Date date NOT NULL,
	StartTime time NOT NULL,
	EndTime time NOT NULL
)


CREATE TABLE ClientDog (
	ClientID int FOREIGN KEY REFERENCES Client(ClientID),
	DogID int FOREIGN KEY REFERENCES Dog(DogID)
)	


CREATE TABLE Enrollment (
	EnrollmentID int IDENTITY(1,1) PRIMARY KEY,
	ClientID int FOREIGN KEY REFERENCES Client(ClientID),
	DogID int FOREIGN KEY REFERENCES Dog(DogID),
	ProgramID int FOREIGN KEY REFERENCES Program(ProgramID)
)

CREATE TABLE Payment (
	PaymentID int IDENTITY(1,1) PRIMARY KEY,
	EnrollmentID int FOREIGN KEY REFERENCES Enrollment(EnrollmentID),
	PaymentAmountDue float NOT NULL,
	PaymentAmountDueDate date NOT NULL,
	PaymentRecieved bit DEFAULT 0 NOT NULL,
	PaymentRecievedDate date,
	RecieptIssued bit DEFAULT 0 NOT NULL
)

CREATE TABLE WaitingList (
	WaitingListID int IDENTITY(1,1) PRIMARY KEY,
	ClientID int FOREIGN KEY REFERENCES Client(ClientID),
	DogID int FOREIGN KEY REFERENCES Dog(DogID),
	ProgramTypeID int FOREIGN KEY REFERENCES ProgramType(ProgramTypeID),
	JoinDate dateTime DEFAULT GetDate() NOT NULL,
	InviteIssued bit DEFAULT 0 NOT NULL
)
