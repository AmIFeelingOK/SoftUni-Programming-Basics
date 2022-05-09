using System;

namespace _05.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price;
            double productCost = 0.0;

            if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    price = 0.5;
                    productCost = quantity * price;
                }
                else if (product == "water")
                {
                    price = 0.8;
                    productCost = quantity * price;
                }
                else if (product == "beer")
                {
                    price = 1.2;
                    productCost = quantity * price;
                }
                else if (product == "sweets")
                {
                    price = 1.45;
                    productCost = quantity * price;
                }
                else if (product == "peanuts")
                {
                    price = 1.6;
                    productCost = quantity * price;
                }
            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    price = 0.4;
                    productCost = quantity * price;
                }
                else if (product == "water")
                {
                    price = 0.7;
                    productCost = quantity * price;
                }
                else if (product == "beer")
                {
                    price = 1.15;
                    productCost = quantity * price;
                }
                else if (product == "sweets")
                {
                    price = 1.3;
                    productCost = quantity * price;
                }
                else if (product == "peanuts")
                {
                    price = 1.5;
                    productCost = quantity * price;
                }
            }
            else if (city == "Varna")
            {
                if (product == "coffee")
                {
                    price = 0.45;
                    productCost = quantity * price;
                }
                else if (product == "water")
                {
                    price = 0.7;
                    productCost = quantity * price;
                }
                else if (product == "beer")
                {
                    price = 1.1;
                    productCost = quantity * price;
                }
                else if (product == "sweets")
                {
                    price = 1.35;
                    productCost = quantity * price;
                }
                else if (product == "peanuts")
                {
                    price = 1.55;
                    productCost = quantity * price;
                }
            }

            Console.WriteLine(productCost);
        }
    }
}
