using System;

namespace _07.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int min = int.MaxValue;

            while (command != "Stop")
            {
                int numbers = int.Parse(command);

                if (min > numbers)
                {
                    min = numbers;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(min);
        }
    }
}
