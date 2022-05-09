using System;

namespace _09.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int stay = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string evaluation = Console.ReadLine();

            double roomPrice = 0;
            double sum = 0;

            if (room == "room for one person")
            {
                roomPrice = 18;
            }
            else if (room == "apartment")
            {
                roomPrice = 25;
                
                if (stay <= 10)
                {
                    roomPrice *= 0.70;
                }
                else if (stay > 10 && stay <= 15)
                {
                    roomPrice *= 0.65;
                }
                else if (stay > 15)
                {
                    roomPrice *= 0.5;
                }                
            }
            else if (room == "president apartment")
            {
                roomPrice = 35;

                if (stay <= 10)
                {
                    roomPrice *= 0.9;
                }
                else if (stay > 10 && stay <= 15)
                {
                    roomPrice *= 0.85;
                }
                else if (stay > 15)
                {
                    roomPrice *= 0.8;
                }
            }

            if (evaluation == "positive")
            {
                roomPrice *= 1.25;
            }
            else if (evaluation == "negative")
            {
                roomPrice *= 0.9;
            }

            Console.WriteLine($"{(stay - 1) * roomPrice:f2}");
        }
    }
}
