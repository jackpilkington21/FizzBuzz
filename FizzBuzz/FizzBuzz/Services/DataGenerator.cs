namespace FizzBuzz.Services
{
    using System.Collections.Generic;
    using FizzBuzz.Services.Interfaces;

    public class DataGenerator : IDataGenerator
    {
        public DataGenerator()
        {
        }

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
