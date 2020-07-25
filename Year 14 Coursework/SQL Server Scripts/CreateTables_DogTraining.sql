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
	Name varchar(100) CHECK (Len(Name) >= 3) NOT NULL,
	Phone varchar(20) CHECK (Len(Phone) >= 10),
	Email varchar(50) CHECK (Len(Email) >= 7),
	CHECK (Phone IS NOT NULL OR Email IS NOT NULL)
)

CREATE TABLE Dog (
	DogID int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(100) NOT NULL,
	RegularQualificationAchieved bit DEFAULT 0 NOT NULL,
	ExperienceForAdvancedProgram bit DEFAULT 0 NOT NULL,
	Experience text DEFAULT '' NOT NULL
)

CREATE TABLE Staff (
	StaffID int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(100) CHECK (Len(Name) >= 3) NOT NULL
) 

CREATE TABLE ProgramType (
	ProgramTypeID int IDENTITY(1,1) PRIMARY KEY,
	Description varchar(20) CHECK (Description in ('Regular','Advanced')) NOT NULL
)

CREATE TABLE ProgramCost (
	ProgramCostID int IDENTITY(1,1) PRIMARY KEY,
	DepositAmount float CHECK (DepositAmount >= 20.0 AND DepositAmount <= 100.0) NOT NULL,
	SessionCost float CHECK (SessionCost >= 20.0 AND SessionCost <= 100.0) NOT NULL,
	FullPaymentPercentageDiscount float CHECK (FullPaymentPercentageDiscount >= 0 AND FullPaymentPercentageDiscount <= 100) NOT NULL
) 

CREATE TABLE Program (
	ProgramID int IDENTITY(1,1) PRIMARY KEY,
	ProgramTypeID int FOREIGN KEY REFERENCES ProgramType(ProgramTypeID),
	ProgramCostID int FOREIGN KEY REFERENCES ProgramCost(ProgramCostID),
	DogSpacesMaximum int CHECK (DogSpacesMaximum >= 1 AND DogSpacesMaximum <= 100) NOT NULL,
	NoOfClasses int CHECK (NoOfClasses >= 1 AND NoOfClasses <= 100) NOT NULL
)

CREATE TABLE Class (
	ClassID int IDENTITY(1,1) PRIMARY KEY,
	ProgramID int FOREIGN KEY REFERENCES Program(ProgramID),
	StaffID int FOREIGN KEY REFERENCES Staff(StaffID),
	ClassDate date CHECK (ClassDate >= GetDate()) NOT NULL,
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
	PaymentAmountDue float CHECK (PaymentAmountDue >= 0.0) NOT NULL,
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
