using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1111; i < 9999; i++)
            {
                string @String = i.ToString();

                int[] ints = {(int)char.GetNumericValue(@String[0]), (int)char.GetNumericValue(@String[1]),
                    (int)char.GetNumericValue(@String[2]), (int)char.GetNumericValue(@String[3])};

                if (ints[0] == 0 || ints[1] == 0 || ints[2] == 0 || ints[3] == 0)
                    continue;

                if (number % ints[0] == 0 && number % ints[1] == 0 && number % ints[2] == 0 && number % ints[3] == 0)
                    Console.Write(i + " ");
            }
        }
    }
}
