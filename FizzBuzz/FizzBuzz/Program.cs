namespace FizzBuzz
{
    using System;
    using System.Collections.Generic;
    using FizzBuzz.Services;
    using FizzBuzz.Services.Interfaces;

    class Program
    {
        static void Main(string[] args)
        {
            IDataGenerator generator = new DataGenerator();
            IProcessor processor = new Processor();

            IEnumerable<int> dataset = generator.CreateDataset(
                start: 1, end: 100, increment: 1);

            foreach(int number in dataset)
            {
                string result = processor.ProcessNumber(number);   
                Console.WriteLine(result);
            }
        }
    }
}
