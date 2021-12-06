namespace FizzBuzz.tests
{
    using FizzBuzz.Services;
    using FizzBuzz.Services.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ProcessorTests
    {
        private readonly IProcessor _processor;

        public ProcessorTests()
        {
            _processor = new Processor();
        }

        [TestMethod]
        public void GivenNumberDivisibleBy3ThenPrintFizz()
        {
            int testNumber = 6;
            string expectedResult = "Fizz";

            string actualResult = _processor.ProcessNumber(testNumber);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GivenNumberDivisibleBy5ThenPrintBuzz()
        {
            int testNumber = 20;
            string expectedResult = "Buzz";

            string actualResult = _processor.ProcessNumber(testNumber);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GivenNumberDivisibleBy3And5ThenPrintFizzBuzz()
        {
            int testNumber = 15;
            string expectedResult = "FizzBuzz";

            string actualResult = _processor.ProcessNumber(testNumber);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GivenNumberNotDivisibleBy3Or5ThenPrintNumber()
        {
            int testNumber = 7;
            string expectedResult = "7";

            string actualResult = _processor.ProcessNumber(testNumber);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
