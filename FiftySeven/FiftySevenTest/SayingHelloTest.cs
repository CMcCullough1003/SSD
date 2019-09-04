using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FiftySevenTest
{
    [TestClass]
    public class SayingHelloTest
    {
        [TestMethod]
        public void message_nullParameters_blankString()
        {
            //assemble
            const string expected = "";
            var sayingHello = new FiftySeven.SayingHello();

            //act
            var actual = sayingHello.message(null, null);

            //assert
            Assert.AreEqual(expected, actual);      
        }

        [TestMethod]
        public void message_nullName_greetingOnly()
        {
            //assemble
            const string hello = "Hello";
            const string expected = hello;
            var sayingHello = new FiftySeven.SayingHello();

            //act
            var actual = sayingHello.message(hello, null);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void message_emptyName_greetingOnly()
        {
            //assemble
            const string hello = "Hello";
            const string expected = hello;
            var sayingHello = new FiftySeven.SayingHello();

            //act
            var actual = sayingHello.message(hello, "");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void message_nullGreeting_nameOnly()
        {
            //assemble
            const string cameron = "Cameron";
            const string expected = cameron;
            var sayingHello = new FiftySeven.SayingHello();

            //act
            var actual = sayingHello.message(null, cameron);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void message_emptyGreeting_nameOnly()
        {
            //assemble
            const string cameron = "Cameron";
            const string expected = cameron;
            var sayingHello = new FiftySeven.SayingHello();

            //act
            var actual = sayingHello.message("", cameron);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void message_correct_greetingAndName()
        {
            //assemble
            const string hello = "Hello";
            const string cameron = "Cameron";
            const string expected = hello + " " + cameron;
            var sayingHello = new FiftySeven.SayingHello();

            //act
            var actual = sayingHello.message(hello, cameron);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
