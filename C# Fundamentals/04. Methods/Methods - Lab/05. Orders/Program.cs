using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            PrintPrice(order, quantity);
        }

        private static void PrintPrice(string order, double quantity)
        {
            double price = 0;
            switch (order)
            {
                case "coffee":
                    {
                        price = quantity * 1.5;
                    }
                    break;
                case "water":
                    {
                        price = quantity * 1;
                    }
                    break;
                case "coke":
                    {
                        price = quantity * 1.4;
                    }
                    break;
                case "snacks":
                    {
                        price = quantity * 2;
                    }
                    break;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
