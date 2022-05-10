using System;

namespace _05.GodzillaVs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double clothingPriceForOnePerson = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double clothingPrice = people * clothingPriceForOnePerson;
            
            if (people > 150)
            {
                clothingPrice *= 0.9;
            }

            double movieFunds = decor + clothingPrice;

            if (movieFunds <= budget)
            {
                double moneyLeft = budget - movieFunds;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyRequired = movieFunds - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyRequired:f2} leva more.");
            }
        }
    }
}
