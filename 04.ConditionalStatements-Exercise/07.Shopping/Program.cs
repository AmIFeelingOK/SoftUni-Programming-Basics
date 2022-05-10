using System;

namespace _07.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int graphicsCard = int.Parse(Console.ReadLine());
            int cpu = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double cardsPrice = graphicsCard * 250;
            double cpuPrice = cpu * (cardsPrice * 0.35);
            double ramPrice = ram * (cardsPrice * 0.10);

            double totalSum = cardsPrice + cpuPrice + ramPrice;

            if (graphicsCard > cpu)
            {
                totalSum *= 0.85;
            }

            if (totalSum <= budget)
            {
                double moneyLeft = budget - totalSum;
                Console.WriteLine($"You have {moneyLeft:f2} leva left!");
            }
            else
            {
                double moneyRequired = totalSum - budget;
                Console.WriteLine($"Not enough money! You need {moneyRequired:f2} leva more!");
            }
        }
    }
}
