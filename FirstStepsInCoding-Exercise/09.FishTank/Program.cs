using System;

namespace _09.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = length * width * height;

            double liters = volume / 1000;

            double filledArea = percent / 100;

            double litersRequired = liters * (1 - filledArea);

            Console.WriteLine(litersRequired);
        }
    }
}
