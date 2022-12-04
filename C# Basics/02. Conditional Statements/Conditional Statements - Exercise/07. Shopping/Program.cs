using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int gpu = int.Parse(Console.ReadLine());
            double cpu = int.Parse(Console.ReadLine());
            double ram = int.Parse(Console.ReadLine());
            double price = (gpu * 250) + (cpu * (0.35 * (gpu * 250))) + (ram * (0.10 * (gpu * 250)));  
            if (gpu > cpu)
            {
                price -= 0.15 * price;
            }
            if (price < budget)
            {
                Console.WriteLine($"You have {budget - price:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(price - budget):f2} leva more!");
            }
        }
    }
}
