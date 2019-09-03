
using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static string GetFizzBuzz(int number)
        {
            var result = "";

            if (number % 3 == 0 && number % 5 == 0)
            {
                result = "FizzBuzz";
            } else if (number % 5 == 0)
            {
                result = "Buzz";
            } else if (number % 3 == 0)
            {
                result = "Fizz";
            }
            else
            {
                result = Convert.ToString(number);
            }
            return result;
        }
    }
}
