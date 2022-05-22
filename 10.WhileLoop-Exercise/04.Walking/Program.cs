using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSteps = 0;

            while (totalSteps < 10000)
            {
                string stepsPerGoingOut = Console.ReadLine();
                if (stepsPerGoingOut == "Going home")
                {
                    totalSteps += int.Parse(Console.ReadLine());
                    break;
                }
                int steps = int.Parse(stepsPerGoingOut);
                totalSteps += steps;
            }

            if (totalSteps < 10000)
                Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
            else
                Console.WriteLine($"Goal reached! Good job!\n{totalSteps - 10000} steps over the goal!");
        }
    }
}
