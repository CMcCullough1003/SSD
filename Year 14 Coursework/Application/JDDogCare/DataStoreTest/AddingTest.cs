using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStore;


namespace DataStoreTest
{
    [TestClass]
    public class AddingTest
    {
        [TestMethod]
        public void TestAdd()
        {
            //Assemble
            int first = 2;
            int second = 3;
            int expected = 5;
            Adding adding = new Adding();

            //Act
            int actual = adding.add(first, second);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

