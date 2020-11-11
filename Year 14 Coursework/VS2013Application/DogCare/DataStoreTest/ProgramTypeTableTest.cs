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
    public class ProgramTypeTableTest
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
            ProgramTypeTable programTypeTable = new ProgramTypeTable();

            //Act
            int actual = programTypeTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Create_ValidData_ProgramTypeIDReturned()
        {
            //Assemble
            ProgramTypeModel programTypeModel = new ProgramTypeModel();
            programTypeModel.description = "Advanced";
            //If created will be greater than 0, but we don't know exactly what it will be because deleting all records doesnt set the ID counter back to 0
            int notCreated = 0;
            ProgramTypeTable programTypeTable = new ProgramTypeTable();

            //Act
            int actual = programTypeTable.create(programTypeModel);

            //Assert
            Assert.AreNotEqual(notCreated, actual);
        }

        [TestMethod]
        public void Count_Created1Record_1()
        {
            //Assemble
            ProgramTypeModel programTypeModel = new ProgramTypeModel();
            programTypeModel.description = "Advanced";
            int expected = 1;
            ProgramTypeTable programTypeTable = new ProgramTypeTable();

            //Act
            int programTypeID = programTypeTable.create(programTypeModel);
            int actual = programTypeTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Read_CreatedAndRead1Record_CorrectValues()
        {
            //Assemble
            ProgramTypeModel programTypeModel = new ProgramTypeModel();
            programTypeModel.description = "Advanced";
            ProgramTypeTable programTypeTable = new ProgramTypeTable();

            //Act
            int programTypeID = programTypeTable.create(programTypeModel);
            ProgramTypeModel actual = programTypeTable.read(programTypeID);

            //Assert
            Assert.AreEqual(programTypeModel.description, actual.description);
        }

        [TestMethod]
        public void ReadAll_Create3Records_CountIs3()
        {
            //Assemble
            ProgramTypeModel programTypeModel1 = new ProgramTypeModel();
            programTypeModel1.description = "Advanced";

            ProgramTypeModel programTypeModel2 = new ProgramTypeModel();
            programTypeModel2.description = "Regular";

            ProgramTypeModel programTypeModel3 = new ProgramTypeModel();
            programTypeModel3.description = "Advanced";

            ProgramTypeTable programTypeTable = new ProgramTypeTable();
            int expected = 3;

            //Act
            int programTypeID1 = programTypeTable.create(programTypeModel1);
            int programTypeID2 = programTypeTable.create(programTypeModel2);
            int programTypeID3 = programTypeTable.create(programTypeModel3);
            List<ProgramTypeModel> actual = programTypeTable.readAll();

            //Assert
            Assert.AreEqual(expected, actual.Count);
        }

        [TestMethod]
        public void ReadAll_Create3Records_3DifferentRecords()
        {
            //Assemble
            ProgramTypeModel programTypeModel1 = new ProgramTypeModel();
            programTypeModel1.description = "Advanced";

            ProgramTypeModel programTypeModel2 = new ProgramTypeModel();
            programTypeModel2.description = "Regular";

            ProgramTypeModel programTypeModel3 = new ProgramTypeModel();
            programTypeModel3.description = "Advanced";

            ProgramTypeTable programTypeTable = new ProgramTypeTable();

            //Act
            int programTypeID1 = programTypeTable.create(programTypeModel1);
            int programTypeID2 = programTypeTable.create(programTypeModel2);
            int programTypeID3 = programTypeTable.create(programTypeModel3);
            List<ProgramTypeModel> actual = programTypeTable.readAll();

            //Assert
            Assert.AreEqual(programTypeID1, programTypeID1);
            Assert.AreEqual(programTypeModel1.description, actual[0].description);

            Assert.AreEqual(programTypeID2, programTypeID2);
            Assert.AreEqual(programTypeModel2.description, actual[1].description);

            Assert.AreEqual(programTypeID3, programTypeID3);
            Assert.AreEqual(programTypeModel3.description, actual[2].description);
        }

        [TestMethod]
        public void Update_CreatedUpdateAndRead1Record_UpdatedValues()
        {
            //Assemble
            ProgramTypeModel programTypeModel = new ProgramTypeModel();
            programTypeModel.description = "Advanced";

            ProgramTypeTable programTypeTable = new ProgramTypeTable();
            int programTypeID = programTypeTable.create(programTypeModel);
            programTypeModel.id = programTypeID;
            programTypeModel.description = "Regular";

            //Act
            programTypeTable.update(programTypeModel);
            ProgramTypeModel actual = programTypeTable.read(programTypeID);

            //Assert
            Assert.AreEqual(programTypeModel.description, actual.description);
        }

        [TestMethod]
        public void Delete_CreatedDeleteAndCount1Record_0()
        {
            //Assemble
            ProgramTypeModel programTypeModel = new ProgramTypeModel();
            programTypeModel.description = "Advanced";

            int expected = 0;
            ProgramTypeTable programTypeTable = new ProgramTypeTable();
            int programTypeID = programTypeTable.create(programTypeModel);

            //Act
            programTypeTable.delete(programTypeID);
            int actual = programTypeTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Delete_NonExistantId_0()
        {
            //Assemble
            ProgramTypeTable programTypeTable = new ProgramTypeTable();
            int expected = 0;

            //Act
            programTypeTable.delete(0);
            int actual = programTypeTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreateDescriptionConstraint_DescriptionInvalid_Exception()
        {
            //Assemble
            ProgramTypeTable programTypeTable = new ProgramTypeTable();
            ProgramTypeModel programTypeModel = new ProgramTypeModel();
            programTypeModel.description = "Bo";

            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = programTypeTable.create(programTypeModel);
            }
            catch (Exception ex)
            {
                counter++;
            }

            //Assert
            Assert.AreEqual(expected, counter);
        }

        [TestMethod]
        public void CreateDescriptionConstraint_DescriptionNull_Exception()
        {
            //Assemble
            ProgramTypeTable programTypeTable = new ProgramTypeTable();
            ProgramTypeModel programTypeModel = new ProgramTypeModel();
            programTypeModel.description = null;

            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = programTypeTable.create(programTypeModel);
            }
            catch (Exception ex)
            {
                counter++;
            }

            //Assert
            Assert.AreEqual(expected, counter);
        }
    }
}

