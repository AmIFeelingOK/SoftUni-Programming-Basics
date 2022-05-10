using System;

namespace ConditionalStatements_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int timeInSeconds = firstTime 
                + secondTime 
                + thirdTime;

            int timeInMinutes = timeInSeconds / 60;
            int secondsRemaining = timeInSeconds % 60;

            if (secondsRemaining < 10)
            {
                Console.WriteLine($"{timeInMinutes}:0{secondsRemaining}");
            }
            else
            {
                Console.WriteLine($"{timeInMinutes}:{secondsRemaining}");
            }
        }
    }
}
