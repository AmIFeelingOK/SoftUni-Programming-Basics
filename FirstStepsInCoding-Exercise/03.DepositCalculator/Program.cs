using System;

namespace _03.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int deadline = int.Parse(Console.ReadLine());
            double annualInterest = double.Parse(Console.ReadLine());
            double percentInterest = annualInterest / 100;

            double sum = deposit + (deadline * (deposit * percentInterest / 12));

            Console.WriteLine(sum);
        }
    }
}
