using System;

namespace _04.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int toys = 0;
            double money = 0.0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += i * 5 - 1;
                }
                else if (i % 2 == 1)
                {
                    toys++;
                }
            }

            double toysProfit = toys * toyPrice;

            double sum = money + toysProfit;

            if (washingMachinePrice <= sum)
            {
                Console.WriteLine("Yes! {0:f2}", sum - washingMachinePrice);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", washingMachinePrice - sum);
            }
        }
    }
}
