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
            new DataStoreHelper().clearAllTables();
        }


        [TestMethod]
        public void CreateNewClient_ValidData_ClientIDReturned()
        {
            //Assemble
            ClientModel clientModel = new ClientModel();
            clientModel.name = "Bob";
            clientModel.phone = "07561 101169";
            clientModel.email = "bob@gmail.com";
            int expected = 1;
            ClientTable clientTable = new ClientTable();

            //Act
            int actual = clientTable.createNewClient(clientModel);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

