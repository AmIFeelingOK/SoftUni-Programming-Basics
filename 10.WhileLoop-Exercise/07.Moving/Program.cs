using System;

namespace _07.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int box = width * length * height;

            string command = Console.ReadLine();

            while (command != "Done")
            {
                int input = int.Parse(command);

                box -= input;
                
                if (box < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(box)} Cubic meters more.");
                    return;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{box} Cubic meters left.");
        }
    }
}
