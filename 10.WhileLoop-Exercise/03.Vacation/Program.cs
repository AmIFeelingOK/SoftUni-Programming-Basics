using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyRequired = double.Parse(Console.ReadLine());
            double moneyOwned = double.Parse(Console.ReadLine());

            int daysCounter = 0;
            int spendingCounter = 0;

            while (moneyOwned < moneyRequired && spendingCounter < 5)
            {
                string action = Console.ReadLine();
                double actionMoney = double.Parse(Console.ReadLine());

                daysCounter++;

                if (action == "spend")
                {
                    moneyOwned -= actionMoney;
                    spendingCounter++;

                    if (moneyOwned < 0)
                        moneyOwned = 0;
                }
                else if (action == "save")
                {
                    moneyOwned += actionMoney;
                    spendingCounter = 0;
                }
            }

            if (spendingCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            else if (moneyRequired <= moneyOwned)
                Console.WriteLine($"You saved the money for {daysCounter} days.");
        }
    }
}
