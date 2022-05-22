using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int unsatisfactoryGrade = int.Parse(Console.ReadLine());

            int failedGrades = 0;
            int solvedTasks = 0;
            double gradesSum = 0;
            string lastProblem = string.Empty;
            bool isFailed = true;

            while (failedGrades < unsatisfactoryGrade)
            {
                string taskName = Console.ReadLine();

                if (taskName == "Enough")
                {
                    isFailed = false;
                    break;
                }

                int grade = int.Parse(Console.ReadLine());

                if (grade <= 4)
                {
                    failedGrades++;
                }

                gradesSum += grade;
                solvedTasks++;
                lastProblem = taskName;
            }

            if (isFailed)
            {
                Console.WriteLine($"You need a break, {unsatisfactoryGrade} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradesSum / solvedTasks:f2}");
                Console.WriteLine($"Number of problems: {solvedTasks}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
