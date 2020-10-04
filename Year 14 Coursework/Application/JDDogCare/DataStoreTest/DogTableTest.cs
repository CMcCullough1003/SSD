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
        public void deleteAll()
        {
            new DataStoreTableHelper().clearAllTables();

            ClientModel clientModel = new ClientModel();
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
            dogModel.name = "Bob";
            dogModel.phone = "07561 101169";
            dogModel.email = "bob@gmail.com";
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
            dogModel.name = "Bob";
            dogModel.phone = "07561 101169";
            dogModel.email = "bob@gmail.com";
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
            dogModel.name = "Bob";
            dogModel.phone = "07561 101169";
            dogModel.email = "bob@gmail.com";
            DogTable dogTable = new DogTable();

            //Act
            int dogID = dogTable.create(dogModel);
            DogModel actual = dogTable.read(dogID);

            //Assert
            Assert.AreEqual(dogModel.name, actual.name);
            Assert.AreEqual(dogModel.phone, actual.phone);
            Assert.AreEqual(dogModel.email, actual.email);
        }

        [TestMethod]
        public void ReadAll_Create3Records_CountIs3()
        {
            //Assemble
            DogModel dogModel1 = new DogModel();
            dogModel1.name = "Bob";
            dogModel1.phone = "07561 101169";
            dogModel1.email = "bob@gmail.com";

            DogModel dogModel2 = new DogModel();
            dogModel2.name = "Bob2";
            dogModel2.phone = "07561 101169";
            dogModel2.email = "bob@gmail.com";

            DogModel dogModel3 = new DogModel();
            dogModel3.name = "Bob3";
            dogModel3.phone = "07561 101169";
            dogModel3.email = "bob@gmail.com";

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
            dogModel1.name = "name1";
            dogModel1.phone = "07561 101169";
            dogModel1.email = "email1@x.com";

            DogModel dogModel2 = new DogModel();
            dogModel2.name = "name2";
            dogModel2.phone = "07561 101170";
            dogModel2.email = "email2@x.com";

            DogModel dogModel3 = new DogModel();
            dogModel3.name = "name3";
            dogModel3.phone = "07561 101171";
            dogModel3.email = "email3@x.com";

            DogTable dogTable = new DogTable();

            //Act
            int dogID1 = dogTable.create(dogModel1);
            int dogID2 = dogTable.create(dogModel2);
            int dogID3 = dogTable.create(dogModel3);
            List<DogModel> actual = dogTable.readAll();

            //Assert
            Assert.AreEqual(dogID1, dogID1);
            Assert.AreEqual(dogModel1.name, actual[0].name);
            Assert.AreEqual(dogModel1.phone, actual[0].phone);
            Assert.AreEqual(dogModel1.email, actual[0].email);

            Assert.AreEqual(dogID2, dogID2);
            Assert.AreEqual(dogModel2.name, actual[1].name);
            Assert.AreEqual(dogModel2.phone, actual[1].phone);
            Assert.AreEqual(dogModel2.email, actual[1].email);

            Assert.AreEqual(dogID3, dogID3);
            Assert.AreEqual(dogModel3.name, actual[2].name);
            Assert.AreEqual(dogModel3.phone, actual[2].phone);
            Assert.AreEqual(dogModel3.email, actual[2].email);
        }

        [TestMethod]
        public void Update_CreatedUpdateAndRead1Record_UpdatedValues()
        {
            //Assemble
            DogModel dogModel = new DogModel();
            dogModel.name = "Bob";
            dogModel.phone = "07561 101169";
            dogModel.email = "bob@gmail.com";
            DogTable dogTable = new DogTable();
            int dogID = dogTable.create(dogModel);
            dogModel.id = dogID;
            dogModel.name = "Kate";
            dogModel.phone = "07561 101170";
            dogModel.email = "kate@gmail.com";

            //Act
            dogTable.update(dogModel);
            DogModel actual = dogTable.read(dogID);

            //Assert
            Assert.AreEqual(dogModel.name, actual.name);
            Assert.AreEqual(dogModel.phone, actual.phone);
            Assert.AreEqual(dogModel.email, actual.email);
        }

        [TestMethod]
        public void Delete_CreatedDeleteAndCount1Record_0()
        {
            //Assemble
            DogModel dogModel = new DogModel();
            dogModel.name = "Bob";
            dogModel.phone = "07561 101169";
            dogModel.email = "bob@gmail.com";
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

        [TestMethod]
        public void CreateNameConstraint_NameLengthTooShort_Exception()
        {
            //Assemble
            DogTable dogTable = new DogTable();
            DogModel dogModel = new DogModel();
            dogModel.name = "Bo";
            dogModel.phone = "07561 101169";
            dogModel.email = "bob@gmail.com";
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = dogTable.create(dogModel);
            }
            catch (Exception ex)
            {
                counter++;
            }

            //Assert
            Assert.AreEqual(expected, counter);
        }

        [TestMethod]
        public void CreateNameConstraint_NameLengthOk_NoException()
        {
            //Assemble
            DogTable dogTable = new DogTable();
            DogModel dogModel = new DogModel();
            dogModel.name = "Bob";
            dogModel.phone = "07561 101169";
            dogModel.email = "bob@gmail.com";
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = dogTable.create(dogModel);
                counter++;
            }
            catch (Exception ex)
            {

            }

            //Assert
            Assert.AreEqual(expected, counter);
        }

        [TestMethod]
        public void CreatePhoneConstraint_PhoneLengthTooShort_Exception()
        {
            //Assemble
            DogTable dogTable = new DogTable();
            DogModel dogModel = new DogModel();
            dogModel.name = "Bob";
            dogModel.phone = "123456789";
            dogModel.email = "bob@gmail.com";
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = dogTable.create(dogModel);
            }
            catch (Exception ex)
            {
                counter++;
            }

            //Assert
            Assert.AreEqual(expected, counter);
        }

        [TestMethod]
        public void CreatePhoneConstraint_PhoneLengthOk_NoException()
        {
            //Assemble
            DogTable dogTable = new DogTable();
            DogModel dogModel = new DogModel();
            dogModel.name = "Bob";
            dogModel.phone = "1234567890";
            dogModel.email = "bob@gmail.com";
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = dogTable.create(dogModel);
                counter++;
            }
            catch (Exception ex)
            {

            }

            //Assert
            Assert.AreEqual(expected, counter);
        }

        [TestMethod]
        public void CreateEmailConstraint_EmailLengthTooShort_Exception()
        {
            //Assemble
            DogTable dogTable = new DogTable();
            DogModel dogModel = new DogModel();
            dogModel.name = "Bob";
            dogModel.phone = "1234567890";
            dogModel.email = "a@b.co";
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = dogTable.create(dogModel);
            }
            catch (Exception ex)
            {
                counter++;
            }

            //Assert
            Assert.AreEqual(expected, counter);
        }

        [TestMethod]
        public void CreateEmailConstraint_EmailLengthOk_NoException()
        {
            //Assemble
            DogTable dogTable = new DogTable();
            DogModel dogModel = new DogModel();
            dogModel.name = "Bob";
            dogModel.phone = "1234567890";
            dogModel.email = "a@b.com";
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = dogTable.create(dogModel);
                counter++;
            }
            catch (Exception ex)
            {

            }

            //Assert
            Assert.AreEqual(expected, counter);
        }
    }
}

