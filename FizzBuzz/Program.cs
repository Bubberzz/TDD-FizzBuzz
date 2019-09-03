using System;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
           RunFizzBuzz();
        }

        private static void RunFizzBuzz()
        {
            var input = "";
            while (input != "q")
            {
                Console.WriteLine("Welcome to FizzBuzz\nby Stan Bubbers");
                Console.WriteLine("\nPlease enter a number:");
                try
                {
                    var number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"This number is: {FizzBuzz.GetFizzBuzz(number)}");
                }
                catch
                {
                    //ignore
                }
                Console.WriteLine("Press any key to restart or q to quit");
                input = Convert.ToString(Console.ReadLine());
                Console.Clear();
            }
            Console.Clear();
        }
    }
}
