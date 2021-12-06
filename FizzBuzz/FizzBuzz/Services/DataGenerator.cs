namespace FizzBuzz.Services
{
    using System.Collections.Generic;
    using FizzBuzz.Services.Interfaces;

    /// <summary>
    /// Class to generate dataset to process.
    /// </summary>
    public class DataGenerator : IDataGenerator
    {
        public DataGenerator()
        {
        }

        /// <summary>
        /// Create a dataset depending on inputs
        /// </summary>
        /// <param name="start">Number to start dataset at</param>
        /// <param name="end">Number to end dataset at</param>
        /// <param name="increment">Step increment for dataset</param>
        /// <returns>List of numbers</returns>
        public IEnumerable<int> CreateDataset(int start, int end, int increment)
        {
            List<int> dataset = new List<int>();

            for(int i = start; i <= end; i += increment)
            {
                dataset.Add(i);
            }

            return dataset;
        }
    }
}
