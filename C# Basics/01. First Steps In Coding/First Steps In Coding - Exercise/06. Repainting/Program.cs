using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int naylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int diverse = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double naylon_price = (naylon + 2) * 1.50;
            double paint_price = (paint + 0.10*paint) * 14.50;
            double diverse_price = diverse * 5.00;
            double materials_price = naylon_price + paint_price + diverse_price + 0.40;
            double builder_costs = (materials_price * 0.30) * hours;
            Console.WriteLine(materials_price + builder_costs);
        }
    }
}
