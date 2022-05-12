using System;

namespace oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double sumPoints = points;
            bool flag = false;

            for (int i = 0; i < n; i++)
            {
                string evaluator = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                double momentPoints = (evaluator.Length * grade) / 2;
                sumPoints = sumPoints + momentPoints;

                if (sumPoints >= 1250.5)
                {
                    flag = true;
                    break;
                }

            }

            if (flag)
            {
                Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {sumPoints:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {name} you need {1250.5 - sumPoints:f1} more!");
            }

        }
    }
}
