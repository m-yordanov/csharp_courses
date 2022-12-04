using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string rating = Console.ReadLine();
            double price = 0;
            if (type == "room for one person")
            {
                price += (days-1) * 18;
            }
            else if (type == "apartment")
            {
                price += (days-1) * 25;
                if(days < 10)
                {
                    price -= 0.30 * price;
                }
                else if(days <=15)
                {
                    price -= 0.35 * price;
                }
                else if (days > 15)
                {
                    price -= 0.50 * price;
                }
            }
            else if (type == "president apartment")
            {
                price += (days-1) * 35;
                if (days < 10)
                {
                    price -= 0.10 * price;
                }
                else if (days <= 15)
                {
                    price -= 0.15 * price;
                }
                else if (days > 15)
                {
                    price -= 0.20 * price;
                }
            }
            if (rating == "positive")
            {
                price += 0.25 * price;
            }
            else if (rating == "negative")
            {
                price -= 0.10 * price;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
