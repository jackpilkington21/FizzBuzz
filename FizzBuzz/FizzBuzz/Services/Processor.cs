namespace FizzBuzz.Services
{
    using FizzBuzz.Services.Interfaces;

    /// <summary>
    /// Class to process numbers to determine output
    /// </summary>
    public class Processor : IProcessor
    {
        public Processor()
        {
        }

        /// <summary>
        /// Process number and return correct string for number.
        /// </summary>
        /// <param name="number">Integer number to process</param>
        /// <returns>String output</returns>
        public string ProcessNumber(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}
