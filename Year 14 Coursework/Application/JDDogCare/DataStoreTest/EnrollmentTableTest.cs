﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStore;


namespace DataStoreTest
{
    /*
    Use[AssemblyInitialize] to run code once per assembly, before any test in that assembly runs.
    Use[EnrollmentInitialize] to run code once per enrollment, before any test in the enrollment where the method is defined.
    Use[TestInitialize] to run code before each and every test in the enrollment where the method is defined.
    */

    [TestClass]
    public class EnrollmentTableTest
    {
        private int dogId = 0;
        private int clientId = 0;
        private int programTypeId = 0;
        private int programeCostId = 0;
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

            ProgramTypeModel programTypeModel = new ProgramTypeModel();
            programTypeModel.description = "Regular";

            ProgramTypeTable programTypeTable = new ProgramTypeTable();
            programTypeId = programTypeTable.create(programTypeModel);

            ProgramCostModel programeCostModel = new ProgramCostModel();
            programeCostModel.depositAmount = 20.0;
            programeCostModel.sessionCost = 20.0;
            programeCostModel.fullPaymentPercentageDiscount = 20;

            ProgramCostTable programCostTable = new ProgramCostTable();
            programeCostId = programCostTable.create(programeCostModel);

            ProgramModel programModel = new ProgramModel();
            programModel.programTypeId = programTypeId;
            programModel.programCostId = programeCostId;
            programModel.dogSpacesMaximum = 50;
            programModel.noOfClasses = 50;

            ProgramTable programTable = new ProgramTable();
            programId = programTable.create(programModel);
        }

