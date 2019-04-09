using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumberGenerator = new Random();

            for (int i = 0; i < 40; i++)
            {
                string uniqueDigit = string.Concat(
                    randomNumberGenerator.Next(0, 9),
                    randomNumberGenerator.Next(0, 9),
                    randomNumberGenerator.Next(0, 9),
                    randomNumberGenerator.Next(0, 9)
                    );

                Console.WriteLine(uniqueDigit);
            }

            Console.ReadLine();
        }
    }
}
