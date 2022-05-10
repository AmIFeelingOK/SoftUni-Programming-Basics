using System;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = string.Empty;
            string place = string.Empty;
            double moneySpent = 0.0;

            if (budget > 1000)
            {
                destination = "Europe";
                moneySpent = budget * 0.9;
                place = "Hotel";
            }
            else if (budget <= 1000 && budget > 100)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    moneySpent = budget * 0.4;
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    moneySpent = budget * 0.8;
                    place = "Hotel";
                }
            }
            else if (budget <= 100)
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    moneySpent = budget * 0.3;
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    moneySpent = budget * 0.7;
                    place = "Hotel";
                }
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {moneySpent:f2}");
        }
    }
}
