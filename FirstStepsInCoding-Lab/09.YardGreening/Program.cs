using System;

namespace _09.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMeters = double.Parse(Console.ReadLine());

            double price = squareMeters * 7.61;
            double discount = price * 0.18;
            double finalPrice = price - discount;

            Console.WriteLine("The final price is: {0} lv.", finalPrice);
            Console.WriteLine("The discount is: {0} lv.", discount);
        }
    }
}
