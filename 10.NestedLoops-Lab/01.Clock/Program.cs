using System;

namespace _10.NestedLoops_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 23; i++)
            {
                for (int j = 0; j <= 59; j++)
                {
                    Console.WriteLine("{0}:{1}", i, j);
                }
            }
        }
    }
}
