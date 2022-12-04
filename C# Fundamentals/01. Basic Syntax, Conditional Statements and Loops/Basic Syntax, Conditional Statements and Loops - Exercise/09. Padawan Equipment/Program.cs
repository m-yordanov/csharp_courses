using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());    
            int count = int.Parse(Console.ReadLine());
            double priceLightsaber = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());
            int freeBelts = count / 6;
            double priceOverall = (((Math.Ceiling(count * 0.10 + count)) * priceLightsaber) + (priceRobe * count) + (priceBelt * (count - freeBelts)));
            if (money >= priceOverall)
            {
                Console.WriteLine($"The money is enough - it would cost {priceOverall:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {priceOverall - money:f2}lv more.");
            }
        }
    }
}
