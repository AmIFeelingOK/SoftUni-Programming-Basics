using System;

namespace _03.TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int calculattedMinutes= minutes + 15;
            if (calculattedMinutes >= 60)
            {
                hours++;
                calculattedMinutes -= 60;
            }
            if (hours > 23)
            {
                hours = 0;
            }
            if (calculattedMinutes < 10)
            {
                Console.WriteLine($"{hours}:0{calculattedMinutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{calculattedMinutes}");
            }
        }
    }
}
