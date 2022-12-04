using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studio = 0;
            double apartment = 0;
            if (month == "May" || month == "October")
            {
                studio = 50 * nights;
                apartment = 65 * nights;
                if (7 < nights && nights < 14)
                {
                    studio -= 0.05 * studio;
                }
                if (14 < nights)
                {
                    studio -= 0.30 * studio;
                }
            }
            if (month == "June" || month == "September")
            {
                studio = 75.20 * nights;
                apartment = 68.70 * nights;
                if (14 < nights)
                {
                    studio -= 0.20 * studio;
                }
            }
            if (month == "July" || month == "August")
            {
                studio = 76 * nights;
                apartment = 77 * nights;
            }
            if (nights > 14)
            {
                apartment -= 0.10 * apartment;
            }
            Console.WriteLine($"Apartment: {apartment:f2} lv.");
            Console.WriteLine($"Studio: {studio:f2} lv.");
        }
    }
}
