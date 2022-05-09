using System;

namespace _02.WeekendOrWorkingDay
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                Console.WriteLine("Working day");
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                Console.WriteLine("Weekend");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
