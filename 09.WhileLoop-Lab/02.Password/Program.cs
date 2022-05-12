using System;

namespace _02.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            while (password != "pass")
            {
                password = Console.ReadLine();
            }
        }
    }
}
