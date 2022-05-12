using System;

namespace _08.TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            int points = 0;
            int sumPoints = 0;          
            double winCount = 0;

            for (int i = 0; i < tournaments; i++)
            {
                string stage = Console.ReadLine();

                if (stage == "W")
                {
                    points += 2000;
                    winCount++;
                }
                else if (stage == "F")
                {
                    points += 1200;
                }
                else if (stage == "SF")
                {
                    points += 720;
                }
            }

            sumPoints += points;
            int avaregePoints = sumPoints / tournaments;
            double percantage = winCount / tournaments * 100;

            Console.WriteLine("Final points: {0}\nAverage points: {1}\n{2:f2}%"
                , sumPoints + startingPoints, avaregePoints, percantage);
        }
    }
}
