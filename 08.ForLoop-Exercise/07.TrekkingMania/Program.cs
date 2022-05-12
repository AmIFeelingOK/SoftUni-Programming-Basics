using System;

namespace _07.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            int sum = 0;

            double musala = 0;
            double monblan = 0;
            double kilimandjaro = 0;
            double k2 = 0;
            double everest = 0;

            for (int i = 0; i < groups; i++)
            {
                int numOfPeople = int.Parse(Console.ReadLine());

                sum += numOfPeople;

                if (numOfPeople <= 5)
                {
                    musala += numOfPeople;
                }
                else if (numOfPeople >= 6 && numOfPeople <= 12)
                {
                    monblan += numOfPeople;
                }
                else if (numOfPeople >= 13 && numOfPeople <= 25)
                {
                    kilimandjaro += numOfPeople;
                }
                else if (numOfPeople >= 26 && numOfPeople <= 40)
                {
                    k2 += numOfPeople;
                }
                else if (numOfPeople >= 41)
                {
                    everest += numOfPeople;
                }
            }

            double p1 = musala / sum * 100;
            double p2 = monblan / sum * 100;
            double p3 = kilimandjaro / sum * 100;
            double p4 = k2 / sum * 100;
            double p5 = everest / sum * 100;

            Console.WriteLine("{0:f2}%\n{1:f2}%\n{2:f2}%\n{3:f2}%\n{4:f2}%"
                , p1, p2, p3, p4, p5);
        }
    }
}
