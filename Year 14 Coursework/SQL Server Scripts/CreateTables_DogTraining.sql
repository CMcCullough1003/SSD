/*This script creates all the tables for the dog training database*/

/*Specifies which database is being used*/
USE [Dogs]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*Drop all tables
  Have to be dropped in this order because tables with foreign keys must be 
  deleted before the table from which the foreign key comes from
*/
DROP TABLE WaitingList;
DROP TABLE Payment;
DROP TABLE Enrollment;
DROP TABLE Class;
DROP TABLE Program;
DROP TABLE ProgramVariety;
DROP TABLE Staff;
DROP TABLE Dog;
DROP TABLE Client;

/*Create all the tables
  Have to be created in this order so that the tables that use foreign keys are later
*/
CREATE TABLE Client (
	ClientID int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(100) CHECK (Len(Name) >= 3) NOT NULL,
	Phone varchar(20) CHECK (Len(Phone) >= 10),
	Email varchar(50) CHECK (Len(Email) >= 7),
	CHECK (Phone IS NOT NULL OR Email IS NOT NULL)
)

CREATE TABLE Dog (
	DogID int IDENTITY(1,1) PRIMARY KEY,
	ClientID int FOREIGN KEY REFERENCES Client(ClientID),
	Name varchar(100) NOT NULL,
	Age int NOT NULL,
	Breed varchar(100) NOT NULL,
	ExperienceOrQualification bit DEFAULT 0 NOT NULL
)

CREATE TABLE Staff (
	StaffID int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(100) CHECK (Len(Name) >= 3) NOT NULL
) 

CREATE TABLE ProgramVariety (
	ProgramVarietyID int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(20) CHECK (Name in ('Regular','Advanced')) NOT NULL,
	DepositAmount float CHECK (DepositAmount >= 20.0 AND DepositAmount <= 100.0) NOT NULL,
	SessionCost float CHECK (SessionCost >= 20.0 AND SessionCost <= 100.0) NOT NULL,
	FullPaymentPercentageDiscount float CHECK (FullPaymentPercentageDiscount >= 0.0 AND FullPaymentPercentageDiscount <= 100.0) NOT NULL
) 

CREATE TABLE Program (
	ProgramID int IDENTITY(1,1) PRIMARY KEY,
	Name text NOT NULL,
	/*ProgramTypeID int FOREIGN KEY REFERENCES ProgramType(ProgramTypeID),*/
	ProgramVarietyID int FOREIGN KEY REFERENCES ProgramVariety(ProgramVarietyID),
	DogSpacesMaximum int CHECK (DogSpacesMaximum >= 1 AND DogSpacesMaximum <= 100) NOT NULL,
	NoOfClasses int CHECK (NoOfClasses >= 1 AND NoOfClasses <= 100) NOT NULL
)

CREATE TABLE Class (
	ClassID int IDENTITY(1,1) PRIMARY KEY,
	ProgramID int FOREIGN KEY REFERENCES Program(ProgramID),
	StaffID int FOREIGN KEY REFERENCES Staff(StaffID),
	ClassDate date CHECK (ClassDate >= GetDate()) NOT NULL,
	StartTime time NOT NULL,
	EndTime time NOT NULL,
	CONSTRAINT CK__Class__Times CHECK (EndTime > StartTime)
)

CREATE TABLE Enrollment (
	EnrollmentID int IDENTITY(1,1) PRIMARY KEY,
	Name text NOT NULL,
	ClientID int FOREIGN KEY REFERENCES Client(ClientID),
	DogID int FOREIGN KEY REFERENCES Dog(DogID),
	ProgramID int FOREIGN KEY REFERENCES Program(ProgramID),
	PaymentMethod int CHECK (PaymentMethod >=1 AND PaymentMethod <= 2) NOT NULL,
	JoinDate dateTime DEFAULT GetDate() NOT NULL,
	InviteIssued bit DEFAULT 0 NOT NULL
)

CREATE TABLE Payment (
	PaymentID int IDENTITY(1,1) PRIMARY KEY,
	EnrollmentID int FOREIGN KEY REFERENCES Enrollment(EnrollmentID),
	PaymentType text NOT NULL,
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
	ProgramVarietyID int FOREIGN KEY REFERENCES ProgramVariety(ProgramVarietyID),
	JoinDate dateTime DEFAULT GetDate() NOT NULL,
	InviteIssued bit DEFAULT 0 NOT NULL
)
