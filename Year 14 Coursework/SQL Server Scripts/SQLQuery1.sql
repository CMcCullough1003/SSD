CREATE TABLE Staff (
	StaffID int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(100) NOT NULL
)

CREATE TABLE ProgramType (
	ProgramTypeID int IDENTITY(1,1) PRIMARY KEY,
	Description varchar(20) NOT NULL
)

CREATE TABLE Program (
	ProgramID int IDENTITY(1,1) PRIMARY KEY,
	ProgramTypeID int FOREIGN KEY REFERENCES ProgramType(ProgramTypeID),
	DogSpacesMaximum int NOT NULL
)

CREATE TABLE Class (
	ClassID int IDENTITY(1,1) PRIMARY KEY,
	ProgramID int FOREIGN KEY REFERENCES Program(ProgramID),
	StaffID int FOREIGN KEY REFERENCES Staff(StaffID),
	Date date NOT NULL,
	StartTime time NOT NULL,
	EndTime time NOT NULL
)

CREATE TABLE Client (
	ClientID int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(100) NOT NULL,
	Phone varchar(20),
	Email varchar(50)
)

CREATE TABLE Dog (
	DogID int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(100) NOT NULL,
	RegualarQualificationAchieved bit NOT NULL,
	Experience text
)

CREATE TABLE ClientDog (
	ClientID int FOREIGN KEY REFERENCES Client(ClientID),
	DogID int FOREIGN KEY REFERENCES Dog(DogID)
)
	

CREATE TABLE Payment (
	PaymentID int IDENTITY(1,1) PRIMARY KEY
)

CREATE TABLE ProgramCost (
	ProgramCostID int IDENTITY(1,1) PRIMARY KEY
)  

CREATE TABLE Enrollment (
	EnrollmentID int IDENTITY(1,1) PRIMARY KEY,
	ClientID int FOREIGN KEY REFERENCES Client(ClientID),
	DogID int FOREIGN KEY REFERENCES Dog(DogID),
	ProgramID int FOREIGN KEY REFERENCES Program(ProgramID),
	
)