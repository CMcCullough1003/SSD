using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStore;


namespace DataStoreTest
{
    /*
    Use[AssemblyInitialize] to run code once per assembly, before any test in that assembly runs.
    Use[WaitingListInitialize] to run code once per waitingList, before any test in the waitingList where the method is defined.
    Use[TestInitialize] to run code before each and every test in the waitingList where the method is defined.
    */

    [TestClass]
    public class WaitingListTableTest
    {
        private int dogId = 0;
        private int clientId = 0;
        private int programTypeId = 0;

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
        }

        [TestMethod]
        public void Count_AllRecordsDeleted_0()
        {
            //Assemble
            int expected = 0;
            WaitingListTable waitingListTable = new WaitingListTable();

            //Act
            int actual = waitingListTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Create_ValidData_WaitingListIDReturned()
        {
            //Assemble
            WaitingListModel waitingListModel = new WaitingListModel();
            waitingListModel.clientId = clientId;
            waitingListModel.dogId = dogId;
            waitingListModel.programTypeId = programTypeId;
            waitingListModel.joinDate = new DateTime(2003, 01, 06);
            waitingListModel.inviteIssued = false;
            //If created will be greater than 0, but we don't know exactly what it will be because deleting all records doesnt set the ID counter back to 0
            int notCreated = 0;
            WaitingListTable waitingListTable = new WaitingListTable();

            //Act
            int actual = waitingListTable.create(waitingListModel);

            //Assert
            Assert.AreNotEqual(notCreated, actual);
        }

        [TestMethod]
        public void Count_Created1Record_1()
        {
            //Assemble
            WaitingListModel waitingListModel = new WaitingListModel();
            waitingListModel.clientId = clientId;
            waitingListModel.dogId = dogId;
            waitingListModel.programTypeId = programTypeId;
            waitingListModel.joinDate = new DateTime(2003, 01, 06);
            waitingListModel.inviteIssued = false;
            int expected = 1;
            WaitingListTable waitingListTable = new WaitingListTable();

            //Act
            int waitingListID = waitingListTable.create(waitingListModel);
            int actual = waitingListTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Read_CreatedAndRead1Record_CorrectValues()
        {
            //Assemble
            WaitingListModel waitingListModel = new WaitingListModel();
            waitingListModel.clientId = clientId;
            waitingListModel.dogId = dogId;
            waitingListModel.programTypeId = programTypeId;
            waitingListModel.joinDate = new DateTime(2003, 01, 06);
            waitingListModel.inviteIssued = false;
            WaitingListTable waitingListTable = new WaitingListTable();

            //Act
            int waitingListID = waitingListTable.create(waitingListModel);
            WaitingListModel actual = waitingListTable.read(waitingListID);

            //Assert
            Assert.AreEqual(waitingListModel.dogId, actual.dogId);
            Assert.AreEqual(waitingListModel.programTypeId, actual.programTypeId);
            Assert.AreEqual(waitingListModel.joinDate, actual.joinDate);
            Assert.AreEqual(waitingListModel.inviteIssued, actual.inviteIssued);
        }

        [TestMethod]
        public void ReadAll_Create3Records_CountIs3()
        {
            //Assemble
            WaitingListModel waitingListModel1 = new WaitingListModel();
            waitingListModel1.clientId = clientId;
            waitingListModel1.dogId = dogId;
            waitingListModel1.programTypeId = programTypeId;
            waitingListModel1.joinDate = new DateTime(2003, 01, 06);
            waitingListModel1.inviteIssued = false;

            WaitingListModel waitingListModel2 = new WaitingListModel();
            waitingListModel2.clientId = clientId;
            waitingListModel2.dogId = dogId;
            waitingListModel2.programTypeId = programTypeId;
            waitingListModel2.joinDate = new DateTime(2003, 01, 06);
            waitingListModel2.inviteIssued = false;

            WaitingListModel waitingListModel3 = new WaitingListModel();
            waitingListModel3.clientId = clientId;
            waitingListModel3.dogId = dogId;
            waitingListModel3.programTypeId = programTypeId;
            waitingListModel3.joinDate = new DateTime(2003, 01, 06);
            waitingListModel3.inviteIssued = false;

            WaitingListTable waitingListTable = new WaitingListTable();
            int expected = 3;

            //Act
            int waitingListID1 = waitingListTable.create(waitingListModel1);
            int waitingListID2 = waitingListTable.create(waitingListModel2);
            int waitingListID3 = waitingListTable.create(waitingListModel3);
            List<WaitingListModel> actual = waitingListTable.readAll();

            //Assert
            Assert.AreEqual(expected, actual.Count);
        }

        [TestMethod]
        public void ReadAll_Create3Records_3DifferentRecords()
        {
            //Assemble
            WaitingListModel waitingListModel1 = new WaitingListModel();
            waitingListModel1.clientId = clientId;
            waitingListModel1.dogId = dogId;
            waitingListModel1.programTypeId = programTypeId;
            waitingListModel1.joinDate = new DateTime(2003, 01, 06);
            waitingListModel1.inviteIssued = false;

            WaitingListModel waitingListModel2 = new WaitingListModel();
            waitingListModel2.clientId = clientId;
            waitingListModel2.dogId = dogId;
            waitingListModel2.programTypeId = programTypeId;
            waitingListModel2.joinDate = new DateTime(2003, 01, 06);
            waitingListModel2.inviteIssued = false;

            WaitingListModel waitingListModel3 = new WaitingListModel();
            waitingListModel3.clientId = clientId;
            waitingListModel3.dogId = dogId;
            waitingListModel3.programTypeId = programTypeId;
            waitingListModel3.joinDate = new DateTime(2003, 01, 06);
            waitingListModel3.inviteIssued = false;

            WaitingListTable waitingListTable = new WaitingListTable();

            //Act
            int waitingListID1 = waitingListTable.create(waitingListModel1);
            int waitingListID2 = waitingListTable.create(waitingListModel2);
            int waitingListID3 = waitingListTable.create(waitingListModel3);
            List<WaitingListModel> actual = waitingListTable.readAll();

            //Assert
            Assert.AreEqual(waitingListID1, waitingListID1);
            Assert.AreEqual(waitingListModel1.dogId, actual[0].dogId);
            Assert.AreEqual(waitingListModel1.programTypeId, actual[0].programTypeId);
            Assert.AreEqual(waitingListModel1.joinDate, actual[0].joinDate);
            Assert.AreEqual(waitingListModel1.inviteIssued, actual[0].inviteIssued);

            Assert.AreEqual(waitingListID2, waitingListID2);
            Assert.AreEqual(waitingListModel2.dogId, actual[1].dogId);
            Assert.AreEqual(waitingListModel2.programTypeId, actual[1].programTypeId);
            Assert.AreEqual(waitingListModel2.joinDate, actual[1].joinDate);
            Assert.AreEqual(waitingListModel2.inviteIssued, actual[1].inviteIssued);

            Assert.AreEqual(waitingListID3, waitingListID3);
            Assert.AreEqual(waitingListModel3.dogId, actual[2].dogId);
            Assert.AreEqual(waitingListModel3.programTypeId, actual[2].programTypeId);
            Assert.AreEqual(waitingListModel3.joinDate, actual[2].joinDate);
            Assert.AreEqual(waitingListModel3.inviteIssued, actual[2].inviteIssued);
        }

        [TestMethod]
        public void Update_CreatedUpdateAndRead1Record_UpdatedValues()
        {
            //Assemble
            WaitingListModel waitingListModel = new WaitingListModel();
            waitingListModel.clientId = clientId;
            waitingListModel.dogId = dogId;
            waitingListModel.programTypeId = programTypeId;
            waitingListModel.joinDate = new DateTime(2003, 01, 06);
            waitingListModel.inviteIssued = false;
            WaitingListTable waitingListTable = new WaitingListTable();
            int waitingListID = waitingListTable.create(waitingListModel);
            waitingListModel.id = waitingListID;
            waitingListModel.clientId = clientId;
            waitingListModel.dogId = dogId;
            waitingListModel.programTypeId = programTypeId;
            waitingListModel.joinDate = new DateTime(2003, 01, 06);
            waitingListModel.inviteIssued = false;

            //Act
            waitingListTable.update(waitingListModel);
            WaitingListModel actual = waitingListTable.read(waitingListID);

            //Assert
            Assert.AreEqual(waitingListModel.clientId, actual.clientId);
            Assert.AreEqual(waitingListModel.dogId, actual.dogId);
            Assert.AreEqual(waitingListModel.programTypeId, actual.programTypeId);
            Assert.AreEqual(waitingListModel.joinDate, actual.joinDate);
            Assert.AreEqual(waitingListModel.inviteIssued, actual.inviteIssued);
        }
                                                           
        [TestMethod]
        public void Delete_CreatedDeleteAndCount1Record_0()
        {
            //Assemble
            WaitingListModel waitingListModel = new WaitingListModel();
            waitingListModel.clientId = clientId;
            waitingListModel.dogId = dogId;
            waitingListModel.programTypeId = programTypeId;
            waitingListModel.joinDate = new DateTime(2003, 01, 06);
            waitingListModel.inviteIssued = false;
            int expected = 0;
            WaitingListTable waitingListTable = new WaitingListTable();
            int waitingListID = waitingListTable.create(waitingListModel);

            //Act
            waitingListTable.delete(waitingListID);
            int actual = waitingListTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Delete_NonExistantId_0()
        {
            //Assemble
            WaitingListTable waitingListTable = new WaitingListTable();
            int expected = 0;

            //Act
            waitingListTable.delete(0);
            int actual = waitingListTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

