using System;

namespace _03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int numOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double sum = 0;

            if (flowers == "Roses")
            {
                sum = numOfFlowers * 5;

                if (numOfFlowers > 80)
                {
                    sum *= 0.9;
                }
            }
            else if (flowers == "Dahlias")
            {
                sum = numOfFlowers * 3.8;

                if (numOfFlowers > 90)
                {
                    sum *= 0.85;
                }
            }
            else if (flowers == "Tulips")
            {
                sum = numOfFlowers * 2.8;

                if (numOfFlowers > 80)
                {
                    sum *= 0.85;
                }
            }
            else if (flowers == "Narcissus")
            {
                sum = numOfFlowers * 3;

                if (numOfFlowers < 120)
                {
                    sum = sum + (sum * 0.15);
                }
            }
            else if (flowers == "Gladiolus")
            {
                sum = numOfFlowers * 2.5;

                if (numOfFlowers < 80)
                {
                    sum = sum + (sum * 0.2);
                }
            }

            if (sum <= budget)
            {
                double moneyLeft = budget - sum;
                Console.WriteLine($"Hey, you have a great garden with {numOfFlowers} {flowers} and {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyRequired = sum - budget;
                Console.WriteLine($"Not enough money, you need {moneyRequired:f2} leva more.");
            }
        }
    }
}
