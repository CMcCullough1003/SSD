using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStore;


namespace DataStoreTest
{
    /*
    Use[AssemblyInitialize] to run code once per assembly, before any test in that assembly runs.
    Use[PaymentInitialize] to run code once per payment, before any test in the payment where the method is defined.
    Use[TestInitialize] to run code before each and every test in the payment where the method is defined.
    */

    [TestClass]
    public class PaymentTableTest
    {
        private int enrollmentId = 0;
        private int dogId = 0;
        private int clientId = 0;
        private int programVarietyId = 0;
        private int programId = 0;

        [TestInitialize]
        public void Setup()
        {
            new DataStoreTableHelper().clearAllTables();

            ClientModel clientModel = new ClientModel();
            clientModel.name = "Bob";
            clientModel.phone = "1234567890";
            clientModel.email = "A@B.com";

            ClientTable clientTable = new ClientTable();
            clientId = clientTable.create(clientModel);

            DogModel dogModel = new DogModel();
            dogModel.clientID = clientId;
            dogModel.name = "Dog";
            dogModel.age = 6;
            dogModel.breed = "Terrier";
            dogModel.experienceOrQualification = false;

            DogTable dogTable = new DogTable();
            dogId = dogTable.create(dogModel);

            ProgramVarietyModel programeVarietyModel = new ProgramVarietyModel();
            programeVarietyModel.depositAmount = 20.0;
            programeVarietyModel.sessionCost = 20.0;
            programeVarietyModel.fullPaymentPercentageDiscount = 20;
            programeVarietyModel.name = "Regular";
            programeVarietyModel.dogSpacesMaximum = 50;
            programeVarietyModel.noOfClasses = 50;

            ProgramVarietyTable programVarietyTable = new ProgramVarietyTable();
            programVarietyId = programVarietyTable.create(programeVarietyModel);

            ProgramModel programModel = new ProgramModel();
            programModel.programVarietyId = programVarietyId;


            ProgramTable programTable = new ProgramTable();
            programId = programTable.create(programModel);

            EnrollmentModel enrollmentModel = new EnrollmentModel();
            enrollmentModel.name = "A";
            enrollmentModel.clientId = clientId;
            enrollmentModel.dogId = dogId;
            enrollmentModel.programId = programId;
            enrollmentModel.paymentMethod = 1;
            enrollmentModel.joinDate = new DateTime(2021, 01, 03);
            enrollmentModel.inviteIssued = true;

            EnrollmentTable enrollmentTable = new EnrollmentTable();
            enrollmentId = enrollmentTable.create(enrollmentModel);
        }

