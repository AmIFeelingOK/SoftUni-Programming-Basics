using System;

namespace _07.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double a, b, r, h;
            double area = 0;

            if (input == "square")
            {
                a = double.Parse(Console.ReadLine());
                area = a * a;
            }
            else if (input == "rectangle")
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            else if (input == "circle")
            {
                r = double.Parse(Console.ReadLine());
                area = Math.PI * Math.Pow(r, 2);
            }
            else if (input == "triangle")
            {
                a = double.Parse(Console.ReadLine());
                h = double.Parse(Console.ReadLine());
                area = a * h / 2;
            }

            Console.WriteLine($"{area:f3}");
        }
    }
}
