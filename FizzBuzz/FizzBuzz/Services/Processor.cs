namespace FizzBuzz.Services
{
    using FizzBuzz.Services.Interfaces;

    public class Processor : IProcessor
    {
        public Processor()
        {
        }

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
