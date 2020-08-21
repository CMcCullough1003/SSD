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
    public class ClientTableTest
    {
        [TestInitialize]
        public void deleteAll()
        {
            new DataStoreTableHelper().clearAllTables();
        }

        [TestMethod]
        public void Count_AllRecordsDeleted_0()
        {
            //Assemble
            int expected = 0;
            ClientTable clientTable = new ClientTable();

            //Act
            int actual = clientTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Create_ValidData_ClientIDReturned()
        {
            //Assemble
            ClientModel clientModel = new ClientModel();
            clientModel.name = "Bob";
            clientModel.phone = "07561 101169";
            clientModel.email = "bob@gmail.com";
            int notCreated = 0;
            ClientTable clientTable = new ClientTable();

            //Act
            int actual = clientTable.create(clientModel);

            //Assert
            Assert.AreNotEqual(notCreated, actual);
        }

        [TestMethod]
        public void Count_Created1Record_1()
        {
            //Assemble
            ClientModel clientModel = new ClientModel();
            clientModel.name = "Bob";
            clientModel.phone = "07561 101169";
            clientModel.email = "bob@gmail.com";
            int expected = 1;
            ClientTable clientTable = new ClientTable();

            //Act
            int clientID = clientTable.create(clientModel);
            int actual = clientTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Read_CreatedAndRead1Record_CorrectValues()
        {
            //Assemble
            ClientModel clientModel = new ClientModel();
            clientModel.name = "Bob";
            clientModel.phone = "07561 101169";
            clientModel.email = "bob@gmail.com";
            ClientTable clientTable = new ClientTable();

            //Act
            int clientID = clientTable.create(clientModel);
            ClientModel actual = clientTable.read(clientID);

            //Assert
            Assert.AreEqual(clientModel.name, actual.name);
            Assert.AreEqual(clientModel.phone, actual.phone);
            Assert.AreEqual(clientModel.email, actual.email);
        }

        [TestMethod]
        public void ReadAll_Create3Records_CountIs3()
        {
            //Assemble
            ClientModel clientModel1 = new ClientModel();
            clientModel1.name = "Bob";
            clientModel1.phone = "07561 101169";
            clientModel1.email = "bob@gmail.com";

            ClientModel clientModel2 = new ClientModel();
            clientModel2.name = "Bob2";
            clientModel2.phone = "07561 101169";
            clientModel2.email = "bob@gmail.com";

            ClientModel clientModel3 = new ClientModel();
            clientModel3.name = "Bob3";
            clientModel3.phone = "07561 101169";
            clientModel3.email = "bob@gmail.com";

            ClientTable clientTable = new ClientTable();
            int expected = 3;

            //Act
            int clientID1 = clientTable.create(clientModel1);
            int clientID2 = clientTable.create(clientModel2);
            int clientID3 = clientTable.create(clientModel3);
            List<ClientModel> actual = clientTable.readAll();

            //Assert
            Assert.AreEqual(expected, actual.Count);
        }

        [TestMethod]
        public void ReadAll_Create3Records_3DifferentRecords()
        {
            //Assemble
            ClientModel clientModel1 = new ClientModel();
            clientModel1.name = "name1";
            clientModel1.phone = "07561 101169";
            clientModel1.email = "email1@x.com";

            ClientModel clientModel2 = new ClientModel();
            clientModel2.name = "name2";
            clientModel2.phone = "07561 101170";
            clientModel2.email = "email2@x.com";

            ClientModel clientModel3 = new ClientModel();
            clientModel3.name = "name3";
            clientModel3.phone = "07561 101171";
            clientModel3.email = "email3@x.com";

            ClientTable clientTable = new ClientTable();

            //Act
            int clientID1 = clientTable.create(clientModel1);
            int clientID2 = clientTable.create(clientModel2);
            int clientID3 = clientTable.create(clientModel3);
            List<ClientModel> actual = clientTable.readAll();

            //Assert
            Assert.AreEqual(clientID1, clientID1);
            Assert.AreEqual(clientModel1.name, actual[0].name);
            Assert.AreEqual(clientModel1.phone, actual[0].phone);
            Assert.AreEqual(clientModel1.email, actual[0].email);

            Assert.AreEqual(clientID2, clientID2);
            Assert.AreEqual(clientModel2.name, actual[1].name);
            Assert.AreEqual(clientModel2.phone, actual[1].phone);
            Assert.AreEqual(clientModel2.email, actual[1].email);

            Assert.AreEqual(clientID3, clientID3);
            Assert.AreEqual(clientModel3.name, actual[2].name);
            Assert.AreEqual(clientModel3.phone, actual[2].phone);
            Assert.AreEqual(clientModel3.email, actual[2].email);
        }

        [TestMethod]
        public void Update_CreatedUpdateAndRead1Record_UpdatedValues()
        {
            //Assemble
            ClientModel clientModel = new ClientModel();
            clientModel.name = "Bob";
            clientModel.phone = "07561 101169";
            clientModel.email = "bob@gmail.com";
            ClientTable clientTable = new ClientTable();
            int clientID = clientTable.create(clientModel);
            clientModel.id = clientID;
            clientModel.name = "Kate";
            clientModel.phone = "07561 101170";
            clientModel.email = "kate@gmail.com";

            //Act
            clientTable.update(clientModel);
            ClientModel actual = clientTable.read(clientID);

            //Assert
            Assert.AreEqual(clientModel.name, actual.name);
            Assert.AreEqual(clientModel.phone, actual.phone);
            Assert.AreEqual(clientModel.email, actual.email);
        }

        [TestMethod]
        public void Delete_CreatedDeleteAndCount1Record_0()
        {
            //Assemble
            ClientModel clientModel = new ClientModel();
            clientModel.name = "Bob";
            clientModel.phone = "07561 101169";
            clientModel.email = "bob@gmail.com";
            int expected = 0;
            ClientTable clientTable = new ClientTable();
            int clientID = clientTable.create(clientModel);

            //Act
            clientTable.delete(clientID);
            int actual = clientTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Delete_NonExistantId_0()
        {
            //Assemble
            ClientTable clientTable = new ClientTable();
            int expected = 0;

            //Act
            clientTable.delete(0);
            int actual = clientTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreateNameConstraint_NameLengthTooShort_Exception()
        {
            //Assemble
            ClientTable clientTable = new ClientTable();
            ClientModel clientModel = new ClientModel();
            clientModel.name = "Bo";
            clientModel.phone = "07561 101169";
            clientModel.email = "bob@gmail.com";
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = clientTable.create(clientModel);
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
            ClientTable clientTable = new ClientTable();
            ClientModel clientModel = new ClientModel();
            clientModel.name = "Bob";
            clientModel.phone = "07561 101169";
            clientModel.email = "bob@gmail.com";
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = clientTable.create(clientModel);
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
            ClientTable clientTable = new ClientTable();
            ClientModel clientModel = new ClientModel();
            clientModel.name = "Bob";
            clientModel.phone = "123456789";
            clientModel.email = "bob@gmail.com";
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = clientTable.create(clientModel);
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
            ClientTable clientTable = new ClientTable();
            ClientModel clientModel = new ClientModel();
            clientModel.name = "Bob";
            clientModel.phone = "1234567890";
            clientModel.email = "bob@gmail.com";
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = clientTable.create(clientModel);
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
            ClientTable clientTable = new ClientTable();
            ClientModel clientModel = new ClientModel();
            clientModel.name = "Bob";
            clientModel.phone = "1234567890";
            clientModel.email = "a@b.co";
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = clientTable.create(clientModel);
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
            ClientTable clientTable = new ClientTable();
            ClientModel clientModel = new ClientModel();
            clientModel.name = "Bob";
            clientModel.phone = "1234567890";
            clientModel.email = "a@b.com";
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = clientTable.create(clientModel);
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

