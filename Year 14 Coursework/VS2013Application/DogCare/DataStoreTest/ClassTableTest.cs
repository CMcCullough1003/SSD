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
    public class ClassTableTest
    {
        private int programTypeId = 0;
        private int programeCostId = 0;
        private int programId = 0;
        private int staffId = 0;

        [TestInitialize]
        public void Setup()
        {
            new DataStoreTableHelper().clearAllTables();

            ProgramVarietyModel programeVarietyModel = new ProgramVarietyModel();
            programeVarietyModel.depositAmount = 20.0;
            programeVarietyModel.sessionCost = 20.0;
            programeVarietyModel.fullPaymentPercentageDiscount = 20;
            programeVarietyModel.name = "Regular";

            ProgramVarietyTable programVarietyTable = new ProgramVarietyTable();
            programeCostId = programVarietyTable.create(programeVarietyModel);

            ProgramModel programModel = new ProgramModel();
            programModel.programVarietyId = programeCostId;
            programModel.dogSpacesMaximum = 50;
            programModel.noOfClasses = 50;


            ProgramTable programTable = new ProgramTable();
            programId = programTable.create(programModel);

            StaffModel staffModel = new StaffModel();
            staffModel.name = "Bob";

            StaffTable staffTable = new StaffTable();
            staffId = staffTable.create(staffModel);
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
        public void Create_ValidData_ClassIDReturned()
        {
            //Assemble
            ClassModel classModel = new ClassModel();
            classModel.programId = programId;
            classModel.staffId = staffId;
            classModel.classDate = new DateTime(2021, 01, 01);
            classModel.startTime = new TimeSpan(2, 31, 0);
            classModel.endTime = new TimeSpan(2, 32, 0); 
            //If created will be greater than 0, but we don't know exactly what it will be because deleting all records doesnt set the ID counter back to 0
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
            classModel.programId = programId;
            classModel.staffId = staffId;
            classModel.classDate = new DateTime(2021, 01, 02);
            classModel.startTime = new TimeSpan(2, 32, 0);
            classModel.endTime = new TimeSpan(3, 32, 0);
            int expected = 1;
            ClassTable classTable = new ClassTable();

            //Act
            int classID = classTable.create(classModel);
            int actual = classTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        
        [TestMethod]
        public void Read_CreatedAndRead1Record_CorrectValues()
        {
            //Assemble
            ClassModel classModel = new ClassModel();
            classModel.programId = programId;
            classModel.staffId = staffId;
            classModel.classDate = new DateTime(2021, 01, 03);
            classModel.startTime = new TimeSpan(2, 33, 0);
            classModel.endTime = new TimeSpan(3, 33, 0);
            ClassTable classTable = new ClassTable();

            //Act
            int classID = classTable.create(classModel);
            ClassModel actual = classTable.read(classID);

            //Assert
            Assert.AreEqual(classModel.programId, actual.programId);
            Assert.AreEqual(classModel.staffId, actual.staffId);
            Assert.AreEqual(classModel.classDate, actual.classDate);
            Assert.AreEqual(classModel.startTime, actual.startTime);
            Assert.AreEqual(classModel.endTime, actual.endTime);
        }
        
        
        [TestMethod]
        public void ReadAll_Create3Records_CountIs3()
        {
            //Assemble
            ClassModel classModel1 = new ClassModel();
            classModel1.programId = programId;
            classModel1.staffId = staffId;
            classModel1.classDate = new DateTime(2021, 01, 01);
            classModel1.startTime = new TimeSpan(2, 31, 0);
            classModel1.endTime = new TimeSpan(3, 31, 0);

            ClassModel classModel2 = new ClassModel();
            classModel2.programId = programId;
            classModel2.staffId = staffId;
            classModel2.classDate = new DateTime(2021, 01, 02);
            classModel2.startTime = new TimeSpan(2, 32, 0);
            classModel2.endTime = new TimeSpan(3, 32, 0);

            ClassModel classModel3 = new ClassModel();
            classModel3.programId = programId;
            classModel3.staffId = staffId;
            classModel3.classDate = new DateTime(2021, 01, 03);
            classModel3.startTime = new TimeSpan(2, 33, 0);
            classModel3.endTime = new TimeSpan(3, 33, 0);

            ClassTable classTable = new ClassTable();
            int expected = 3;

            //Act
            int classID1 = classTable.create(classModel1);
            int classID2 = classTable.create(classModel2);
            int classID3 = classTable.create(classModel3);
            List<ClassModel> actual = classTable.readAll();

            //Assert
            Assert.AreEqual(expected, actual.Count);
        }

        [TestMethod]
        public void ReadAll_Create3Records_3DifferentRecords()
        {
            //Assemble
            ClassModel classModel1 = new ClassModel();
            classModel1.programId = programId;
            classModel1.staffId = staffId;
            classModel1.classDate = new DateTime(2021, 01, 01);
            classModel1.startTime = new TimeSpan(2, 31, 0);
            classModel1.endTime = new TimeSpan(3, 31, 0);

            ClassModel classModel2 = new ClassModel();
            classModel2.programId = programId;
            classModel2.staffId = staffId;
            classModel2.classDate = new DateTime(2021, 01, 02);
            classModel2.startTime = new TimeSpan(2, 32, 0);
            classModel2.endTime = new TimeSpan(3, 32, 0);

            ClassModel classModel3 = new ClassModel();
            classModel3.programId = programId;
            classModel3.staffId = staffId;
            classModel3.classDate = new DateTime(2021, 01, 03);
            classModel3.startTime = new TimeSpan(2, 33, 0);
            classModel3.endTime = new TimeSpan(3, 33, 0);

            ClassTable classTable = new ClassTable();

            //Act
            int classID1 = classTable.create(classModel1);
            int classID2 = classTable.create(classModel2);
            int classID3 = classTable.create(classModel3);
            List<ClassModel> actual = classTable.readAll();

            //Assert
            Assert.AreEqual(classID1, classID1);
            Assert.AreEqual(classModel1.programId, actual[0].programId);
            Assert.AreEqual(classModel1.staffId, actual[0].staffId);
            Assert.AreEqual(classModel1.classDate, actual[0].classDate);
            Assert.AreEqual(classModel1.startTime, actual[0].startTime);
            Assert.AreEqual(classModel1.endTime, actual[0].endTime);

            Assert.AreEqual(classID2, classID2);
            Assert.AreEqual(classModel2.programId, actual[1].programId);
            Assert.AreEqual(classModel2.staffId, actual[1].staffId);
            Assert.AreEqual(classModel2.classDate, actual[1].classDate);
            Assert.AreEqual(classModel2.startTime, actual[1].startTime);
            Assert.AreEqual(classModel2.endTime, actual[1].endTime);

            Assert.AreEqual(classID3, classID3);
            Assert.AreEqual(classModel3.programId, actual[2].programId);
            Assert.AreEqual(classModel3.staffId, actual[2].staffId);
            Assert.AreEqual(classModel3.classDate, actual[2].classDate);
            Assert.AreEqual(classModel3.startTime, actual[2].startTime);
            Assert.AreEqual(classModel3.endTime, actual[2].endTime);
        }

        [TestMethod]
        public void Update_CreatedUpdateAndRead1Record_UpdatedValues()
        {
            //Assemble
            ClassModel classModel = new ClassModel();
            classModel.programId = programId;
            classModel.staffId = staffId;
            classModel.classDate = new DateTime(2021, 01, 03);
            classModel.startTime = new TimeSpan(2, 33, 0);
            classModel.endTime = new TimeSpan(3, 33, 0);
            ClassTable classTable = new ClassTable();
            int classID = classTable.create(classModel);
            classModel.id = classID;
            classModel.programId = programId;
            classModel.staffId = staffId;
            classModel.classDate = new DateTime(2021, 01, 03);
            classModel.startTime = new TimeSpan(2, 33, 0);
            classModel.endTime = new TimeSpan(3, 33, 0);

            //Act
            classTable.update(classModel);
            ClassModel actual = classTable.read(classID);

            //Assert
            Assert.AreEqual(classModel.programId, actual.programId);
            Assert.AreEqual(classModel.staffId, actual.staffId);
            Assert.AreEqual(classModel.classDate, actual.classDate);
            Assert.AreEqual(classModel.startTime, actual.startTime);
            Assert.AreEqual(classModel.endTime, actual.endTime);
        }

        [TestMethod]
        public void Delete_CreatedDeleteAndCount1Record_0()
        {
            //Assemble
            ClassModel classModel = new ClassModel();
            classModel.programId = programId;
            classModel.staffId = staffId;
            classModel.classDate = new DateTime(2021, 01, 03);
            classModel.startTime = new TimeSpan(2, 33, 0);
            classModel.endTime = new TimeSpan(3, 33, 0);
            int expected = 0;
            ClassTable classTable = new ClassTable();
            int classID = classTable.create(classModel);

            //Act
            classTable.delete(classID);
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
    }
}

