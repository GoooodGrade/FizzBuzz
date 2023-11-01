using System;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public string SpeakNumber(int number)
        {
            if (number % 3 != 0 && number % 5 == 0)
            {
                return "Buzz";
            }
            else if (number % 3 == 0 && number % 5 != 0)
            {
                return "Fizz";
            }
            else if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            return number.ToString();
        }
    }
}
