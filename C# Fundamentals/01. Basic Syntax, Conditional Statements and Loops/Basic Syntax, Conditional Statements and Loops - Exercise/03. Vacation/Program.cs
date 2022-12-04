using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            if (type == "Students")
            {
                switch (day)
                {
                    case "Friday":
                        price = 8.45 * count;
                        break;
                    case "Saturday":
                        price = 9.80 * count;
                        break;
                    case "Sunday":
                        price = 10.46 * count;
                        break;
                }
                if (count >= 30)
                {
                    price -= price * 0.15;
                }
            }
            if (type == "Business")
            {
                switch (day)
                {
                    case "Friday":
                        price = 10.90 * count;
                        if (count >= 100)
                        {
                            price = (count - 10) * 10.90;
                        }
                        break;
                    case "Saturday":
                        price = 15.60 * count;
                        if (count >= 100)
                        {
                            price = (count - 10) * 15.60;
                        }
                        break;
                    case "Sunday":
                        price = 16 * count;
                        if (count >= 100)
                        {
                            price = (count - 10) * 16;
                        }
                        break;
                }
            }
            if (type == "Regular")
            {
                switch (day)
                {
                    case "Friday":
                        price = 15 * count;
                        break;
                    case "Saturday":
                        price = 20 * count;
                        break;
                    case "Sunday":
                        price = 22.50 * count;
                        break;
                }
                if (count >= 10 && count <= 20)
                {
                    price -= price * 0.05;
                }
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
