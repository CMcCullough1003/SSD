using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStore;


namespace DataStoreTest
{
    /*
    Use[AssemblyInitialize] to run code once per assembly, before any test in that assembly runs.
    Use[ClassInitialize] to run code once per class, before any test in the class where the method is defined.
    Use[TestInitialize] to run code before each and every test in the class where the method is defined.
    */

    [TestClass]
    public class DogTableTest
    {

        private int clientId = 0;

        [TestInitialize]
        public void Setup()
        {
            new DataStoreTableHelper().clearAllTables();

            ClientModel clientModel = new ClientModel();
            clientModel.displayName = "Barry Bonds";
            clientModel.phone = "1234567890";
            clientModel.email = "A@B.com";

            ClientTable clientTable = new ClientTable();
            clientId = clientTable.create(clientModel);
        }

        [TestMethod]
        public void Count_AllRecordsDeleted_0()
        {
            //Assemble
            int expected = 0;
            DogTable dogTable = new DogTable();

            //Act
            int actual = dogTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Create_ValidData_DogIDReturned()
        {
            //Assemble
            DogModel dogModel = new DogModel();
            dogModel.name = "Ted";
            dogModel.clientID = clientId;
            dogModel.age = 8;
            dogModel.breed = "Shi Tzu";
            dogModel.experienceOrQualification = false;
            //If created will be greater than 0, but we don't know exactly what it will be because deleting all records doesnt set the ID counter back to 0
            int notCreated = 0;
            DogTable dogTable = new DogTable();

            //Act
            int actual = dogTable.create(dogModel);

            //Assert
            Assert.AreNotEqual(notCreated, actual);
        }

        [TestMethod]
        public void Count_Created1Record_1()
        {
            //Assemble
            DogModel dogModel = new DogModel();
            dogModel.name = "Ted";
            dogModel.clientID = clientId;
            dogModel.age = 8;
            dogModel.breed = "Shi Tzu";
            dogModel.experienceOrQualification = false;
            int expected = 1;
            DogTable dogTable = new DogTable();

            //Act
            int dogID = dogTable.create(dogModel);
            int actual = dogTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Read_CreatedAndRead1Record_CorrectValues()
        {
            //Assemble
            DogModel dogModel = new DogModel();
            dogModel.name = "Ted";
            dogModel.clientID = clientId;
            dogModel.age = 8;
            dogModel.breed = "Shi Tzu";
            dogModel.experienceOrQualification = false;
            DogTable dogTable = new DogTable();

            //Act
            int dogID = dogTable.create(dogModel);
            DogModel actual = dogTable.read(dogID);

            //Assert
            Assert.AreEqual(dogModel.name, actual.name);
            Assert.AreEqual(dogModel.clientID, actual.clientID);
            Assert.AreEqual(dogModel.age, actual.age);
            Assert.AreEqual(dogModel.breed, actual.breed);
            Assert.AreEqual(dogModel.experienceOrQualification, actual.experienceOrQualification);
        }

        [TestMethod]
        public void ReadAll_Create3Records_CountIs3()
        {
            //Assemble
            DogModel dogModel1 = new DogModel();
            dogModel1.name = "Ted";
            dogModel1.clientID = clientId;
            dogModel1.age = 8;
            dogModel1.breed = "Shi Tzu";
            dogModel1.experienceOrQualification = false;

            DogModel dogModel2 = new DogModel();
            dogModel2.name = "Ted 2";
            dogModel2.clientID = clientId;
            dogModel2.age = 82;
            dogModel2.breed = "Shi Tzu 2";
            dogModel2.experienceOrQualification = true;

            DogModel dogModel3 = new DogModel();
            dogModel3.name = "Ted 3";
            dogModel3.clientID = clientId;
            dogModel3.age = 83;
            dogModel3.breed = "Shi Tzu 3";
            dogModel3.experienceOrQualification = false;

            DogTable dogTable = new DogTable();
            int expected = 3;

            //Act
            int dogID1 = dogTable.create(dogModel1);
            int dogID2 = dogTable.create(dogModel2);
            int dogID3 = dogTable.create(dogModel3);
            List<DogModel> actual = dogTable.readAll();

            //Assert
            Assert.AreEqual(expected, actual.Count);
        }

        [TestMethod]
        public void ReadAll_Create3Records_3DifferentRecords()
        {
            //Assemble
            DogModel dogModel1 = new DogModel();
            dogModel1.name = "Ted";
            dogModel1.clientID = clientId;
            dogModel1.age = 8;
            dogModel1.breed = "Shi Tzu";
            dogModel1.experienceOrQualification = false;

            DogModel dogModel2 = new DogModel();
            dogModel2.name = "Ted 2";
            dogModel2.clientID = clientId;
            dogModel2.age = 82;
            dogModel2.breed = "Shi Tzu 2";
            dogModel2.experienceOrQualification = true;

            DogModel dogModel3 = new DogModel();
            dogModel3.name = "Ted 3";
            dogModel3.clientID = clientId;
            dogModel3.age = 83;
            dogModel3.breed = "Shi Tzu 3";
            dogModel3.experienceOrQualification = false;

            DogTable dogTable = new DogTable();

            //Act
            int dogID1 = dogTable.create(dogModel1);
            int dogID2 = dogTable.create(dogModel2);
            int dogID3 = dogTable.create(dogModel3);
            List<DogModel> actual = dogTable.readAll();

            //Assert
            Assert.AreEqual(dogID1, dogID1);
            Assert.AreEqual(dogModel1.name, actual[0].name);
            Assert.AreEqual(dogModel1.clientID, actual[0].clientID);
            Assert.AreEqual(dogModel1.age, actual[0].age);
            Assert.AreEqual(dogModel1.breed, actual[0].breed);
            Assert.AreEqual(dogModel1.experienceOrQualification, actual[0].experienceOrQualification);

            Assert.AreEqual(dogID2, dogID2);
            Assert.AreEqual(dogModel2.name, actual[1].name);
            Assert.AreEqual(dogModel2.clientID, actual[1].clientID);
            Assert.AreEqual(dogModel2.age, actual[1].age);
            Assert.AreEqual(dogModel2.breed, actual[1].breed);
            Assert.AreEqual(dogModel2.experienceOrQualification, actual[1].experienceOrQualification);

            Assert.AreEqual(dogID3, dogID3);
            Assert.AreEqual(dogModel3.name, actual[2].name);
            Assert.AreEqual(dogModel3.clientID, actual[2].clientID);
            Assert.AreEqual(dogModel3.age, actual[2].age);
            Assert.AreEqual(dogModel3.breed, actual[2].breed);
            Assert.AreEqual(dogModel3.experienceOrQualification, actual[2].experienceOrQualification);
        }

        [TestMethod]
        public void Update_CreatedUpdateAndRead1Record_UpdatedValues()
        {
            //Assemble
            DogModel dogModel = new DogModel();
            dogModel.name = "Ted";
            dogModel.clientID = clientId;
            dogModel.age = 8;
            dogModel.breed = "Shi Tzu";
            dogModel.experienceOrQualification = false;
            DogTable dogTable = new DogTable();
            int dogID = dogTable.create(dogModel);
            dogModel.id = dogID;
            dogModel.clientID = clientId;
            dogModel.name = "Coco";
            dogModel.age = 17;
            dogModel.breed = "Yorkshire Terrier";
            dogModel.experienceOrQualification = true;

            //Act
            dogTable.update(dogModel);
            DogModel actual = dogTable.read(dogID);

            //Assert
            Assert.AreEqual(dogModel.name, actual.name);
            Assert.AreEqual(dogModel.clientID, actual.clientID);
            Assert.AreEqual(dogModel.age, actual.age);
            Assert.AreEqual(dogModel.breed, actual.breed);
            Assert.AreEqual(dogModel.experienceOrQualification, actual.experienceOrQualification);
        }

        [TestMethod]
        public void Delete_CreatedDeleteAndCount1Record_0()
        {
            //Assemble
            DogModel dogModel = new DogModel();
            dogModel.name = "Ted";
            dogModel.clientID = clientId;
            dogModel.age = 8;
            dogModel.breed = "Shi Tzu";
            dogModel.experienceOrQualification = false;
            int expected = 0;
            DogTable dogTable = new DogTable();
            int dogID = dogTable.create(dogModel);

            //Act
            dogTable.delete(dogID);
            int actual = dogTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Delete_NonExistantId_0()
        {
            //Assemble
            DogTable dogTable = new DogTable();
            int expected = 0;

            //Act
            dogTable.delete(0);
            int actual = dogTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

