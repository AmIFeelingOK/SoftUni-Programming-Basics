using System;

namespace _10.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int oddLines = 0;
            int evenLines = 0;

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenLines += numbers;
                }
                else
                {
                    oddLines += numbers;
                }
            }

            if (evenLines == oddLines)
            {
                Console.WriteLine("Yes\nSum = {0}", evenLines);
            }
            else
            {
                Console.WriteLine("No\nDiff = {0}", Math.Abs(oddLines - evenLines));
            }
        }
    }
}
