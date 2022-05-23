using System;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());

            double coins = Math.Round(money * 100, 2);

            int counter = 0;

            while (coins > 0)
            {
                if (coins >= 200)
                {
                    counter++; coins -= 200;
                }
                else if (coins >= 100)
                {
                    counter++; coins -= 100;
                }
                else if (coins >= 50)
                {
                    counter++; coins -= 50;
                }
                else if (coins >= 20)
                {
                    counter++; coins -= 20;
                }
                else if (coins >= 10)
                {
                    counter++; coins -= 10;
                }
                else if (coins >= 5)
                {
                    counter++; coins -= 5;
                }
                else if (coins >= 2)
                {
                    counter++; coins -= 2;
                }
                else if (coins >= 1)
                {
                    counter++; coins -= 1;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
