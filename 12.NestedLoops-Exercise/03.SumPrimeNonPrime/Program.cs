using System;

namespace _03.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumPrimes = 0;
            int sumNonPrimes = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                    break;

                int inputInt = int.Parse(input);
                if (inputInt < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                bool isPrime = true;

                for (int i = 2; i <= Math.Sqrt(inputInt); i++)
                {
                    if (inputInt % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    sumPrimes += inputInt;
                else
                    sumNonPrimes += inputInt;
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrimes}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrimes}");
        }
    }
}
