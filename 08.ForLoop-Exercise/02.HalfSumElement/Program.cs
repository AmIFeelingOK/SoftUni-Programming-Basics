using System;

namespace _02.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int max = int.MinValue;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                sum += number;

                if (max < number)
                {
                    max = number;
                }
            }

            int maxFreeSum = sum - max;

            if (max == maxFreeSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", max);
            }
            else
            {
                int difference = Math.Abs(max - maxFreeSum);
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", difference);
            }
        }
    }
}
