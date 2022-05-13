using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double currentYear = 1;
            double gradeTotal = 0;
            double counter = 1;

            while (currentYear <= 12)
            {
                double currentGrade = double.Parse(Console.ReadLine());

                if (currentGrade >= 4)
                {
                    currentYear++;
                }

                else if (currentGrade < 4)
                {
                    if (counter >= 2)
                    {

                        Console.WriteLine("{0} has been excluded at {1} grade", name, currentYear);
                        break;
                    }

                    counter++;
                }

                gradeTotal += currentGrade;
            }

            gradeTotal = gradeTotal / 12;

            if (gradeTotal >= 4.00 && counter < 2)
            {
                Console.WriteLine("{0} graduated. Average grade: {1:F2}", name, gradeTotal);
            }
        }
    }
}
