﻿using System;

namespace _02.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int result = i * j;

                    Console.WriteLine("{0} * {1} = {2}", i, j, result);
                }
            }
        }
    }
}
