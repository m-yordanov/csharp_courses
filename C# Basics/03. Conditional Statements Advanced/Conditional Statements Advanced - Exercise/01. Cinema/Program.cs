using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());
            double income;
            if (type == "Premiere")
            {
                income = row * column * 12.00;
                Console.WriteLine($"{income:f2} leva");
            }
            else if (type == "Normal")
            {
                income = column * row * 7.50;
                Console.WriteLine($"{income:f2} leva");
            }
            else if (type == "Discount")
            {
                income = row * column * 5.00;
                Console.WriteLine($"{income:f2} leva");
            }
        }
    }
}
