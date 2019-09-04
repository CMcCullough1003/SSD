using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenge1;

namespace Challenge1Test
{
    [TestClass]
    public class WagesTest
    {
        [TestMethod]
        public void grossWeeklyWage_zeroRate_zeroWage()
        {
            //assemble
            Wages wages = new Wages();
            double expected = 0.00;

            //act
            double actual = wages.grossWeeklyWage(0);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
