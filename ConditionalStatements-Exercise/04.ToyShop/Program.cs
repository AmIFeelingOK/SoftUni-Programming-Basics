using System;

namespace _04.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tourPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int toys = puzzles + dolls + teddyBears + minions + trucks;

            double sum = (puzzles * 2.60)
                + (dolls * 3)
                + (teddyBears * 4.10)
                + (minions * 8.20)
                + (trucks * 2);

            if (toys >= 50)
            {
                sum *= 0.75;
            }

            double rent = sum * 0.10;

            double finalSum = sum - rent;

            if (finalSum >= tourPrice)
            {
                double moneyRemaining = finalSum - tourPrice;
                Console.WriteLine($"Yes! {moneyRemaining:f2} lv left.");
            }
            else
            {
                double moneyNeeded = tourPrice - finalSum;
                Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
            }
        }
    }
}
