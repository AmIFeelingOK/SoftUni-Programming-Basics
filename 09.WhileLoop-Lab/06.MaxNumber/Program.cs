using System;

namespace _06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int max = int.MinValue;

            while (command != "Stop")
            {
                int numbers = int.Parse(command);

                if (max < numbers)
                {
                    max = numbers;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(max);
        }
    }
}
