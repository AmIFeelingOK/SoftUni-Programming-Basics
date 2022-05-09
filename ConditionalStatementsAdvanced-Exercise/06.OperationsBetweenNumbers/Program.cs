using System;

namespace _06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            string action = Console.ReadLine();

            double result = 0.0;

            if (action == "+")
            {
                result = firstNumber + secondNumber;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {result} - odd");
                }
            }
            else if (action == "-")
            {
                result = firstNumber - secondNumber;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {result} - odd");
                }
            }
            else if (action == "*")
            {
                result = firstNumber * secondNumber;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {result} - odd");
                }
            }
            else if (action == "/")
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                }
                else
                {
                    result = firstNumber / secondNumber;
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {result:f2}");
                }
            }
            else if (action == "%")
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                }
                else
                {
                    result = firstNumber % secondNumber;
                    Console.WriteLine($"{firstNumber} % {secondNumber} = {result}");
                }                
            }
        }
    }
}
