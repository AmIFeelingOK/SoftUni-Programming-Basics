using System;

namespace _04.SumОfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            bool isMagicNumberFound = false;
            int combinatoinsCounter = 0;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = firstNumber; j <= secondNumber; j++)
                {
                    combinatoinsCounter++;
                    if (i + j == magicNumber)
                    {
                        isMagicNumberFound = true;
                        Console.WriteLine($"Combination N:{combinatoinsCounter} ({i} + {j} = {magicNumber})");
                        return;
                    }
                }
            }

            if (!isMagicNumberFound)
            {
                Console.WriteLine($"{combinatoinsCounter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
