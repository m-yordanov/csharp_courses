using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double cost = 0;
            if (type == "Roses")
            {
                cost = amount * 5;
                if (amount > 80)
                {
                    cost -= 0.10 * cost;
                }
            }
            else if (type == "Dahlias")
            {
                cost = amount * 3.80;
                if (amount > 90)
                {
                    cost -= 0.15 * cost;
                }
            }
            else if (type == "Tulips")
            {
                cost = amount * 2.80;
                if (amount > 80)
                {
                    cost -= 0.15 * cost;
                }
            }
            else if (type == "Narcissus")
            {
                cost = amount * 3;
                if (amount < 120)
                {
                    cost += 0.15 * cost;
                }
            }
            else if (type == "Gladiolus")
            {
                cost = amount * 2.50;
                if (amount < 80)
                {
                    cost += 0.20 * cost;
                }
            }
            if (cost <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {amount} {type} and {budget - cost:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {cost - budget:f2} leva more.");
            }
        }
    }
}
