using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FiftySevenTest
{
    [TestClass]
    public class CountingCharactersTest
    {
        [TestMethod]
        public void characterCount_nullParameters_lengh0()
        {
            //assemble
            const int expected = 0;
            var countingCharacters = new FiftySeven.CountingCharacters();

            //act
            var actual = countingCharacters.characterCount(null);

            //assert
            Assert.AreEqual(expected, actual);      
        }

        [TestMethod]
        public void characterCount_emptyString_lengh0()
        {
            //assemble
            const int expected = 0;
            var countingCharacters = new FiftySeven.CountingCharacters();

            //act
            var actual = countingCharacters.characterCount("");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void characterCount_2CharString_lengh2()
        {
            //assemble
            const int expected = 2;
            var countingCharacters = new FiftySeven.CountingCharacters();

            //act
            var actual = countingCharacters.characterCount("ef");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void response_nullWord_Error()
        {
            //assemble
            const string expected = "ERROR";
            var countingCharacters = new FiftySeven.CountingCharacters();

            //act
            var actual = countingCharacters.response(null, 0);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void response_validParameters_CorrectResponse()
        {
            //assemble
            const string expected = "Hello has 5 characters";
            var countingCharacters = new FiftySeven.CountingCharacters();

            //act
            var actual = countingCharacters.response("Hello", 5);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
