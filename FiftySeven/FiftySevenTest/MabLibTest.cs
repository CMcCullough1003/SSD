using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FiftySevenTest
{
    [TestClass]
    public class MabLibTest
    {
        [TestMethod]
        public void funnyPhrase_nullNoun_Error()
        {
            //assemble
            const string expected = "ERROR";
            var madLib = new FiftySeven.MadLib();

            //act
            var actual = madLib.funnyPhrase(null, "walk", "blue", "quickly");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void funnyPhrase_nullVerb_Error()
        {
            //assemble
            const string expected = "ERROR";
            var madLib = new FiftySeven.MadLib();

            //act
            var actual = madLib.funnyPhrase("dog", null, "blue", "quickly");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void funnyPhrase_nullAdjective_Error()
        {
            //assemble
            const string expected = "ERROR";
            var madLib = new FiftySeven.MadLib();

            //act
            var actual = madLib.funnyPhrase("dog", "walk", null, "quickly");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void funnyPhrase_nullAdverb_Error()
        {
            //assemble
            const string expected = "ERROR";
            var madLib = new FiftySeven.MadLib();

            //act
            var actual = madLib.funnyPhrase("dog", "walk", "blue", null);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void funnyPhrase_blankNoun_Error()
        {
            //assemble
            const string expected = "ERROR";
            var madLib = new FiftySeven.MadLib();

            //act
            var actual = madLib.funnyPhrase("", "walk", "blue", "quickly");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void funnyPhrase_blankVerb_Error()
        {
            //assemble
            const string expected = "ERROR";
            var madLib = new FiftySeven.MadLib();

            //act
            var actual = madLib.funnyPhrase("dog", "", "blue", "quickly");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void funnyPhrase_blankAdjective_Error()
        {
            //assemble
            const string expected = "ERROR";
            var madLib = new FiftySeven.MadLib();

            //act
            var actual = madLib.funnyPhrase("dog", "walk", "", "quickly");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void funnyPhrase_blankAdverb_Error()
        {
            //assemble
            const string expected = "ERROR";
            var madLib = new FiftySeven.MadLib();

            //act
            var actual = madLib.funnyPhrase("dog", "walk", "blue", "");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void funnyPhrase_correctPerameters_success()
        {
            //assemble
            const string expected = "Do you walk your blue dog quickly? That's hillarious!";
            var madLib = new FiftySeven.MadLib();

            //act
            var actual = madLib.funnyPhrase("dog", "walk", "blue", "quickly");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void funnyPhrase_onlySpaceNoun_Error()
        {
            //assemble
            const string expected = "ERROR";
            var madLib = new FiftySeven.MadLib();

            //act
            var actual = madLib.funnyPhrase(" ", "walk", "blue", "quickly");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void funnyPhrase_onlySpaceVerb_Error()
        {
            //assemble
            const string expected = "ERROR";
            var madLib = new FiftySeven.MadLib();

            //act
            var actual = madLib.funnyPhrase("dog", " ", "blue", "quickly");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void funnyPhrase_onlySpaceAdjective_Error()
        {
            //assemble
            const string expected = "ERROR";
            var madLib = new FiftySeven.MadLib();

            //act
            var actual = madLib.funnyPhrase("dog", "walk", " ", "quickly");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void funnyPhrase_onlySpaceAdverb_Error()
        {
            //assemble
            const string expected = "ERROR";
            var madLib = new FiftySeven.MadLib();

            //act
            var actual = madLib.funnyPhrase("dog", "walk", "blue", " ");

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}