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
    public class ProgramVarietyTableTest
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
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();

            //Act
            int actual = programCostTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Create_ValidData_ProgramVarietyIDReturned()
        {
            //Assemble
            ProgramVarietyModel programVarietyModel = new ProgramVarietyModel();
            programVarietyModel.depositAmount = 49.0;
            programVarietyModel.sessionCost = 50.0;
            programVarietyModel.fullPaymentPercentageDiscount = 51.0;
            programVarietyModel.name = "Advanced";
            programVarietyModel.noOfClasses = 10;
            programVarietyModel.dogSpacesMaximum = 9;
            //If created will be greater than 0, but we don't know exactly what it will be because deleting all records doesnt set the ID counter back to 0
            int notCreated = 0;
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();

            //Act
            int actual = programCostTable.create(programVarietyModel);

            //Assert
            Assert.AreNotEqual(notCreated, actual);
        }

        [TestMethod]
        public void Count_Created1Record_1()
        {
            //Assemble
            ProgramVarietyModel programVarietyModel = new ProgramVarietyModel();
            programVarietyModel.depositAmount = 49.0;
            programVarietyModel.sessionCost = 50.0;
            programVarietyModel.fullPaymentPercentageDiscount = 51.0;
            programVarietyModel.name = "Advanced";
            programVarietyModel.noOfClasses = 10;
            programVarietyModel.dogSpacesMaximum = 9;
            int expected = 1;
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();

            //Act
            int programCostID = programCostTable.create(programVarietyModel);
            int actual = programCostTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Read_CreatedAndRead1Record_CorrectValues()
        {
            //Assemble
            ProgramVarietyModel programVarietyModel = new ProgramVarietyModel();
            programVarietyModel.depositAmount = 49.0;
            programVarietyModel.sessionCost = 50.0;
            programVarietyModel.fullPaymentPercentageDiscount = 51.0;
            programVarietyModel.name = "Advanced";
            programVarietyModel.noOfClasses = 10;
            programVarietyModel.dogSpacesMaximum = 9;
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();

            //Act
            int programCostID = programCostTable.create(programVarietyModel);
            ProgramVarietyModel actual = programCostTable.read(programCostID);

            //Assert
            Assert.AreEqual(programVarietyModel.depositAmount, actual.depositAmount);
            Assert.AreEqual(programVarietyModel.sessionCost, actual.sessionCost);
            Assert.AreEqual(programVarietyModel.dogSpacesMaximum , actual.dogSpacesMaximum );
            Assert.AreEqual(programVarietyModel.noOfClasses , actual.noOfClasses );
 
        }

        [TestMethod]
        public void ReadAll_Create3Records_CountIs3()
        {
            //Assemble
            ProgramVarietyModel programVarietyModel1 = new ProgramVarietyModel();
            programVarietyModel1.depositAmount = 49.1;
            programVarietyModel1.sessionCost = 50.1;
            programVarietyModel1.fullPaymentPercentageDiscount = 51.1;
            programVarietyModel1.name = "Advanced";
            programVarietyModel1.noOfClasses = 10;
            programVarietyModel1.dogSpacesMaximum = 9;


            ProgramVarietyModel programVarietyModel2 = new ProgramVarietyModel();
            programVarietyModel2.depositAmount = 49.2;
            programVarietyModel2.sessionCost = 50.2;
            programVarietyModel2.fullPaymentPercentageDiscount = 51.2;
            programVarietyModel2.name = "Advanced";
            programVarietyModel2.noOfClasses = 8;
            programVarietyModel2.dogSpacesMaximum = 7;

            ProgramVarietyModel programVarietyModel3 = new ProgramVarietyModel();
            programVarietyModel3.depositAmount = 49.3;
            programVarietyModel3.sessionCost = 50.3;
            programVarietyModel3.fullPaymentPercentageDiscount = 51.3;
            programVarietyModel3.name = "Advanced";
            programVarietyModel3.noOfClasses = 6;
            programVarietyModel3.dogSpacesMaximum = 5;

            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            int expected = 3;

            //Act
            int programCostID1 = programCostTable.create(programVarietyModel1);
            int programCostID2 = programCostTable.create(programVarietyModel2);
            int programCostID3 = programCostTable.create(programVarietyModel3);
            List<ProgramVarietyModel> actual = programCostTable.readAll();

            //Assert
            Assert.AreEqual(expected, actual.Count);
        }

        [TestMethod]
        public void ReadAll_Create3Records_3DifferentRecords()
        {
            //Assemble
            ProgramVarietyModel programVarietyModel1 = new ProgramVarietyModel();
            programVarietyModel1.depositAmount = 49.1;
            programVarietyModel1.sessionCost = 50.1;
            programVarietyModel1.fullPaymentPercentageDiscount = 51.1;
            programVarietyModel1.name = "Advanced";
            programVarietyModel1.noOfClasses = 10;
            programVarietyModel1.dogSpacesMaximum = 9;

            ProgramVarietyModel programVarietyModel2 = new ProgramVarietyModel();
            programVarietyModel2.depositAmount = 49.2;
            programVarietyModel2.sessionCost = 50.2;
            programVarietyModel2.fullPaymentPercentageDiscount = 51.2;
            programVarietyModel2.name = "Regular";
            programVarietyModel2.noOfClasses = 8;
            programVarietyModel2.dogSpacesMaximum = 7;

            ProgramVarietyModel programVarietyModel3 = new ProgramVarietyModel();
            programVarietyModel3.depositAmount = 49.3;
            programVarietyModel3.sessionCost = 50.3;
            programVarietyModel3.fullPaymentPercentageDiscount = 51.3;
            programVarietyModel3.name = "Advanced";
            programVarietyModel3.noOfClasses = 6;
            programVarietyModel3.dogSpacesMaximum = 5;

            ProgramVarietyTable programCostTable = new ProgramVarietyTable();

            //Act
            int programCostID1 = programCostTable.create(programVarietyModel1);
            int programCostID2 = programCostTable.create(programVarietyModel2);
            int programCostID3 = programCostTable.create(programVarietyModel3);
            List<ProgramVarietyModel> actual = programCostTable.readAll();

            //Assert
            Assert.AreEqual(programCostID1, programCostID1);
            Assert.AreEqual(programVarietyModel1.depositAmount, actual[0].depositAmount);
            Assert.AreEqual(programVarietyModel1.sessionCost, actual[0].sessionCost);
            Assert.AreEqual(programVarietyModel1.fullPaymentPercentageDiscount, actual[0].fullPaymentPercentageDiscount);
            Assert.AreEqual(programVarietyModel1.name, actual[0].name);
            Assert.AreEqual(programVarietyModel1.dogSpacesMaximum,  actual[0].dogSpacesMaximum);
            Assert.AreEqual(programVarietyModel1.noOfClasses,  actual[0].noOfClasses);

            Assert.AreEqual(programCostID2, programCostID2);
            Assert.AreEqual(programVarietyModel2.depositAmount, actual[1].depositAmount);
            Assert.AreEqual(programVarietyModel2.sessionCost, actual[1].sessionCost);
            Assert.AreEqual(programVarietyModel2.fullPaymentPercentageDiscount, actual[1].fullPaymentPercentageDiscount);
            Assert.AreEqual(programVarietyModel2.name, actual[1].name);
            Assert.AreEqual(programVarietyModel2.dogSpacesMaximum, actual[1].dogSpacesMaximum);
            Assert.AreEqual(programVarietyModel2.noOfClasses, actual[1].noOfClasses);


            Assert.AreEqual(programCostID3, programCostID3);
            Assert.AreEqual(programVarietyModel3.depositAmount, actual[2].depositAmount);
            Assert.AreEqual(programVarietyModel3.sessionCost, actual[2].sessionCost);
            Assert.AreEqual(programVarietyModel3.fullPaymentPercentageDiscount, actual[2].fullPaymentPercentageDiscount);
            Assert.AreEqual(programVarietyModel3.name, actual[2].name);
            Assert.AreEqual(programVarietyModel3.dogSpacesMaximum, actual[2].dogSpacesMaximum);
            Assert.AreEqual(programVarietyModel3.noOfClasses, actual[2].noOfClasses);

        }

        [TestMethod]
        public void Update_CreatedUpdateAndRead1Record_UpdatedValues()
        {
            //Assemble
            ProgramVarietyModel programVarietyModel = new ProgramVarietyModel();
            programVarietyModel.depositAmount = 49.0;
            programVarietyModel.sessionCost = 50.0;
            programVarietyModel.fullPaymentPercentageDiscount = 51.0;
            programVarietyModel.name = "Regular";
            programVarietyModel.noOfClasses = 10;
            programVarietyModel.dogSpacesMaximum = 9;

            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            int programCostID = programCostTable.create(programVarietyModel);

            programVarietyModel.id = programCostID;
            programVarietyModel.depositAmount = 49.1;
            programVarietyModel.sessionCost = 50.1;
            programVarietyModel.fullPaymentPercentageDiscount = 51.4;
            programVarietyModel.noOfClasses = 8;
            programVarietyModel.dogSpacesMaximum = 7;

            //Act
            programCostTable.update(programVarietyModel);
            ProgramVarietyModel actual = programCostTable.read(programCostID);

            //Assert
            Assert.AreEqual(programVarietyModel.depositAmount, actual.depositAmount);
            Assert.AreEqual(programVarietyModel.sessionCost, actual.sessionCost);
            Assert.AreEqual(programVarietyModel.fullPaymentPercentageDiscount, actual.fullPaymentPercentageDiscount);
            Assert.AreEqual(programVarietyModel.dogSpacesMaximum , actual.dogSpacesMaximum );
            Assert.AreEqual(programVarietyModel.noOfClasses , actual.noOfClasses);

        }

        [TestMethod]
        public void Delete_CreatedDeleteAndCount1Record_0()
        {
            //Assemble
            ProgramVarietyModel programVarietyModel = new ProgramVarietyModel();
            programVarietyModel.depositAmount = 49.0;
            programVarietyModel.sessionCost = 50.0;
            programVarietyModel.fullPaymentPercentageDiscount = 51.0;
            programVarietyModel.name = "Regular";
            programVarietyModel.noOfClasses = 10;
            programVarietyModel.dogSpacesMaximum = 9;
            int expected = 0;
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            int programCostID = programCostTable.create(programVarietyModel);

            //Act
            programCostTable.delete(programCostID);
            int actual = programCostTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Delete_NonExistantId_0()
        {
            //Assemble
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            int expected = 0;

            //Act
            programCostTable.delete(0);
            int actual = programCostTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreateDepositAmountConstraint_OutsideLowerBoundry_Exception()
        {
            //Assemble
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            ProgramVarietyModel programVarietyModel = new ProgramVarietyModel();
            programVarietyModel.depositAmount = 19.0;
            programVarietyModel.sessionCost = 50.0;
            programVarietyModel.fullPaymentPercentageDiscount = 51.0;
            programVarietyModel.name = "Regular";
            programVarietyModel.noOfClasses = 10;
            programVarietyModel.dogSpacesMaximum = 9;
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programVarietyModel);
            }
            catch (Exception ex)
            {
                counter++;
            }

            //Assert
            Assert.AreEqual(expected, counter);
        }

        [TestMethod]
        public void CreateDepositAmountConstraint_OnLowerBoundry_NoException()
        {
            //Assemble
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            ProgramVarietyModel programVarietyModel = new ProgramVarietyModel();
            programVarietyModel.depositAmount = 20.0;
            programVarietyModel.sessionCost = 50.0;
            programVarietyModel.fullPaymentPercentageDiscount = 51.0;
            programVarietyModel.name = "Regular";
            programVarietyModel.noOfClasses = 10;
            programVarietyModel.dogSpacesMaximum = 9;
            int expected = 0;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programVarietyModel);
            }
            catch (Exception ex)
            {
                counter++;
            }

            //Assert
            Assert.AreEqual(expected, counter);
        }

        [TestMethod]
        public void CreateDepositAmountConstraint_OutsideUpperBoundry_Exception()
        {
            //Assemble
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            ProgramVarietyModel programVarietyModel = new ProgramVarietyModel();
            programVarietyModel.depositAmount = 101.0;
            programVarietyModel.sessionCost = 50.0;
            programVarietyModel.fullPaymentPercentageDiscount = 51.0;
            programVarietyModel.name = "Regular";
            programVarietyModel.noOfClasses = 10;
            programVarietyModel.dogSpacesMaximum = 9;
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programVarietyModel);
            }
            catch (Exception ex)
            {
                counter++;
            }

            //Assert
            Assert.AreEqual(expected, counter);
        }

        [TestMethod]
        public void CreateDepositAmountConstraint_OnUpperBoundry_NoException()
        {
            //Assemble
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            ProgramVarietyModel programVarietyModel = new ProgramVarietyModel();
            programVarietyModel.depositAmount = 100.0;
            programVarietyModel.sessionCost = 50.0;
            programVarietyModel.fullPaymentPercentageDiscount = 51.0;
            programVarietyModel.name = "Regular";
            programVarietyModel.noOfClasses = 10;
            programVarietyModel.dogSpacesMaximum = 9;
            int expected = 0;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programVarietyModel);
            }
            catch (Exception ex)
            {
                counter++;
            }

            //Assert
            Assert.AreEqual(expected, counter);
        }

        //==============================================================

        [TestMethod]
        public void CreateSessionCostConstraint_OutsideLowerBoundry_Exception()
        {
            //Assemble
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            ProgramVarietyModel programVarietyModel = new ProgramVarietyModel();
            programVarietyModel.depositAmount = 50.0;
            programVarietyModel.sessionCost = 19.0;
            programVarietyModel.fullPaymentPercentageDiscount = 51.0;
            programVarietyModel.name = "Regular";
            programVarietyModel.noOfClasses = 10;
            programVarietyModel.dogSpacesMaximum = 9;
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programVarietyModel);
            }
            catch (Exception ex)
            {
                counter++;
            }

            //Assert
            Assert.AreEqual(expected, counter);
        }

        [TestMethod]
        public void CreateSessionCostConstraint_OnLowerBoundry_NoException()
        {
            //Assemble
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            ProgramVarietyModel programVarietyModel = new ProgramVarietyModel();
            programVarietyModel.depositAmount = 50.0;
            programVarietyModel.sessionCost = 20.0;
            programVarietyModel.fullPaymentPercentageDiscount = 51.0;
            programVarietyModel.name = "Regular";
            programVarietyModel.noOfClasses = 10;
            programVarietyModel.dogSpacesMaximum = 9;
            int expected = 0;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programVarietyModel);
            }
            catch (Exception ex)
            {
                counter++;
            }

            //Assert
            Assert.AreEqual(expected, counter);
        }

        [TestMethod]
        public void CreateSessionCostConstraint_OutsideUpperBoundry_Exception()
        {
            //Assemble
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            ProgramVarietyModel programVarietyModel = new ProgramVarietyModel();
            programVarietyModel.depositAmount = 50.0;
            programVarietyModel.sessionCost = 101.0;
            programVarietyModel.fullPaymentPercentageDiscount = 51.0;
            programVarietyModel.name = "Regular";
            programVarietyModel.noOfClasses = 10;
            programVarietyModel.dogSpacesMaximum = 9;
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programVarietyModel);
            }
            catch (Exception ex)
            {
                counter++;
            }

            //Assert
            Assert.AreEqual(expected, counter);
        }

        [TestMethod]
        public void CreateSessionCostConstraint_OnUpperBoundry_NoException()
        {
            //Assemble
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            ProgramVarietyModel programVarietyModel = new ProgramVarietyModel();
            programVarietyModel.depositAmount = 50.0;
            programVarietyModel.sessionCost = 100.0;
            programVarietyModel.fullPaymentPercentageDiscount = 51.0;
            programVarietyModel.name = "Regular";
            programVarietyModel.noOfClasses = 10;
            programVarietyModel.dogSpacesMaximum = 9;
            int expected = 0;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programVarietyModel);
            }
            catch (Exception ex)
            {
                counter++;
            }

            //Assert
            Assert.AreEqual(expected, counter);
        }

        //==============================================================

        [TestMethod]
        public void CreateFullPaymentPercentageDiscountConstraint_OutsideLowerBoundry_Exception()
        {
            //Assemble
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            ProgramVarietyModel programVarietyModel = new ProgramVarietyModel();
            programVarietyModel.depositAmount = 50.0;
            programVarietyModel.sessionCost = 50.0;
            programVarietyModel.fullPaymentPercentageDiscount = -1.0;
            programVarietyModel.name = "Regular";
            programVarietyModel.noOfClasses = 10;
            programVarietyModel.dogSpacesMaximum = 9;
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programVarietyModel);
            }
            catch (Exception ex)
            {
                counter++;
            }

            //Assert
            Assert.AreEqual(expected, counter);
        }

        [TestMethod]
        public void CreateFullPaymentPercentageDiscountConstraint_OnLowerBoundry_NoException()
        {
            //Assemble
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            ProgramVarietyModel programVarietyModel = new ProgramVarietyModel();
            programVarietyModel.depositAmount = 50.0;
            programVarietyModel.sessionCost = 50.0;
            programVarietyModel.fullPaymentPercentageDiscount = 0.0;
            programVarietyModel.name = "Regular";
            programVarietyModel.noOfClasses = 10;
            programVarietyModel.dogSpacesMaximum = 9;
            int expected = 0;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programVarietyModel);
            }
            catch (Exception ex)
            {
                counter++;
            }

            //Assert
            Assert.AreEqual(expected, counter);
        }

        [TestMethod]
        public void CreateFullPaymentPercentageDiscountConstraint_OutsideUpperBoundry_Exception()
        {
            //Assemble
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            ProgramVarietyModel programVarietyModel = new ProgramVarietyModel();
            programVarietyModel.depositAmount = 50.0;
            programVarietyModel.sessionCost = 50.0;
            programVarietyModel.fullPaymentPercentageDiscount = 101.0;
            programVarietyModel.name = "Regular";
            programVarietyModel.noOfClasses = 10;
            programVarietyModel.dogSpacesMaximum = 9;
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programVarietyModel);
            }
            catch (Exception ex)
            {
                counter++;
            }

            //Assert
            Assert.AreEqual(expected, counter);
        }

        [TestMethod]
        public void CreateFullPaymentPercentageDiscountConstraint_OnUpperBoundry_NoException()
        {
            //Assemble
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            ProgramVarietyModel programVarietyModel = new ProgramVarietyModel();
            programVarietyModel.depositAmount = 50.0;
            programVarietyModel.sessionCost = 50.0;
            programVarietyModel.fullPaymentPercentageDiscount = 100.0;
            programVarietyModel.name = "Regular";
            programVarietyModel.noOfClasses = 10;
            programVarietyModel.dogSpacesMaximum = 9;
            int expected = 0;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programVarietyModel);
            }
            catch (Exception ex)
            {
                counter++;
            }

            //Assert
            Assert.AreEqual(expected, counter);
        }

        //==============================================================

        [TestMethod]
        public void CreateNumClassesConstraint_OutsideLowerBoundry_Exception()
        {
            //Assemble
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            ProgramVarietyModel programVarietyModel = new ProgramVarietyModel();
            programVarietyModel.depositAmount = 50.0;
            programVarietyModel.sessionCost = 50.0;
            programVarietyModel.fullPaymentPercentageDiscount = 10;
            programVarietyModel.name = "Regular";
            programVarietyModel.noOfClasses = 0;
            programVarietyModel.dogSpacesMaximum = 9;
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programVarietyModel);
            }
            catch (Exception ex)
            {
                counter++;
            }

            //Assert
            Assert.AreEqual(expected, counter);
        }

        [TestMethod]
        public void CreateNumClassesConstraint_OnLowerBoundry_NoException()
        {
            //Assemble
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            ProgramVarietyModel programVarietyModel = new ProgramVarietyModel();
            programVarietyModel.depositAmount = 50.0;
            programVarietyModel.sessionCost = 50.0;
            programVarietyModel.fullPaymentPercentageDiscount = 10.0;
            programVarietyModel.name = "Regular";
            programVarietyModel.noOfClasses = 1;
            programVarietyModel.dogSpacesMaximum = 9;
            int expected = 0;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programVarietyModel);
            }
            catch (Exception ex)
            {
                counter++;
            }

            //Assert
            Assert.AreEqual(expected, counter);
        }

        [TestMethod]
        public void CreateNumClassesConstraint_OutsideUpperBoundry_Exception()
        {
            //Assemble
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            ProgramVarietyModel programVarietyModel = new ProgramVarietyModel();
            programVarietyModel.depositAmount = 50.0;
            programVarietyModel.sessionCost = 50.0;
            programVarietyModel.fullPaymentPercentageDiscount = 50.0;
            programVarietyModel.name = "Regular";
            programVarietyModel.noOfClasses = 101;
            programVarietyModel.dogSpacesMaximum = 9;
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programVarietyModel);
            }
            catch (Exception ex)
            {
                counter++;
            }

            //Assert
            Assert.AreEqual(expected, counter);
        }

        [TestMethod]
        public void CreateNumClassesConstraint_OnUpperBoundry_NoException()
        {
            //Assemble
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            ProgramVarietyModel programVarietyModel = new ProgramVarietyModel();
            programVarietyModel.depositAmount = 50.0;
            programVarietyModel.sessionCost = 50.0;
            programVarietyModel.fullPaymentPercentageDiscount = 10.0;
            programVarietyModel.name = "Regular";
            programVarietyModel.noOfClasses = 100;
            programVarietyModel.dogSpacesMaximum = 9;
            int expected = 0;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programVarietyModel);
            }
            catch (Exception ex)
            {
                counter++;
            }

            //Assert
            Assert.AreEqual(expected, counter);
        }



        //==============================================================

        [TestMethod]
        public void CreateMaxDogsConstraint_OutsideLowerBoundry_Exception()
        {
            //Assemble
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            ProgramVarietyModel programVarietyModel = new ProgramVarietyModel();
            programVarietyModel.depositAmount = 50.0;
            programVarietyModel.sessionCost = 50.0;
            programVarietyModel.fullPaymentPercentageDiscount = 10;
            programVarietyModel.name = "Regular";
            programVarietyModel.noOfClasses = 10;
            programVarietyModel.dogSpacesMaximum = 0 ;
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programVarietyModel);
            }
            catch (Exception ex)
            {
                counter++;
            }

            //Assert
            Assert.AreEqual(expected, counter);
        }

        [TestMethod]
        public void CreateMaxDogsConstraint_OnLowerBoundry_NoException()
        {
            //Assemble
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            ProgramVarietyModel programVarietyModel = new ProgramVarietyModel();
            programVarietyModel.depositAmount = 50.0;
            programVarietyModel.sessionCost = 50.0;
            programVarietyModel.fullPaymentPercentageDiscount = 10.0;
            programVarietyModel.name = "Regular";
            programVarietyModel.noOfClasses = 10;
            programVarietyModel.dogSpacesMaximum = 1;
            int expected = 0;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programVarietyModel);
            }
            catch (Exception ex)
            {
                counter++;
            }

            //Assert
            Assert.AreEqual(expected, counter);
        }

        [TestMethod]
        public void CreateMaxDogsConstraint_OutsideUpperBoundry_Exception()
        {
            //Assemble
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            ProgramVarietyModel programVarietyModel = new ProgramVarietyModel();
            programVarietyModel.depositAmount = 50.0;
            programVarietyModel.sessionCost = 50.0;
            programVarietyModel.fullPaymentPercentageDiscount = 50.0;
            programVarietyModel.name = "Regular";
            programVarietyModel.noOfClasses = 10;
            programVarietyModel.dogSpacesMaximum = 101;
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programVarietyModel);
            }
            catch (Exception ex)
            {
                counter++;
            }

            //Assert
            Assert.AreEqual(expected, counter);
        }

        [TestMethod]
        public void CreateMaxDogsConstraint_OnUpperBoundry_NoException()
        {
            //Assemble
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            ProgramVarietyModel programVarietyModel = new ProgramVarietyModel();
            programVarietyModel.depositAmount = 50.0;
            programVarietyModel.sessionCost = 50.0;
            programVarietyModel.fullPaymentPercentageDiscount = 10.0;
            programVarietyModel.name = "Regular";
            programVarietyModel.noOfClasses = 10;
            programVarietyModel.dogSpacesMaximum = 100;
            int expected = 0;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programVarietyModel);
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

