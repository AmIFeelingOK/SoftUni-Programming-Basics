using System;

namespace fishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermans = int.Parse(Console.ReadLine());

            double shipCost = 0.0;

            if (season == "Spring")
            {
                shipCost = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                shipCost = 4200;
            }
            else if (season == "Winter")
            {
                shipCost = 2600;
            }

            if (fishermans <= 6)
            {

                shipCost *= 0.9;
            }
            else if (fishermans >= 7 && fishermans <= 11)
            {
                shipCost *= 0.85;
            }
            else if (fishermans >= 12)
            {
                shipCost *= 0.75;
            }

            if (fishermans % 2 == 0 && season != "Autumn")
            {
                shipCost *= 0.95;
            }

            if (shipCost > budget)
            {
                double moneyRequired = shipCost - budget;
                Console.WriteLine($"Not enough money! You need {moneyRequired:f2} leva.");
            }
            else if (shipCost <= budget)
            {
                double moneyLeft = budget - shipCost;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }

        }
    }
}