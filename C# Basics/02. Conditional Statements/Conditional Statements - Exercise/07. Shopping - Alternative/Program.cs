using System;

namespace Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int processor = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());
            double sumVideoCards = videoCards * 250;
            double sumProcessor = sumVideoCards * 0.35;
            double processorPrice = sumProcessor * processor;
            double ramPrice = sumVideoCards * 0.10;
            double ramSum = ram * ramPrice;
            double totalSum = sumVideoCards + processorPrice + ramSum;
            if (videoCards > processor)
            {
                totalSum = totalSum - (totalSum * 15 / 100);

            }
            if (totalSum <= budget)
            {
                Console.WriteLine($"You have {budget - totalSum:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(totalSum - budget):f2} leva more!");
            }
        }
    }
}