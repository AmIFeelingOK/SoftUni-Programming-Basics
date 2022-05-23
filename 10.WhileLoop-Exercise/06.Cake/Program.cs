using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int cake = width * length;

            while (cake > 0)
            {
                string piecesCake = Console.ReadLine();

                if (piecesCake == "STOP")
                    break;

                int piecesOfCake = int.Parse(piecesCake);
                cake -= piecesOfCake;
            }

            if (cake <= 0)            
                Console.WriteLine($"No more cake left! You need {Math.Abs(cake)} pieces more.");            
            else            
                Console.WriteLine($"{cake} pieces are left.");            
        }
    }
}
