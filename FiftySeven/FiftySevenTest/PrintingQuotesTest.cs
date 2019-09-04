using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FiftySevenTest
{
    [TestClass]
    public class PrintingQuotesTest
    {
        [TestMethod]
        public void WhoSaidWhat_nullQuote_Error()
        {
            //assemble
            const string expected = "ERROR";
            var printingQuotes = new FiftySeven.PrintingQuotes();

            //act
            var actual = printingQuotes.whoSaidWhat(null, "");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhoSaidWhat_nullAuthor_Error()
        {
            //assemble
            const string expected = "ERROR";
            var printingQuotes = new FiftySeven.PrintingQuotes();

            //act
            var actual = printingQuotes.whoSaidWhat("", null);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhoSaidWhat_EmptyQuote_Error()
        {
            //assemble
            const string expected = "ERROR";
            var printingQuotes = new FiftySeven.PrintingQuotes();

            //act
            var actual = printingQuotes.whoSaidWhat("", "Bob");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhoSaidWhat_EmptyAuthor_Error()
        {
            //assemble
            const string expected = "ERROR";
            var printingQuotes = new FiftySeven.PrintingQuotes();

            //act
            var actual = printingQuotes.whoSaidWhat("Hello", "");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhoSaidWhat_OnlySpacesQuote_Error()
        {
            //assemble
            const string expected = "ERROR";
            var printingQuotes = new FiftySeven.PrintingQuotes();

            //act
            var actual = printingQuotes.whoSaidWhat(" ", "Hello");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhoSaidWhat_OnlySpacesAuthor_Error()
        {
            //assemble
            const string expected = "ERROR";
            var printingQuotes = new FiftySeven.PrintingQuotes();

            //act
            var actual = printingQuotes.whoSaidWhat("Bob", " ");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhoSaidWhat_ValidParameters_Success()
        {
            //assemble
            const string expected = "Bob said \"Hello\"";
            var printingQuotes = new FiftySeven.PrintingQuotes();

            //act
            var actual = printingQuotes.whoSaidWhat("Hello", "Bob");

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
