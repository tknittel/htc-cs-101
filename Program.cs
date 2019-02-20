using System;

namespace Week_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number between 1 and 10");
            int guessedNumber = Convert.ToInt32(Console.ReadLine());

            if (guessedNumber > 4)
            {
                Console.WriteLine("Too high!");
            }
            else if (guessedNumber < 4)
            {
                Console.WriteLine("Too low!");
            }
            else
            {
                Console.WriteLine("Just right!");
            }
        }
    }
}