        [TestMethod]
        public void Count_AllRecordsDeleted_0()
        {
            //Assemble
            int expected = 0;
            PaymentTable paymentTable = new PaymentTable();

            //Act
            int actual = paymentTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Create_ValidData_PaymentIDReturned()
        {
            //Assemble
            PaymentModel paymentModel = new PaymentModel();
            paymentModel.enrollmentId = enrollmentId;
            paymentModel.paymentAmountDue = 20.0;
            paymentModel.paymentAmountDueDate = new DateTime(2021, 01, 01);
            paymentModel.paymentRecieved = true;
            paymentModel.paymentRecievedDate = new DateTime(2021, 01, 01);
            paymentModel.recieptIssued = true;
            //If created will be greater than 0, but we don't know exactly what it will be because deleting all records doesnt set the ID counter back to 0
            int notCreated = 0;
            PaymentTable paymentTable = new PaymentTable();

            //Act
            int actual = paymentTable.create(paymentModel);

            //Assert
            Assert.AreNotEqual(notCreated, actual);
        }

        [TestMethod]
        public void Count_Created1Record_1()
        {
            //Assemble
            PaymentModel paymentModel = new PaymentModel();
            paymentModel.enrollmentId = enrollmentId;
            paymentModel.paymentAmountDue = 20;
            paymentModel.paymentAmountDueDate = new DateTime(2021, 01, 01);
            paymentModel.paymentRecieved = true;
            paymentModel.paymentRecievedDate = new DateTime(2021, 01, 01);
            paymentModel.recieptIssued = true;
            int expected = 1;
            PaymentTable paymentTable = new PaymentTable();

            //Act
            int paymentID = paymentTable.create(paymentModel);
            int actual = paymentTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Read_CreatedAndRead1Record_CorrectValues()
        {
            //Assemble
            PaymentModel paymentModel = new PaymentModel();
            paymentModel.enrollmentId = enrollmentId;
            paymentModel.paymentAmountDue = 20;
            paymentModel.paymentAmountDueDate = new DateTime(2021, 01, 01);
            paymentModel.paymentRecieved = true;
            paymentModel.paymentRecievedDate = new DateTime(2021, 01, 01);
            paymentModel.recieptIssued = true;
            PaymentTable paymentTable = new PaymentTable();

            //Act
            int paymentID = paymentTable.create(paymentModel);
            PaymentModel actual = paymentTable.read(paymentID);

            //Assert
            Assert.AreEqual(paymentModel.enrollmentId, actual.enrollmentId);
            Assert.AreEqual(paymentModel.paymentAmountDue, actual.paymentAmountDue);
            Assert.AreEqual(paymentModel.paymentAmountDueDate, actual.paymentAmountDueDate);
            Assert.AreEqual(paymentModel.paymentRecieved, actual.paymentRecieved);
            Assert.AreEqual(paymentModel.paymentRecievedDate, actual.paymentRecievedDate);
            Assert.AreEqual(paymentModel.recieptIssued, actual.recieptIssued);
        }

        [TestMethod]
        public void ReadAll_Create3Records_CountIs3()
        {
            //Assemble
            PaymentModel paymentModel1 = new PaymentModel();
            paymentModel1.enrollmentId = enrollmentId;
            paymentModel1.paymentAmountDue = 20;
            paymentModel1.paymentAmountDueDate = new DateTime(2021, 01, 01);
            paymentModel1.paymentRecieved = true;
            paymentModel1.paymentRecievedDate = new DateTime(2021, 01, 01);
            paymentModel1.recieptIssued = true;

            PaymentModel paymentModel2 = new PaymentModel();
            paymentModel2.enrollmentId = enrollmentId;
            paymentModel2.paymentAmountDue = 20;
            paymentModel2.paymentAmountDueDate = new DateTime(2021, 01, 01);
            paymentModel2.paymentRecieved = true;
            paymentModel2.paymentRecievedDate = new DateTime(2021, 01, 01);
            paymentModel2.recieptIssued = true;

            PaymentModel paymentModel3 = new PaymentModel();
            paymentModel3.enrollmentId = enrollmentId;
            paymentModel3.paymentAmountDue = 20;
            paymentModel3.paymentAmountDueDate = new DateTime(2021, 01, 01);
            paymentModel3.paymentRecieved = true;
            paymentModel3.paymentRecievedDate = new DateTime(2021, 01, 01);
            paymentModel3.recieptIssued = true;

            PaymentTable paymentTable = new PaymentTable();
            int expected = 3;

            //Act
            int paymentID1 = paymentTable.create(paymentModel1);
            int paymentID2 = paymentTable.create(paymentModel2);
            int paymentID3 = paymentTable.create(paymentModel3);
            List<PaymentModel> actual = paymentTable.readAll();

            //Assert
            Assert.AreEqual(expected, actual.Count);
        }

        [TestMethod]
        public void ReadAll_Create3Records_3DifferentRecords()
        {
            //Assemble
            PaymentModel paymentModel1 = new PaymentModel();
            paymentModel1.enrollmentId = enrollmentId;
            paymentModel1.paymentAmountDue = 20;
            paymentModel1.paymentAmountDueDate = new DateTime(2021, 01, 01);
            paymentModel1.paymentRecieved = true;
            paymentModel1.paymentRecievedDate = new DateTime(2021, 01, 01);
            paymentModel1.recieptIssued = true;

            PaymentModel paymentModel2 = new PaymentModel();
            paymentModel2.enrollmentId = enrollmentId;
            paymentModel2.paymentAmountDue = 20;
            paymentModel2.paymentAmountDueDate = new DateTime(2021, 01, 01);
            paymentModel2.paymentRecieved = true;
            paymentModel2.paymentRecievedDate = new DateTime(2021, 01, 01);
            paymentModel2.recieptIssued = true;

            PaymentModel paymentModel3 = new PaymentModel();
            paymentModel3.enrollmentId = enrollmentId;
            paymentModel3.paymentAmountDue = 20;
            paymentModel3.paymentAmountDueDate = new DateTime(2021, 01, 01);
            paymentModel3.paymentRecieved = true;
            paymentModel3.paymentRecievedDate = new DateTime(2021, 01, 01);
            paymentModel3.recieptIssued = true;

            PaymentTable paymentTable = new PaymentTable();

            //Act
            int paymentID1 = paymentTable.create(paymentModel1);
            int paymentID2 = paymentTable.create(paymentModel2);
            int paymentID3 = paymentTable.create(paymentModel3);
            List<PaymentModel> actual = paymentTable.readAll();

            //Assert
            Assert.AreEqual(paymentID1, paymentID1);
            Assert.AreEqual(paymentModel1.enrollmentId, actual[0].enrollmentId);
            Assert.AreEqual(paymentModel1.paymentAmountDue, actual[0].paymentAmountDue);
            Assert.AreEqual(paymentModel1.paymentAmountDueDate, actual[0].paymentAmountDueDate);
            Assert.AreEqual(paymentModel1.paymentRecieved, actual[0].paymentRecieved);
            Assert.AreEqual(paymentModel1.paymentRecievedDate, actual[0].paymentRecievedDate);
            Assert.AreEqual(paymentModel1.recieptIssued, actual[0].recieptIssued);

            Assert.AreEqual(paymentID2, paymentID2);
            Assert.AreEqual(paymentModel2.enrollmentId, actual[1].enrollmentId);
            Assert.AreEqual(paymentModel2.paymentAmountDue, actual[1].paymentAmountDue);
            Assert.AreEqual(paymentModel2.paymentAmountDueDate, actual[1].paymentAmountDueDate);
            Assert.AreEqual(paymentModel2.paymentRecieved, actual[1].paymentRecieved);
            Assert.AreEqual(paymentModel2.paymentRecievedDate, actual[1].paymentRecievedDate);
            Assert.AreEqual(paymentModel2.recieptIssued, actual[1].recieptIssued);

            Assert.AreEqual(paymentID3, paymentID3);
            Assert.AreEqual(paymentModel3.enrollmentId, actual[2].enrollmentId);
            Assert.AreEqual(paymentModel3.paymentAmountDue, actual[2].paymentAmountDue);
            Assert.AreEqual(paymentModel3.paymentAmountDueDate, actual[2].paymentAmountDueDate);
            Assert.AreEqual(paymentModel3.paymentRecieved, actual[2].paymentRecieved);
            Assert.AreEqual(paymentModel3.paymentRecievedDate, actual[2].paymentRecievedDate);
            Assert.AreEqual(paymentModel3.recieptIssued, actual[2].recieptIssued);
        }

        [TestMethod]
        public void Update_CreatedUpdateAndRead1Record_UpdatedValues()
        {
            //Assemble
            PaymentModel paymentModel = new PaymentModel();
            paymentModel.enrollmentId = enrollmentId;
            paymentModel.paymentAmountDue = 20;
            paymentModel.paymentAmountDueDate = new DateTime(2021, 01, 01);
            paymentModel.paymentRecieved = true;
            paymentModel.paymentRecievedDate = new DateTime(2021, 01, 01);
            paymentModel.recieptIssued = true;
            PaymentTable paymentTable = new PaymentTable();
            int paymentID = paymentTable.create(paymentModel);
            paymentModel.id = paymentID;
            paymentModel.enrollmentId = enrollmentId;
            paymentModel.paymentAmountDue = 20;
            paymentModel.paymentAmountDueDate = new DateTime(2021, 01, 01);
            paymentModel.paymentRecieved = true;
            paymentModel.paymentRecievedDate = new DateTime(2021, 01, 01);
            paymentModel.recieptIssued = true;

            //Act
            paymentTable.update(paymentModel);
            PaymentModel actual = paymentTable.read(paymentID);

            //Assert
            Assert.AreEqual(paymentModel.enrollmentId, actual.enrollmentId);
            Assert.AreEqual(paymentModel.paymentAmountDue, actual.paymentAmountDue);
            Assert.AreEqual(paymentModel.paymentAmountDueDate, actual.paymentAmountDueDate);
            Assert.AreEqual(paymentModel.paymentRecieved, actual.paymentRecieved);
            Assert.AreEqual(paymentModel.paymentRecievedDate, actual.paymentRecievedDate);
            Assert.AreEqual(paymentModel.recieptIssued, actual.recieptIssued);
        }

        [TestMethod]
        public void Delete_CreatedDeleteAndCount1Record_0()
        {
            //Assemble
            PaymentModel paymentModel = new PaymentModel();
            paymentModel.enrollmentId = enrollmentId;
            paymentModel.paymentAmountDue = 20;
            paymentModel.paymentAmountDueDate = new DateTime(2021, 01, 01);
            paymentModel.paymentRecieved = true;
            paymentModel.paymentRecievedDate = new DateTime(2021, 01, 01);
            paymentModel.recieptIssued = true;
            int expected = 0;
            PaymentTable paymentTable = new PaymentTable();
            int paymentID = paymentTable.create(paymentModel);

            //Act
            paymentTable.delete(paymentID);
            int actual = paymentTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Delete_NonExistantId_0()
        {
            //Assemble
            PaymentTable paymentTable = new PaymentTable();
            int expected = 0;

            //Act
            paymentTable.delete(0);
            int actual = paymentTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

