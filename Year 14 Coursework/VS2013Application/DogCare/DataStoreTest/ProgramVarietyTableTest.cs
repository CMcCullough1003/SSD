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
            ProgramVarietyModel programCostModel = new ProgramVarietyModel();
            programCostModel.depositAmount = 49.0;
            programCostModel.sessionCost = 50.0;
            programCostModel.fullPaymentPercentageDiscount = 51.0;
            programCostModel.name = "Advanced";
            //If created will be greater than 0, but we don't know exactly what it will be because deleting all records doesnt set the ID counter back to 0
            int notCreated = 0;
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();

            //Act
            int actual = programCostTable.create(programCostModel);

            //Assert
            Assert.AreNotEqual(notCreated, actual);
        }

        [TestMethod]
        public void Count_Created1Record_1()
        {
            //Assemble
            ProgramVarietyModel programCostModel = new ProgramVarietyModel();
            programCostModel.depositAmount = 49.0;
            programCostModel.sessionCost = 50.0;
            programCostModel.fullPaymentPercentageDiscount = 51.0;
            programCostModel.name = "Advanced";
            int expected = 1;
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();

            //Act
            int programCostID = programCostTable.create(programCostModel);
            int actual = programCostTable.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Read_CreatedAndRead1Record_CorrectValues()
        {
            //Assemble
            ProgramVarietyModel programCostModel = new ProgramVarietyModel();
            programCostModel.depositAmount = 49.0;
            programCostModel.sessionCost = 50.0;
            programCostModel.fullPaymentPercentageDiscount = 51.0;
            programCostModel.name = "Advanced";
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();

            //Act
            int programCostID = programCostTable.create(programCostModel);
            ProgramVarietyModel actual = programCostTable.read(programCostID);

            //Assert
            Assert.AreEqual(programCostModel.depositAmount, actual.depositAmount);
            Assert.AreEqual(programCostModel.sessionCost, actual.sessionCost);
            Assert.AreEqual(programCostModel.fullPaymentPercentageDiscount, actual.fullPaymentPercentageDiscount);
        }

        [TestMethod]
        public void ReadAll_Create3Records_CountIs3()
        {
            //Assemble
            ProgramVarietyModel programCostModel1 = new ProgramVarietyModel();
            programCostModel1.depositAmount = 49.1;
            programCostModel1.sessionCost = 50.1;
            programCostModel1.fullPaymentPercentageDiscount = 51.1;
            programCostModel1.name = "Advanced";

            ProgramVarietyModel programCostModel2 = new ProgramVarietyModel();
            programCostModel2.depositAmount = 49.2;
            programCostModel2.sessionCost = 50.2;
            programCostModel2.fullPaymentPercentageDiscount = 51.2;
            programCostModel2.name = "Advanced";

            ProgramVarietyModel programCostModel3 = new ProgramVarietyModel();
            programCostModel3.depositAmount = 49.3;
            programCostModel3.sessionCost = 50.3;
            programCostModel3.fullPaymentPercentageDiscount = 51.3;
            programCostModel3.name = "Advanced";

            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            int expected = 3;

            //Act
            int programCostID1 = programCostTable.create(programCostModel1);
            int programCostID2 = programCostTable.create(programCostModel2);
            int programCostID3 = programCostTable.create(programCostModel3);
            List<ProgramVarietyModel> actual = programCostTable.readAll();

            //Assert
            Assert.AreEqual(expected, actual.Count);
        }

        [TestMethod]
        public void ReadAll_Create3Records_3DifferentRecords()
        {
            //Assemble
            ProgramVarietyModel programCostModel1 = new ProgramVarietyModel();
            programCostModel1.depositAmount = 49.1;
            programCostModel1.sessionCost = 50.1;
            programCostModel1.fullPaymentPercentageDiscount = 51.1;
            programCostModel1.name = "Advanced";

            ProgramVarietyModel programCostModel2 = new ProgramVarietyModel();
            programCostModel2.depositAmount = 49.2;
            programCostModel2.sessionCost = 50.2;
            programCostModel2.fullPaymentPercentageDiscount = 51.2;
            programCostModel2.name = "Regular";

            ProgramVarietyModel programCostModel3 = new ProgramVarietyModel();
            programCostModel3.depositAmount = 49.3;
            programCostModel3.sessionCost = 50.3;
            programCostModel3.fullPaymentPercentageDiscount = 51.3;
            programCostModel3.name = "Advanced";

            ProgramVarietyTable programCostTable = new ProgramVarietyTable();

            //Act
            int programCostID1 = programCostTable.create(programCostModel1);
            int programCostID2 = programCostTable.create(programCostModel2);
            int programCostID3 = programCostTable.create(programCostModel3);
            List<ProgramVarietyModel> actual = programCostTable.readAll();

            //Assert
            Assert.AreEqual(programCostID1, programCostID1);
            Assert.AreEqual(programCostModel1.depositAmount, actual[0].depositAmount);
            Assert.AreEqual(programCostModel1.sessionCost, actual[0].sessionCost);
            Assert.AreEqual(programCostModel1.fullPaymentPercentageDiscount, actual[0].fullPaymentPercentageDiscount);
            Assert.AreEqual(programCostModel1.name, actual[0].name);

            Assert.AreEqual(programCostID2, programCostID2);
            Assert.AreEqual(programCostModel2.depositAmount, actual[1].depositAmount);
            Assert.AreEqual(programCostModel2.sessionCost, actual[1].sessionCost);
            Assert.AreEqual(programCostModel2.fullPaymentPercentageDiscount, actual[1].fullPaymentPercentageDiscount);
            Assert.AreEqual(programCostModel2.name, actual[1].name);

            Assert.AreEqual(programCostID3, programCostID3);
            Assert.AreEqual(programCostModel3.depositAmount, actual[2].depositAmount);
            Assert.AreEqual(programCostModel3.sessionCost, actual[2].sessionCost);
            Assert.AreEqual(programCostModel3.fullPaymentPercentageDiscount, actual[2].fullPaymentPercentageDiscount);
            Assert.AreEqual(programCostModel3.name, actual[2].name);

        }

        [TestMethod]
        public void Update_CreatedUpdateAndRead1Record_UpdatedValues()
        {
            //Assemble
            ProgramVarietyModel programCostModel = new ProgramVarietyModel();
            programCostModel.depositAmount = 49.0;
            programCostModel.sessionCost = 50.0;
            programCostModel.fullPaymentPercentageDiscount = 51.0;
            programCostModel.name = "Regular";

            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            int programCostID = programCostTable.create(programCostModel);

            programCostModel.id = programCostID;
            programCostModel.depositAmount = 49.1;
            programCostModel.sessionCost = 50.1;
            programCostModel.fullPaymentPercentageDiscount = 51.4;

            //Act
            programCostTable.update(programCostModel);
            ProgramVarietyModel actual = programCostTable.read(programCostID);

            //Assert
            Assert.AreEqual(programCostModel.depositAmount, actual.depositAmount);
            Assert.AreEqual(programCostModel.sessionCost, actual.sessionCost);
            Assert.AreEqual(programCostModel.fullPaymentPercentageDiscount, actual.fullPaymentPercentageDiscount);
        }

        [TestMethod]
        public void Delete_CreatedDeleteAndCount1Record_0()
        {
            //Assemble
            ProgramVarietyModel programCostModel = new ProgramVarietyModel();
            programCostModel.depositAmount = 49.0;
            programCostModel.sessionCost = 50.0;
            programCostModel.fullPaymentPercentageDiscount = 51.0;
            programCostModel.name = "Regular";
            int expected = 0;
            ProgramVarietyTable programCostTable = new ProgramVarietyTable();
            int programCostID = programCostTable.create(programCostModel);

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
            ProgramVarietyModel programCostModel = new ProgramVarietyModel();
            programCostModel.depositAmount = 19.0;
            programCostModel.sessionCost = 50.0;
            programCostModel.fullPaymentPercentageDiscount = 51.0;
            programCostModel.name = "Regular";
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programCostModel);
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
            ProgramVarietyModel programCostModel = new ProgramVarietyModel();
            programCostModel.depositAmount = 20.0;
            programCostModel.sessionCost = 50.0;
            programCostModel.fullPaymentPercentageDiscount = 51.0;
            programCostModel.name = "Regular";
            int expected = 0;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programCostModel);
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
            ProgramVarietyModel programCostModel = new ProgramVarietyModel();
            programCostModel.depositAmount = 101.0;
            programCostModel.sessionCost = 50.0;
            programCostModel.fullPaymentPercentageDiscount = 51.0;
            programCostModel.name = "Regular";
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programCostModel);
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
            ProgramVarietyModel programCostModel = new ProgramVarietyModel();
            programCostModel.depositAmount = 100.0;
            programCostModel.sessionCost = 50.0;
            programCostModel.fullPaymentPercentageDiscount = 51.0;
            programCostModel.name = "Regular";
            int expected = 0;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programCostModel);
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
            ProgramVarietyModel programCostModel = new ProgramVarietyModel();
            programCostModel.depositAmount = 50.0;
            programCostModel.sessionCost = 19.0;
            programCostModel.fullPaymentPercentageDiscount = 51.0;
            programCostModel.name = "Regular";
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programCostModel);
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
            ProgramVarietyModel programCostModel = new ProgramVarietyModel();
            programCostModel.depositAmount = 50.0;
            programCostModel.sessionCost = 20.0;
            programCostModel.fullPaymentPercentageDiscount = 51.0;
            programCostModel.name = "Regular";
            int expected = 0;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programCostModel);
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
            ProgramVarietyModel programCostModel = new ProgramVarietyModel();
            programCostModel.depositAmount = 50.0;
            programCostModel.sessionCost = 101.0;
            programCostModel.fullPaymentPercentageDiscount = 51.0;
            programCostModel.name = "Regular";
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programCostModel);
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
            ProgramVarietyModel programCostModel = new ProgramVarietyModel();
            programCostModel.depositAmount = 50.0;
            programCostModel.sessionCost = 100.0;
            programCostModel.fullPaymentPercentageDiscount = 51.0;
            programCostModel.name = "Regular";
            int expected = 0;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programCostModel);
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
            ProgramVarietyModel programCostModel = new ProgramVarietyModel();
            programCostModel.depositAmount = 50.0;
            programCostModel.sessionCost = 50.0;
            programCostModel.fullPaymentPercentageDiscount = -1.0;
            programCostModel.name = "Regular";
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programCostModel);
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
            ProgramVarietyModel programCostModel = new ProgramVarietyModel();
            programCostModel.depositAmount = 50.0;
            programCostModel.sessionCost = 50.0;
            programCostModel.fullPaymentPercentageDiscount = 0.0;
            programCostModel.name = "Regular";
            int expected = 0;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programCostModel);
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
            ProgramVarietyModel programCostModel = new ProgramVarietyModel();
            programCostModel.depositAmount = 50.0;
            programCostModel.sessionCost = 50.0;
            programCostModel.fullPaymentPercentageDiscount = 101.0;
            programCostModel.name = "Regular";
            int expected = 1;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programCostModel);
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
            ProgramVarietyModel programCostModel = new ProgramVarietyModel();
            programCostModel.depositAmount = 50.0;
            programCostModel.sessionCost = 50.0;
            programCostModel.fullPaymentPercentageDiscount = 100.0;
            programCostModel.name = "Regular";
            int expected = 0;
            int counter = 0;

            //Act
            try
            {
                int id = programCostTable.create(programCostModel);
            }
            catch (Exception ex)
            {
                counter++;
            }

            //Assert
            Assert.AreEqual(expected, counter);
        }

        /*     [TestMethod]
             public void CreateNameConstraint_NameLengthOk_NoException()
             {
                 //Assemble
                 ProgramCostTable programCostTable = new ProgramCostTable();
                 ProgramCostModel programCostModel = new ProgramCostModel();
                 programCostModel.name = "Bob";
                 programCostModel.phone = "07561 101169";
                 programCostModel.email = "bob@gmail.com";
                 int expected = 1;
                 int counter = 0;

                 //Act
                 try
                 {
                     int id = programCostTable.create(programCostModel);
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
                 ProgramCostTable programCostTable = new ProgramCostTable();
                 ProgramCostModel programCostModel = new ProgramCostModel();
                 programCostModel.name = "Bob";
                 programCostModel.phone = "123456789";
                 programCostModel.email = "bob@gmail.com";
                 int expected = 1;
                 int counter = 0;

                 //Act
                 try
                 {
                     int id = programCostTable.create(programCostModel);
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
                 ProgramCostTable programCostTable = new ProgramCostTable();
                 ProgramCostModel programCostModel = new ProgramCostModel();
                 programCostModel.name = "Bob";
                 programCostModel.phone = "1234567890";
                 programCostModel.email = "bob@gmail.com";
                 int expected = 1;
                 int counter = 0;

                 //Act
                 try
                 {
                     int id = programCostTable.create(programCostModel);
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
                 ProgramCostTable programCostTable = new ProgramCostTable();
                 ProgramCostModel programCostModel = new ProgramCostModel();
                 programCostModel.name = "Bob";
                 programCostModel.phone = "1234567890";
                 programCostModel.email = "a@b.co";
                 int expected = 1;
                 int counter = 0;

                 //Act
                 try
                 {
                     int id = programCostTable.create(programCostModel);
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
                 ProgramCostTable programCostTable = new ProgramCostTable();
                 ProgramCostModel programCostModel = new ProgramCostModel();
                 programCostModel.name = "Bob";
                 programCostModel.phone = "1234567890";
                 programCostModel.email = "a@b.com";
                 int expected = 1;
                 int counter = 0;

                 //Act
                 try
                 {
                     int id = programCostTable.create(programCostModel);
                     counter++;
                 }
                 catch (Exception ex)
                 {

                 }

                 //Assert
                 Assert.AreEqual(expected, counter);
             }

         */
    }
}

