
using System;

namespace ConditionalStatementsAdvanced_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double income = 0;

            if (film == "Premiere")
            {
                income = rows * columns * 12;
            }
            else if (film == "Normal")
            {
                income = rows * columns * 7.50;
            }
            else if (film == "Discount")
            {
                income = rows * columns * 5;
            }

            Console.WriteLine($"{income:f2} leva");
        }
    }
}
