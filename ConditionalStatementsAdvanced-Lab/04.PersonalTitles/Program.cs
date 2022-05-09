using System;

namespace _04.PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string mOrF = Console.ReadLine();

            if (age >= 16)
            {
                if (mOrF == "m")
                {
                    Console.WriteLine("Mr.");
                }
                else if (mOrF == "f")
                {
                    Console.WriteLine("Ms.");
                }
            }
            else if (age < 16)
            {
                if (mOrF == "m")
                {
                    Console.WriteLine("Master");
                }
                else if (mOrF == "f")
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}
