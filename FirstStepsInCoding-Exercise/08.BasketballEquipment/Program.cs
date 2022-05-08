using System;

namespace _08.BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int annualTax = int.Parse(Console.ReadLine());

            double sneakers = annualTax * 0.60;
            double outfit = sneakers * 0.80;
            double ball = outfit * 0.25;
            double accessories = ball * 0.20;

            double finalSum = sneakers 
                + outfit 
                + ball 
                + accessories
                + annualTax;

            Console.WriteLine(finalSum);
        }
    }
}
