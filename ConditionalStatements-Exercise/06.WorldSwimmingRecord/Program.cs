using System;

namespace _06.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double addedTime = Math.Floor(meters / 15) * 12.5;

            double totalTime = meters * timeForOneMeter + addedTime;

            if (totalTime < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                double timeRequired = totalTime - worldRecord;
                Console.WriteLine($"No, he failed! He was {timeRequired:f2} seconds slower.");
            }
        }
    }
}
