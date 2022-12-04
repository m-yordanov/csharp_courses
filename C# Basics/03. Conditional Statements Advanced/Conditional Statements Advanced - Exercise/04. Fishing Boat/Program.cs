using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            double price = 0;
            double discount = 0;
            if (season == "Spring")
            {
                price += 3000;
            }
            if (season == "Winter")
            {
                price += 2600;
            }
            if (season == "Summer")
            {
                price += 4200;
            }
            if (season == "Autumn")
            {
                price += 4200;

            }
            if (amount <= 6)
            {
                discount = 0.10;
                price -= price * discount;
            }
            else if (amount <= 11)
            {
                discount = 0.15;
                price -= price * discount;
            }
            else if (amount > 11)
            {
                discount = 0.25;
                price -= price * discount;
            }
            if (season == "Spring" || season == "Winter" || season == "Summer")
            {
                if (amount % 2 == 0)
                {
                    price -= price * 0.05;
                }
            }
            if (price <= budget)
            {
                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
            }
        }
    }
}
