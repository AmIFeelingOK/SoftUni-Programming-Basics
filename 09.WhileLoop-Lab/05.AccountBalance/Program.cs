using System;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double sum = 0.0;

            while (input != "NoMoreMoney")
            {
                double money = double.Parse(input);

                if (money >= 0)
                {
                    sum += money;
                    Console.WriteLine("Increase: {0:f2}", money);
                    input = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
            }

            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
