using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double stylists = int.Parse(Console.ReadLine());
            double clothing = double.Parse(Console.ReadLine());
            double decoration = 0.10 * budget;
            if (stylists > 150)
            {
                clothing -= 0.10 * clothing;
            }
            if (decoration + (clothing*stylists) > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(decoration + (clothing*stylists)) - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - (decoration + (clothing*stylists)):f2} leva left.");
            }
        }
    }
}
