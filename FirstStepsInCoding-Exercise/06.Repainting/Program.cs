using System;

namespace _06.Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double nylonSum = (nylon + 2) * 1.50;
            double paintSum = (paint + paint * 0.10) * 14.50;
            double thinnerSum = thinner * 5;

            double sum = nylonSum + paintSum + thinnerSum + 0.40;

            double sumForWorkers = (sum * 0.30) * hours;
            double finalSum = sum + sumForWorkers;            

            Console.WriteLine(finalSum);
        }
    }
}
