namespace FizzBuzz.tests
{
    using System.Collections.Generic;
    using System.Linq;
    using FizzBuzz.Services;
    using FizzBuzz.Services.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DataGeneratorTests
    {
        private readonly IDataGenerator _dataGenerator;

        public DataGeneratorTests()
        {
            _dataGenerator = new DataGenerator();
        }

        [TestMethod]
        public void GivenStartEndIncrementThenDataCreatedWithCorrectCount()
        {
            int testStart = 1;
            int testEnd = 100;
            int testIncrement = 1;
            int expectedResult = 100;

            IEnumerable<int> testDataset = _dataGenerator.CreateDataset(
                testStart, testEnd, testIncrement);
            int actualResult = testDataset.Count();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
