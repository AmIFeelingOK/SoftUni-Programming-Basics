using System;

namespace _07.ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int hours = int.Parse(Console.ReadLine());

            int hoursRequired = hours * 3;

            Console.WriteLine("The architect {0} will need {1} hours to complete {2} project/s.", name, hoursRequired, hours);
        }
    }
}
