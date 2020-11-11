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
    public class ProgramTableTest
    {

        private int programTypeId = 0;
        private int programCostId = 0;

        [TestInitialize]
        public void Setup()
        {
            new DataStoreTableHelper().clearAllTables();

            ProgramTypeModel programTypeModel = new ProgramTypeModel();
            programTypeModel.description = "Regular";

            ProgramTypeTable programTypeTable = new ProgramTypeTable();
            programTypeId = programTypeTable.create(programTypeModel);


            ProgramCostModel programeCostModel = new ProgramCostModel();
            programeCostModel.depositAmount = 20.0;
            programeCostModel.sessionCost = 20.0;
            programeCostModel.fullPaymentPercentageDiscount = 20;

            ProgramCostTable programCostTable = new ProgramCostTable();
            programCostId = programCostTable.create(programeCostModel);
        }

        [TestMethod]
        public void Count_AllRecordsDeleted_0()
        {
            //Assemble
            int expected = 0;
            ProgramTable programTable = new ProgramTable();

            //Act
            int actual = programTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Create_ValidData_ProgramIDReturned()
        {
            //Assemble
           ProgramModel programModel = new ProgramModel();
            programModel.programTypeId = programTypeId;
            programModel.programCostId = programCostId;
            programModel.dogSpacesMaximum = 10;
            programModel.noOfClasses = 6;
            //If created will be greater than 0, but we don't know exactly what it will be because deleting all records doesnt set the ID counter back to 0
            int notCreated = 0;
            ProgramTable programTable = new ProgramTable();

            //Act
            int actual = programTable.create(programModel);

            //Assert
            Assert.AreNotEqual(notCreated, actual);
        }


        [TestMethod]
        public void Count_Created1Record_1()
        {
            //Assemble
            ProgramModel programModel = new ProgramModel();
            programModel.programTypeId = programTypeId;
            programModel.programCostId = programCostId;
            programModel.dogSpacesMaximum = 10;
            programModel.noOfClasses = 6;
            int expected = 1;
            ProgramTable programTable = new ProgramTable();

            //Act
            int programID = programTable.create(programModel);
            int actual = programTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }
       
        [TestMethod]
        public void Read_CreatedAndRead1Record_CorrectValues()
        {
            //Assemble
            ProgramModel programModel = new ProgramModel();
            programModel.programTypeId = programTypeId;
            programModel.programCostId = programCostId;
            programModel.dogSpacesMaximum = 10;
            programModel.noOfClasses = 6;
            ProgramTable programTable = new ProgramTable();

            //Act
            int programID = programTable.create(programModel);
            ProgramModel actual = programTable.read(programID);

            //Assert
            Assert.AreEqual(programModel.programTypeId, actual.programTypeId);
            Assert.AreEqual(programModel.programCostId, actual.programCostId);
            Assert.AreEqual(programModel.dogSpacesMaximum, actual.dogSpacesMaximum);
            Assert.AreEqual(programModel.noOfClasses, actual.noOfClasses);
        }

        [TestMethod]
        public void ReadAll_Create3Records_CountIs3()
        {
           //Assemble
            ProgramModel programModel1 = new ProgramModel();
            programModel1.programTypeId = programTypeId;
            programModel1.programCostId = programCostId;
            programModel1.dogSpacesMaximum = 10;
            programModel1.noOfClasses = 6;

            ProgramModel programModel2 = new ProgramModel();
            programModel2.programTypeId = programTypeId;
            programModel2.programCostId = programCostId;
            programModel2.dogSpacesMaximum = 10;
            programModel2.noOfClasses = 6;

            ProgramModel programModel3 = new ProgramModel();
            programModel3.programTypeId = programTypeId;
            programModel3.programCostId = programCostId;
            programModel3.dogSpacesMaximum = 10;
            programModel3.noOfClasses = 6;

            ProgramTable programTable = new ProgramTable();
           int expected = 3;

           //Act
           int programID1 = programTable.create(programModel1);
           int programID2 = programTable.create(programModel2);
           int programID3 = programTable.create(programModel3);
           List<ProgramModel> actual = programTable.readAll();

           //Assert
           Assert.AreEqual(expected, actual.Count);
        }

        [TestMethod]
        public void ReadAll_Create3Records_3DifferentRecords()
        {
            //Assemble
            ProgramModel programModel1 = new ProgramModel();
            programModel1.programTypeId = programTypeId;
            programModel1.programCostId = programCostId;
            programModel1.dogSpacesMaximum = 10;
            programModel1.noOfClasses = 6;

            ProgramModel programModel2 = new ProgramModel();
            programModel2.programTypeId = programTypeId;
            programModel2.programCostId = programCostId;
            programModel2.dogSpacesMaximum = 10;
            programModel2.noOfClasses = 6;

            ProgramModel programModel3 = new ProgramModel();
            programModel3.programTypeId = programTypeId;
            programModel3.programCostId = programCostId;
            programModel3.dogSpacesMaximum = 10;
            programModel3.noOfClasses = 6;

            ProgramTable programTable = new ProgramTable();

           //Act
           int programID1 = programTable.create(programModel1);
           int programID2 = programTable.create(programModel2);
           int programID3 = programTable.create(programModel3);
           List<ProgramModel> actual = programTable.readAll();

           //Assert
           Assert.AreEqual(programID1, actual[0].id);
           Assert.AreEqual(programModel1.programTypeId, actual[0].programTypeId);
           Assert.AreEqual(programModel1.programCostId, actual[0].programCostId);
           Assert.AreEqual(programModel1.dogSpacesMaximum, actual[0].dogSpacesMaximum);
           Assert.AreEqual(programModel1.noOfClasses, actual[0].noOfClasses);

            Assert.AreEqual(programID2, actual[1].id);
            Assert.AreEqual(programModel2.programTypeId, actual[1].programTypeId);
            Assert.AreEqual(programModel2.programCostId, actual[1].programCostId);
            Assert.AreEqual(programModel2.dogSpacesMaximum, actual[1].dogSpacesMaximum);
            Assert.AreEqual(programModel2.noOfClasses, actual[1].noOfClasses);

            Assert.AreEqual(programID3, actual[2].id);
            Assert.AreEqual(programModel3.programTypeId, actual[2].programTypeId);
            Assert.AreEqual(programModel3.programCostId, actual[2].programCostId);
            Assert.AreEqual(programModel3.dogSpacesMaximum, actual[2].dogSpacesMaximum);
            Assert.AreEqual(programModel3.noOfClasses, actual[2].noOfClasses);
        }

        [TestMethod]
        public void Update_CreatedUpdateAndRead1Record_UpdatedValues()
        {
            //Assemble
            ProgramModel programModel = new ProgramModel();
            programModel.programTypeId = programTypeId;
            programModel.programCostId = programCostId;
            programModel.dogSpacesMaximum = 10;
            programModel.noOfClasses = 6;
            ProgramTable programTable = new ProgramTable();
            int programID = programTable.create(programModel);
            programModel.id = programID;
            programModel.programTypeId = programTypeId;
            programModel.programCostId = programCostId;
            programModel.dogSpacesMaximum = 12;
            programModel.noOfClasses = 7;

            //Act
            programTable.update(programModel);
            ProgramModel actual = programTable.read(programID);

            //Assert
            Assert.AreEqual(programModel.programTypeId, actual.programTypeId);
            Assert.AreEqual(programModel.programCostId, actual.programCostId);
            Assert.AreEqual(programModel.dogSpacesMaximum, actual.dogSpacesMaximum);
            Assert.AreEqual(programModel.noOfClasses, actual.noOfClasses);
        }

        [TestMethod]
        public void Delete_CreatedDeleteAndCount1Record_0()
        {
                //Assemble
                ProgramModel programModel = new ProgramModel();
                programModel.programTypeId = programTypeId;
                programModel.programCostId = programCostId;
                programModel.dogSpacesMaximum = 12;
                programModel.noOfClasses = 7;
                int expected = 0;
                ProgramTable programTable = new ProgramTable();
                int programID = programTable.create(programModel);

                //Act
                programTable.delete(programID);
                int actual = programTable.count();

                //Assert
                Assert.AreEqual(expected, actual);
                }

        [TestMethod]
        public void Delete_NonExistantId_0()
        {
            //Assemble
            ProgramTable programTable = new ProgramTable();
            int expected = 0;

            //Act
            programTable.delete(0);
            int actual = programTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

