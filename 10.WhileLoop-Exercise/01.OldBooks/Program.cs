using System;

namespace _01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookInput = Console.ReadLine();

            string books = Console.ReadLine();

            int counter = 0;

            while (books != "No More Books" && books != bookInput)
            {
                counter++;

                books = Console.ReadLine();
            }

            if (bookInput != books)
                Console.WriteLine($"The book you search is not here!\nYou checked {counter} books.");

            else
                Console.WriteLine($"You checked {counter} books and found it.");
        }
    }
}
