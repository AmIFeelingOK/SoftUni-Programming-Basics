﻿using System;

namespace _02.EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                string currNumber = i.ToString();

                int oddSum = 0;
                int evenSum = 0;

                for (int j = 0; j < currNumber.Length; j++)
                {
                    int currDigit = int.Parse(currNumber[j].ToString());

                    if (j % 2 == 0)
                        evenSum += currDigit;
                    else
                        oddSum += currDigit;
                }

                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
