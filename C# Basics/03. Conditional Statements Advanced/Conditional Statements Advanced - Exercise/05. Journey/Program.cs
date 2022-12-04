using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string location = "";
            string type = "";
            double spending = 0;
            if (budget <= 100)
            {
                location = "Bulgaria";
                if (season == "summer")
                {
                    spending = 0.30 * budget;
                    type = "Camp";
                }
                else if (season == "winter")
                {
                    type = "Hotel";
                    spending = 0.70 * budget;
                }
            }
            else if (budget <= 1000)
            {
                location = "Balkans";
                if (season == "summer")
                {
                    spending = 0.40 * budget;
                    type = "Camp";
                }
                else if (season == "winter")
                {
                    type = "Hotel";
                    spending = 0.80 * budget;
                }
            }
            else if (budget > 1000)
            {
                location = "Europe";
                type = "Hotel";
                spending = 0.90 * budget;
            }
            Console.WriteLine($"Somewhere in {location}");
            Console.WriteLine($"{type} - {spending:f2}");
        }
    }
}
