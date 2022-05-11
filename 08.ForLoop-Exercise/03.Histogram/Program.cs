using System;

namespace _03.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double firstCount = 0;
            double secondCount = 0;
            double thirdCount = 0;
            double forthCount = 0;
            double fifthCount = 0;

            double p1 = 1;
            double p2 = 1;
            double p3 = 1;
            double p4 = 1;
            double p5 = 1;

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers < 200)
                {
                    firstCount++;
                }
                else if (numbers >= 200 && numbers <= 399)
                {
                    secondCount++;
                }
                else if (numbers >= 400 && numbers <= 599)
                {
                    thirdCount++;
                }
                else if (numbers >= 600 && numbers <= 799)
                {
                    forthCount++;
                }
                else if (numbers >= 800)
                {
                    fifthCount++;
                }
            }

            p1 = firstCount / n * 100;
            p2 = secondCount / n * 100;
            p3 = thirdCount / n * 100;
            p4 = forthCount / n * 100;
            p5 = fifthCount / n * 100;

            Console.WriteLine("{0:f2}%\n{1:f2}%\n{2:f2}%\n{3:f2}%\n{4:f2}%", p1, p2, p3, p4, p5);
        }
    }
}
