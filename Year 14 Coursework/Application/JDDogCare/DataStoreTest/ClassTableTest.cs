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

/*    [TestClass]
    public class ClassTableTest
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
            ClassTable classTable = new ClassTable();

            //Act
            int actual = classTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Create_ValidData_ClientIDReturned()
        {
            //Assemble
            ClassModel classModel = new ClassModel();
            classModel.name = "Bob";
            classModel.phone = "07561 101169";
            classModel.email = "bob@gmail.com";
            int notCreated = 0;
            ClassTable classTable = new ClassTable();

            //Act
            int actual = classTable.create(classModel);

            //Assert
            Assert.AreNotEqual(notCreated, actual);
        }

       [TestMethod]
        public void Count_Created1Record_1()
        {
            //Assemble
            ClassModel classModel = new ClassModel();
            classModel.name = "Bob";
            classModel.phone = "07561 101169";
            classModel.email = "bob@gmail.com";
            int expected = 1;
            ClassTable classTable = new ClassTable();

            //Act
            int clientID = classTable.create(classModel);
            int actual = classTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Read_CreatedAndRead1Record_CorrectValues()
        {
            //Assemble
            ClassModel classModel = new ClassModel();
            classModel.name = "Bob";
            classModel.phone = "07561 101169";
            classModel.email = "bob@gmail.com";
            ClassTable classTable = new ClassTable();

            //Act
            int clientID = classTable.create(classModel);
            ClassModel actual = classTable.read(clientID);

            //Assert
            Assert.AreEqual(classModel.name, actual.name);
            Assert.AreEqual(classModel.phone, actual.phone);
            Assert.AreEqual(classModel.email, actual.email);
        }

        [TestMethod]
        public void ReadAll_Create3Records_CountIs3()
        {
            //Assemble
            ClassModel classModel1 = new ClassModel();
            classModel1.name = "Bob";
            classModel1.phone = "07561 101169";
            classModel1.email = "bob@gmail.com";

            ClassModel classModel2 = new ClassModel();
            classModel2.name = "Bob2";
            classModel2.phone = "07561 101169";
            classModel2.email = "bob@gmail.com";

            ClassModel classModel3 = new ClassModel();
            classModel3.name = "Bob3";
            classModel3.phone = "07561 101169";
            classModel3.email = "bob@gmail.com";

            ClassTable classTable = new ClassTable();
            int expected = 3;

            //Act
            int clientID1 = classTable.create(classModel1);
            int clientID2 = classTable.create(classModel2);
            int clientID3 = classTable.create(classModel3);
            List<ClassModel> actual = classTable.readAll();

            //Assert
            Assert.AreEqual(expected, actual.Count);
        }

        [TestMethod]
        public void ReadAll_Create3Records_3DifferentRecords()
        {
            //Assemble
            ClassModel classModel1 = new ClassModel();
            classModel1.name = "name1";
            classModel1.phone = "07561 101169";
            classModel1.email = "email1@x.com";

            ClassModel classModel2 = new ClassModel();
            classModel2.name = "name2";
            classModel2.phone = "07561 101170";
            classModel2.email = "email2@x.com";

            ClassModel classModel3 = new ClassModel();
            classModel3.name = "name3";
            classModel3.phone = "07561 101171";
            classModel3.email = "email3@x.com";

            ClassTable classTable = new ClassTable();

            //Act
            int clientID1 = classTable.create(classModel1);
            int clientID2 = classTable.create(classModel2);
            int clientID3 = classTable.create(classModel3);
            List<ClassModel> actual = classTable.readAll();

            //Assert
            Assert.AreEqual(clientID1, clientID1);
            Assert.AreEqual(classModel1.name, actual[0].name);
            Assert.AreEqual(classModel1.phone, actual[0].phone);
            Assert.AreEqual(classModel1.email, actual[0].email);

            Assert.AreEqual(clientID2, clientID2);
            Assert.AreEqual(classModel2.name, actual[1].name);
            Assert.AreEqual(classModel2.phone, actual[1].phone);
            Assert.AreEqual(classModel2.email, actual[1].email);

            Assert.AreEqual(clientID3, clientID3);
            Assert.AreEqual(classModel3.name, actual[2].name);
            Assert.AreEqual(classModel3.phone, actual[2].phone);
            Assert.AreEqual(classModel3.email, actual[2].email);
        }

        [TestMethod]
        public void Update_CreatedUpdateAndRead1Record_UpdatedValues()
        {
            //Assemble
            ClassModel classModel = new ClassModel();
            classModel.name = "Bob";
            classModel.phone = "07561 101169";
            classModel.email = "bob@gmail.com";
            ClassTable classTable = new ClassTable();
            int clientID = classTable.create(classModel);
            classModel.id = clientID;
            classModel.name = "Kate";
            classModel.phone = "07561 101170";
            classModel.email = "kate@gmail.com";

            //Act
            classTable.update(classModel);
            ClassModel actual = classTable.read(clientID);

            //Assert
            Assert.AreEqual(classModel.name, actual.name);
            Assert.AreEqual(classModel.phone, actual.phone);
            Assert.AreEqual(classModel.email, actual.email);
        }

        [TestMethod]
        public void Delete_CreatedDeleteAndCount1Record_0()
        {
            //Assemble
            ClassModel classModel = new ClassModel();
            classModel.name = "Bob";
            classModel.phone = "07561 101169";
            classModel.email = "bob@gmail.com";
            int expected = 0;
            ClassTable classTable = new ClassTable();
            int clientID = classTable.create(classModel);

            //Act
            classTable.delete(clientID);
            int actual = classTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Delete_NonExistantId_0()
        {
            //Assemble
            ClassTable classTable = new ClassTable();
            int expected = 0;

            //Act
            classTable.delete(0);
            int actual = classTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreateNameConstraint_NameLengthTooShort_Exception()
        {
            //Assemble
            ClassTable classTable = new ClassTable();
            ClassModel classModel = new ClassModel();
            classModel.name = "Bo";
            classModel.phone = "07561 101169";
            classModel.email = "bob@gmail.com";
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = classTable.create(classModel);
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
            ClassTable classTable = new ClassTable();
            ClassModel classModel = new ClassModel();
            classModel.name = "Bob";
            classModel.phone = "07561 101169";
            classModel.email = "bob@gmail.com";
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = classTable.create(classModel);
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
            ClassTable classTable = new ClassTable();
            ClassModel classModel = new ClassModel();
            classModel.name = "Bob";
            classModel.phone = "123456789";
            classModel.email = "bob@gmail.com";
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = classTable.create(classModel);
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
            ClassTable classTable = new ClassTable();
            ClassModel classModel = new ClassModel();
            classModel.name = "Bob";
            classModel.phone = "1234567890";
            classModel.email = "bob@gmail.com";
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = classTable.create(classModel);
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
            ClassTable classTable = new ClassTable();
            ClassModel classModel = new ClassModel();
            classModel.name = "Bob";
            classModel.phone = "1234567890";
            classModel.email = "a@b.co";
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = classTable.create(classModel);
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
            ClassTable classTable = new ClassTable();
            ClassModel classModel = new ClassModel();
            classModel.name = "Bob";
            classModel.phone = "1234567890";
            classModel.email = "a@b.com";
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = classTable.create(classModel);
                counter++;
            }
            catch (Exception ex)
            {

            }

            //Assert
            Assert.AreEqual(expected, counter);
        }*/
    }