        [TestMethod]
        public void Count_AllRecordsDeleted_0()
        {
            //Assemble
            int expected = 0;
            EnrollmentTable enrollmentTable = new EnrollmentTable();

            //Act
            int actual = enrollmentTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Create_ValidData_EnrollmentIDReturned()
        {
            //Assemble
            EnrollmentModel enrollmentModel = new EnrollmentModel();
            enrollmentModel.programId = programId;
            enrollmentModel.clientId = clientId;
            enrollmentModel.dogId = dogId;
            enrollmentModel.programId = programId;
            //If created will be greater than 0, but we don't know exactly what it will be because deleting all records doesnt set the ID counter back to 0
            int notCreated = 0;
            EnrollmentTable enrollmentTable = new EnrollmentTable();

            //Act
            int actual = enrollmentTable.create(enrollmentModel);

            //Assert
            Assert.AreNotEqual(notCreated, actual);
        }

        [TestMethod]
        public void Count_Created1Record_1()
        {
            //Assemble
            EnrollmentModel enrollmentModel = new EnrollmentModel();
            enrollmentModel.programId = programId;
            enrollmentModel.clientId = clientId;
            enrollmentModel.dogId = dogId;
            enrollmentModel.programId = programId;
            int expected = 1;
            EnrollmentTable enrollmentTable = new EnrollmentTable();

            //Act
            int enrollmentID = enrollmentTable.create(enrollmentModel);
            int actual = enrollmentTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Read_CreatedAndRead1Record_CorrectValues()
        {
            //Assemble
            EnrollmentModel enrollmentModel = new EnrollmentModel();
            enrollmentModel.programId = programId;
            enrollmentModel.clientId = clientId;
            enrollmentModel.dogId = dogId;
            enrollmentModel.programId = programId;
            EnrollmentTable enrollmentTable = new EnrollmentTable();

            //Act
            int enrollmentID = enrollmentTable.create(enrollmentModel);
            EnrollmentModel actual = enrollmentTable.read(enrollmentID);

            //Assert
            Assert.AreEqual(enrollmentModel.programId, actual.programId);
            Assert.AreEqual(enrollmentModel.clientId, actual.clientId);
            Assert.AreEqual(enrollmentModel.dogId, actual.dogId);
            Assert.AreEqual(enrollmentModel.programId, actual.programId);
        }
        
        [TestMethod]
        public void ReadAll_Create3Records_CountIs3()
        {
            //Assemble
            EnrollmentModel enrollmentModel1 = new EnrollmentModel();
            enrollmentModel1.programId = programId;
            enrollmentModel1.programId = programId;
            enrollmentModel1.clientId = clientId;
            enrollmentModel1.dogId = dogId;
            enrollmentModel1.programId = programId;

            EnrollmentModel enrollmentModel2 = new EnrollmentModel();
            enrollmentModel2.programId = programId;
            enrollmentModel2.programId = programId;
            enrollmentModel2.clientId = clientId;
            enrollmentModel2.dogId = dogId;
            enrollmentModel2.programId = programId;

            EnrollmentModel enrollmentModel3 = new EnrollmentModel();
            enrollmentModel3.programId = programId;
            enrollmentModel3.programId = programId;
            enrollmentModel3.clientId = clientId;
            enrollmentModel3.dogId = dogId;
            enrollmentModel3.programId = programId;

            EnrollmentTable enrollmentTable = new EnrollmentTable();
            int expected = 3;

            //Act
            int enrollmentID1 = enrollmentTable.create(enrollmentModel1);
            int enrollmentID2 = enrollmentTable.create(enrollmentModel2);
            int enrollmentID3 = enrollmentTable.create(enrollmentModel3);
            List<EnrollmentModel> actual = enrollmentTable.readAll();

            //Assert
            Assert.AreEqual(expected, actual.Count);
        }

        [TestMethod]
        public void ReadAll_Create3Records_3DifferentRecords()
        {
            //Assemble
            EnrollmentModel enrollmentModel1 = new EnrollmentModel();
            enrollmentModel1.programId = programId;
            enrollmentModel1.programId = programId;
            enrollmentModel1.clientId = clientId;
            enrollmentModel1.dogId = dogId;
            enrollmentModel1.programId = programId;

            EnrollmentModel enrollmentModel2 = new EnrollmentModel();
            enrollmentModel2.programId = programId;
            enrollmentModel2.programId = programId;
            enrollmentModel2.clientId = clientId;
            enrollmentModel2.dogId = dogId;
            enrollmentModel2.programId = programId;

            EnrollmentModel enrollmentModel3 = new EnrollmentModel();
            enrollmentModel3.programId = programId;
            enrollmentModel3.programId = programId;
            enrollmentModel3.clientId = clientId;
            enrollmentModel3.dogId = dogId;
            enrollmentModel3.programId = programId;

            EnrollmentTable enrollmentTable = new EnrollmentTable();

            //Act
            int enrollmentID1 = enrollmentTable.create(enrollmentModel1);
            int enrollmentID2 = enrollmentTable.create(enrollmentModel2);
            int enrollmentID3 = enrollmentTable.create(enrollmentModel3);
            List<EnrollmentModel> actual = enrollmentTable.readAll();

            //Assert
            Assert.AreEqual(enrollmentID1, enrollmentID1);
            Assert.AreEqual(enrollmentModel1.programId, actual[0].programId);
            Assert.AreEqual(enrollmentModel1.clientId, actual[0].clientId);
            Assert.AreEqual(enrollmentModel1.dogId, actual[0].dogId);
            Assert.AreEqual(enrollmentModel1.programId, actual[0].programId);

            Assert.AreEqual(enrollmentID2, enrollmentID2);
            Assert.AreEqual(enrollmentModel2.programId, actual[1].programId);
            Assert.AreEqual(enrollmentModel2.clientId, actual[1].clientId);
            Assert.AreEqual(enrollmentModel2.dogId, actual[1].dogId);
            Assert.AreEqual(enrollmentModel2.programId, actual[1].programId);

            Assert.AreEqual(enrollmentID3, enrollmentID3);
            Assert.AreEqual(enrollmentModel3.programId, actual[2].programId);
            Assert.AreEqual(enrollmentModel3.clientId, actual[2].clientId);
            Assert.AreEqual(enrollmentModel3.dogId, actual[2].dogId);
            Assert.AreEqual(enrollmentModel3.programId, actual[2].programId);
        }

        [TestMethod]
        public void Update_CreatedUpdateAndRead1Record_UpdatedValues()
        {
            //Assemble
            EnrollmentModel enrollmentModel = new EnrollmentModel();
            enrollmentModel.programId = programId;
            enrollmentModel.clientId = clientId;
            enrollmentModel.dogId = dogId;
            enrollmentModel.programId = programId;
            EnrollmentTable enrollmentTable = new EnrollmentTable();
            int enrollmentID = enrollmentTable.create(enrollmentModel);
            enrollmentModel.id = enrollmentID;
            enrollmentModel.programId = programId;
            enrollmentModel.clientId = clientId;
            enrollmentModel.dogId = dogId;
            enrollmentModel.programId = programId;

            //Act
            enrollmentTable.update(enrollmentModel);
            EnrollmentModel actual = enrollmentTable.read(enrollmentID);

            //Assert
            Assert.AreEqual(enrollmentModel.programId, actual.programId);
            Assert.AreEqual(enrollmentModel.clientId, actual.clientId);
            Assert.AreEqual(enrollmentModel.dogId, actual.dogId);
            Assert.AreEqual(enrollmentModel.programId, actual.programId);
        }

        [TestMethod]
        public void Delete_CreatedDeleteAndCount1Record_0()
        {
            //Assemble
            EnrollmentModel enrollmentModel = new EnrollmentModel();
            enrollmentModel.programId = programId;
            enrollmentModel.clientId = clientId;
            enrollmentModel.dogId = dogId;
            enrollmentModel.programId = programId;
            int expected = 0;
            EnrollmentTable enrollmentTable = new EnrollmentTable();
            int enrollmentID = enrollmentTable.create(enrollmentModel);

            //Act
            enrollmentTable.delete(enrollmentID);
            int actual = enrollmentTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Delete_NonExistantId_0()
        {
            //Assemble
            EnrollmentTable enrollmentTable = new EnrollmentTable();
            int expected = 0;

            //Act
            enrollmentTable.delete(0);
            int actual = enrollmentTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

