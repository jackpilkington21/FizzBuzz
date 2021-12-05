namespace FizzBuzz.Services.Interfaces
{
    using System.Collections.Generic;

    public interface IDataGenerator
    {
        IEnumerable<int> CreateDataset(int start, int end, int range);
    }
}
