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

        private int programVarietyId = 0;

        [TestInitialize]
        public void Setup()
        {
            new DataStoreTableHelper().clearAllTables();

            ProgramVarietyModel programeVarietyModel = new ProgramVarietyModel();
            programeVarietyModel.depositAmount = 20.0;
            programeVarietyModel.sessionCost = 20.0;
            programeVarietyModel.fullPaymentPercentageDiscount = 20;
            programeVarietyModel.name = "Advanced";
            programeVarietyModel.dogSpacesMaximum = 10;
            programeVarietyModel.noOfClasses = 10;

            ProgramVarietyTable programVarietyTable = new ProgramVarietyTable();
            programVarietyId = programVarietyTable.create(programeVarietyModel);
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
            programModel.programVarietyId = programVarietyId;

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
            programModel.programVarietyId = programVarietyId;

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
            programModel.programVarietyId = programVarietyId;
            ProgramTable programTable = new ProgramTable();

            //Act
            int programID = programTable.create(programModel);
            ProgramModel actual = programTable.read(programID);

            //Assert
            Assert.AreEqual(programModel.programVarietyId, actual.programVarietyId);

        }

        [TestMethod]
        public void ReadAll_Create3Records_CountIs3()
        {
           //Assemble
            ProgramModel programModel1 = new ProgramModel();
            programModel1.programVarietyId = programVarietyId;


            ProgramModel programModel2 = new ProgramModel();
            programModel2.programVarietyId = programVarietyId;


            ProgramModel programModel3 = new ProgramModel();
            programModel3.programVarietyId = programVarietyId;


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
            programModel1.programVarietyId = programVarietyId;


            ProgramModel programModel2 = new ProgramModel();
            programModel2.programVarietyId = programVarietyId;


            ProgramModel programModel3 = new ProgramModel();
            programModel3.programVarietyId = programVarietyId;


            ProgramTable programTable = new ProgramTable();

           //Act
           int programID1 = programTable.create(programModel1);
           int programID2 = programTable.create(programModel2);
           int programID3 = programTable.create(programModel3);
           List<ProgramModel> actual = programTable.readAll();

           //Assert
           Assert.AreEqual(programID1, actual[0].id);
           Assert.AreEqual(programModel1.programVarietyId, actual[0].programVarietyId);

            Assert.AreEqual(programID2, actual[1].id);
            Assert.AreEqual(programModel2.programVarietyId, actual[1].programVarietyId);

            Assert.AreEqual(programID3, actual[2].id);
            Assert.AreEqual(programModel3.programVarietyId, actual[2].programVarietyId);

        }

        [TestMethod]
        public void Update_CreatedUpdateAndRead1Record_UpdatedValues()
        {
            //Assemble
            ProgramModel programModel = new ProgramModel();
            programModel.programVarietyId = programVarietyId;

            ProgramTable programTable = new ProgramTable();
            int programID = programTable.create(programModel);
            programModel.id = programID;
            programModel.programVarietyId = programVarietyId;


            //Act
            programTable.update(programModel);
            ProgramModel actual = programTable.read(programID);

            //Assert
            Assert.AreEqual(programModel.programVarietyId, actual.programVarietyId);

        }

        [TestMethod]
        public void Delete_CreatedDeleteAndCount1Record_0()
        {
                //Assemble
                ProgramModel programModel = new ProgramModel();
                programModel.programVarietyId = programVarietyId;

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

