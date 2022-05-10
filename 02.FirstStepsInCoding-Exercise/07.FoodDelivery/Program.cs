using System;

namespace _07.FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int veganMenus = int.Parse(Console.ReadLine());

            double sum = (chickenMenus * 10.35)
                + (fishMenus * 12.40)
                + (veganMenus * 8.15);

            double desert = sum * 0.20;

            double finalSum = sum + desert + 2.5;

            Console.WriteLine(finalSum);
        }
    }
}
