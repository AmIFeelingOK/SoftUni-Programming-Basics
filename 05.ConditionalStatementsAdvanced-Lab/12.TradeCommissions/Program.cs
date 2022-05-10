using System;

namespace _12.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double commision = 0.0;

            if (city == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commision = 0.05;
                    Console.WriteLine($"{(sales * commision):f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commision = 0.07;
                    Console.WriteLine($"{(sales * commision):f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commision = 0.08;
                    Console.WriteLine($"{(sales * commision):f2}");
                }
                else if (sales > 10000)
                {
                    commision = 0.12;
                    Console.WriteLine($"{(sales * commision):f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commision = 0.045;
                    Console.WriteLine($"{(sales * commision):f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commision = 0.075;
                    Console.WriteLine($"{(sales * commision):f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commision = 0.1;
                    Console.WriteLine($"{(sales * commision):f2}");
                }
                else if (sales > 10000)
                {
                    commision = 0.13;
                    Console.WriteLine($"{(sales * commision):f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commision = 0.055;
                    Console.WriteLine($"{(sales * commision):f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commision = 0.08;
                    Console.WriteLine($"{(sales * commision):f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commision = 0.12;
                    Console.WriteLine($"{(sales * commision):f2}");
                }
                else if (sales > 10000)
                {
                    commision = 0.145;
                    Console.WriteLine($"{(sales * commision):f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }            
        }
    }
}
