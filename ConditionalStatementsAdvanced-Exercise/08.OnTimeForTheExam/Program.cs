using System;

namespace _08.OnTimefortheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHours = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHours = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());
            
            examMinutes += examHours * 60;
            arrivalMinutes += arrivalHours * 60;

            int difference = 0;
            int hour = 0;
            int minutes = 0;

            if (examMinutes < arrivalMinutes)
            {
                Console.WriteLine("Late");
                difference = arrivalMinutes - examMinutes;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours after the start");
                }
            }
            else if (arrivalMinutes < examMinutes - 30)
            {

                Console.WriteLine("Early");
                difference = examMinutes - arrivalMinutes;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("On time");
                difference = examMinutes - arrivalMinutes;
                Console.WriteLine($"{difference} minutes before the start");
            }
        }
    }
}
