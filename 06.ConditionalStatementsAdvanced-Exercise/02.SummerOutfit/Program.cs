using System;

namespace _02.SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degreese = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            string outfit = string.Empty;
            string shoes = string.Empty;

            if (time == "Morning")
            {
                if (degreese >= 10 && degreese <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (degreese > 18 &&degreese <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degreese >= 25)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (time == "Afternoon")
            {
                if (degreese >= 10 && degreese <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degreese > 18 && degreese <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (degreese >= 25)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else if (time == "Evening")
            {
                if (degreese >= 10 && degreese <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degreese > 18 && degreese <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degreese >= 25)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }

            Console.WriteLine($"It's {degreese} degrees, get your {outfit} and {shoes}.");
        }
    }
}
