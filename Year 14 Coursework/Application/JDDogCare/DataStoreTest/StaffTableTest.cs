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
    public class StaffTableTest
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
            StaffTable staffTable = new StaffTable();

            //Act
            int actual = staffTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Create_ValidData_StaffIDReturned()
        {
            //Assemble
            StaffModel staffModel = new StaffModel();
            staffModel.name = "Bob";
            //If created will be greater than 0, but we don't know exactly what it will be because deleting all records doesnt set the ID counter back to 0
            int notCreated = 0;
            StaffTable staffTable = new StaffTable();

            //Act
            int actual = staffTable.create(staffModel);

            //Assert
            Assert.AreNotEqual(notCreated, actual);
        }


        [TestMethod]
        public void Count_Created1Record_1()
        {
            //Assemble
            StaffModel staffModel = new StaffModel();
            staffModel.name = "Bob";
            int expected = 1;
            StaffTable staffTable = new StaffTable();

            //Act
            int staffID = staffTable.create(staffModel);
            int actual = staffTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Read_CreatedAndRead1Record_CorrectValues()
        {
        //Assemble
        StaffModel staffModel = new StaffModel();
        staffModel.name = "Bob";
        StaffTable staffTable = new StaffTable();

        //Act
        int staffID = staffTable.create(staffModel);
        StaffModel actual = staffTable.read(staffID);

        //Assert
        Assert.AreEqual(staffModel.name, actual.name);
        }


        [TestMethod]
        public void ReadAll_Create3Records_CountIs3()
        {
        //Assemble
        StaffModel staffModel1 = new StaffModel();
        staffModel1.name = "Bob";

        StaffModel staffModel2 = new StaffModel();
        staffModel2.name = "Bob2";

        StaffModel staffModel3 = new StaffModel();
        staffModel3.name = "Bob3";

        StaffTable staffTable = new StaffTable();
        int expected = 3;

        //Act
        int staffID1 = staffTable.create(staffModel1);
        int staffID2 = staffTable.create(staffModel2);
        int staffID3 = staffTable.create(staffModel3);
        List<StaffModel> actual = staffTable.readAll();

        //Assert
        Assert.AreEqual(expected, actual.Count);
        }


        [TestMethod]
        public void ReadAll_Create3Records_3DifferentRecords()
        {
        //Assemble
        StaffModel staffModel1 = new StaffModel();
        staffModel1.name = "name1";


        StaffModel staffModel2 = new StaffModel();
        staffModel2.name = "name2";

        StaffModel staffModel3 = new StaffModel();
        staffModel3.name = "name3";

        StaffTable staffTable = new StaffTable();

        //Act
        int staffID1 = staffTable.create(staffModel1);
        int staffID2 = staffTable.create(staffModel2);
        int staffID3 = staffTable.create(staffModel3);
        List<StaffModel> actual = staffTable.readAll();

        //Assert
        Assert.AreEqual(staffID1, staffID1);
        Assert.AreEqual(staffModel1.name, actual[0].name);

        Assert.AreEqual(staffID2, staffID2);
        Assert.AreEqual(staffModel2.name, actual[1].name);

        Assert.AreEqual(staffID3, staffID3);
        Assert.AreEqual(staffModel3.name, actual[2].name);
        }


        [TestMethod]
        public void Update_CreatedUpdateAndRead1Record_UpdatedValues()
        {
        //Assemble
        StaffModel staffModel = new StaffModel();
        staffModel.name = "Bob";
        StaffTable staffTable = new StaffTable();
        int staffID = staffTable.create(staffModel);
        staffModel.id = staffID;
        staffModel.name = "Kate";

        //Act
        staffTable.update(staffModel);
        StaffModel actual = staffTable.read(staffID);

        //Assert
        Assert.AreEqual(staffModel.name, actual.name);
        }


        [TestMethod]
        public void Delete_CreatedDeleteAndCount1Record_0()
        {
        //Assemble
        StaffModel staffModel = new StaffModel();
        staffModel.name = "Bob";
        int expected = 0;
        StaffTable staffTable = new StaffTable();
        int staffID = staffTable.create(staffModel);

        //Act
        staffTable.delete(staffID);
        int actual = staffTable.count();

        //Assert
        Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Delete_NonExistantId_0()
        {
        //Assemble
        StaffTable staffTable = new StaffTable();
        int expected = 0;

        //Act
        staffTable.delete(0);
        int actual = staffTable.count();

        //Assert
        Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void CreateNameConstraint_NameLengthTooShort_Exception()
        {
        //Assemble
        StaffTable staffTable = new StaffTable();
        StaffModel staffModel = new StaffModel();
        staffModel.name = "Bo";
        int expected = 1;
        int counter = 0;

        //Act
        try
        {
        int id = staffTable.create(staffModel);
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
        StaffTable staffTable = new StaffTable();
        StaffModel staffModel = new StaffModel();
        staffModel.name = "Bob";
        int expected = 1;
        int counter = 0;

        //Act
        try
        {
        int id = staffTable.create(staffModel);
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

