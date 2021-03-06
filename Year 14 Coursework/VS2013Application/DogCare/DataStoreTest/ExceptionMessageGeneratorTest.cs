﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStore;


namespace DataStoreTest
{
    [TestClass]
    public class ExceptionMessageGeneratorTest
    {

        [TestMethod]
        public void MessageGenerator_PopulatedMessage_SimpleMessage()
        {
            //Assemble
            string expected = "Oops! Something has gone wrong. Please contact the system administrator\n\nabc";
            ExceptionMessageGenerator exceptionMessageGenerator = new ExceptionMessageGenerator();
            string exceptionMessage = "abc";

            //Act
            string actual = exceptionMessageGenerator.generateMessage(exceptionMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageGenerator_ClientName_ClientMessage()
        {
            //Assemble
            string expected = "Name must be at least 3 characters";
            ExceptionMessageGenerator exceptionMessageGenerator = new ExceptionMessageGenerator();
            string exceptionMessage = "shshshshshshCK__Client__Namedhdhdhdhdhdh";

            //Act
            string actual = exceptionMessageGenerator.generateMessage(exceptionMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageGenerator_ClientPhone_ClientMessage()
        {
            //Assemble
            string expected = "Phone must be at least 10 characters";
            ExceptionMessageGenerator exceptionMessageGenerator = new ExceptionMessageGenerator();
            string exceptionMessage = "shshshshshshCK__Client__Phonedhdhdhdhdhdh";

            //Act
            string actual = exceptionMessageGenerator.generateMessage(exceptionMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageGenerator_ClientEmail_ClientMessage()
        {
            //Assemble
            string expected = "Email must be at least 7 characters";
            ExceptionMessageGenerator exceptionMessageGenerator = new ExceptionMessageGenerator();
            string exceptionMessage = "shshshshshshCK__Client__Emaildhdhdhdhdhdh";

            //Act
            string actual = exceptionMessageGenerator.generateMessage(exceptionMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageGenerator_Staff_StaffMessage()
        {
            //Assemble
            string expected = "Name must be at least 3 characters";
            ExceptionMessageGenerator exceptionMessageGenerator = new ExceptionMessageGenerator();
            string exceptionMessage = "shshshshshshCK__Staff__Namedhdhdhdhdhdh";

            //Act
            string actual = exceptionMessageGenerator.generateMessage(exceptionMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageGenerator_ProgramTypeDescription_ProgramTypeMessage()
        {
            //Assemble
            string expected = "Description must be either regular or advanced";
            ExceptionMessageGenerator exceptionMessageGenerator = new ExceptionMessageGenerator();
            string exceptionMessage = "shshshshshshCK__ProgramType__Descriptiondhdhdhdhdhdh";

            //Act
            string actual = exceptionMessageGenerator.generateMessage(exceptionMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageGenerator_ProgramCostDeposit_ProgramCostMessage()
        {
            //Assemble
            string expected = "Deposit must be between £20 and £100";
            ExceptionMessageGenerator exceptionMessageGenerator = new ExceptionMessageGenerator();
            string exceptionMessage = "shshshshshshCK__ProgramCo__Deposdhdhdhdhdhdh";

            //Act
            string actual = exceptionMessageGenerator.generateMessage(exceptionMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageGenerator_ProgramCostSessionCost_ProgramCostMessage()
        {
            //Assemble
            string expected = "Session cost must be between £20 and £100";
            ExceptionMessageGenerator exceptionMessageGenerator = new ExceptionMessageGenerator();
            string exceptionMessage = "shshshshshshCK__ProgramCo__Sessidhdhdhdhdhdh";

            //Act
            string actual = exceptionMessageGenerator.generateMessage(exceptionMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageGenerator_ProgramCostFullPaymentPercentageDiscount_ProgramCostMessage()
        {
            //Assemble
            string expected = "Percentage discount must be between 0% and 100%";
            ExceptionMessageGenerator exceptionMessageGenerator = new ExceptionMessageGenerator();
            string exceptionMessage = "shshshshshshCK__ProgramCo__FullPdhdhdhdhdhdh";

            //Act
            string actual = exceptionMessageGenerator.generateMessage(exceptionMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageGenerator_NumberOfClasses_ProgramCostMessage()
        {
            //Assemble
            string expected = "Number of classes should be between 1 and 100";
            ExceptionMessageGenerator exceptionMessageGenerator = new ExceptionMessageGenerator();
            string exceptionMessage = "shshshshshshCK__ProgramVa__NoOfCdhdhdhdhdhdh";

            //Act
            string actual = exceptionMessageGenerator.generateMessage(exceptionMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageGenerator_NumberOfDogs_ProgramCostMessage()
        {
            //Assemble
            string expected = "Number of dogs should be between 1 and 100";
            ExceptionMessageGenerator exceptionMessageGenerator = new ExceptionMessageGenerator();
            string exceptionMessage = "shshshshshshCK__ProgramVa__DogSpdhdhdhdhdhdh";

            //Act
            string actual = exceptionMessageGenerator.generateMessage(exceptionMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }

                [TestMethod]
        public void MessageGenerator_DuplicateEnrollment_EnrollmentMessage()
        {
            //Assemble
            string expected = "Could not enroll. This dog is already enrolled in this program";
            ExceptionMessageGenerator exceptionMessageGenerator = new ExceptionMessageGenerator();
            string exceptionMessage = "CK__Enrollment__DuplicateEnrollment";

            //Act
            string actual = exceptionMessageGenerator.generateMessage(exceptionMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}