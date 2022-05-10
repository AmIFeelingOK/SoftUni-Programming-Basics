using System;

namespace _08.LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string series = Console.ReadLine();
            int duration = int.Parse(Console.ReadLine());
            int rest = int.Parse(Console.ReadLine());

            double timeForLunch = rest * 0.125;
            double chillingTime = rest * 0.25;
            double timeLeft = rest - timeForLunch - chillingTime;

            if (timeLeft >= duration)
            {
                double timeCalculation = timeLeft - duration;
                Console.WriteLine($"You have enough time to watch {series} and left with {Math.Ceiling(timeCalculation)} minutes free time.");
            }
            else if (timeLeft < duration)
            {
                double timeCalculation = duration - timeLeft;
                Console.WriteLine($"You don't have enough time to watch {series}, you need {Math.Ceiling(timeCalculation)} more minutes.");
            }
        }
    }
}
