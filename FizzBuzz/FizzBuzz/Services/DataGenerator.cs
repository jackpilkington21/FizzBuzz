namespace FizzBuzz.Services
{
    using System;
    using System.Collections.Generic;
    using FizzBuzz.Services.Interfaces;

    public class DataGenerator : IDataGenerator
    {
        public DataGenerator()
        {
        }

        public IEnumerable<int> CreateDataset(int start, int end, int range)
        {
            throw new NotImplementedException();
        }
    }
}
