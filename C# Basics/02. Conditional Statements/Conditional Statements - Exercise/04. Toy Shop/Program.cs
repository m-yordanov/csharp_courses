using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double trip = double.Parse(Console.ReadLine());
            int puzzleAmount = int.Parse(Console.ReadLine());
            int dollAmount = int.Parse(Console.ReadLine());
            int teddyAmount = int.Parse(Console.ReadLine());
            int minionAmount = int.Parse(Console.ReadLine());
            int truckAmount = int.Parse(Console.ReadLine());
            double profit = (2.60 * puzzleAmount) + (3 * dollAmount) + (4.10 * teddyAmount) + (8.20 * minionAmount) + (2 * truckAmount);
            if (puzzleAmount + dollAmount + teddyAmount + minionAmount + truckAmount >= 50)
            {
                profit = profit - (profit * 0.25);
            }
            if (profit - (0.10 * profit) < trip)
            {
                Console.WriteLine($"Not enough money! {trip - (profit - (profit * 0.10)):f2} lv needed.");
            }
            else
            {
                Console.WriteLine($"Yes! {(profit - (0.10 * profit)) - trip:f2} lv left.");
            }
        }
    }
}
