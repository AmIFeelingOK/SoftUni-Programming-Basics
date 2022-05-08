using System;

namespace _05.SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int detergent = int.Parse(Console.ReadLine());
            double decent = double.Parse(Console.ReadLine());

            double percentage = decent / 100;

            double sum = (pens * 5.80) + (markers * 7.20) + (detergent * 1.20);
            double finalSum = sum - (sum * percentage);

            Console.WriteLine(finalSum);
        }
    }
}
