using System;

namespace _05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            
            while (destination != "End")
            {                
                double budget = double.Parse(Console.ReadLine());

                double sum = 0;

                while (sum < budget)
                {
                    double savedMoney = double.Parse(Console.ReadLine());
                    sum += savedMoney;
                }

                if (sum >= budget)
                {
                    Console.WriteLine("Going to {0}!", destination);
                }

                destination = Console.ReadLine();
            }
        }
    }
}
