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
        public void Count_CreatedAndRead1Record_CorrectValues()
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
    }
}

