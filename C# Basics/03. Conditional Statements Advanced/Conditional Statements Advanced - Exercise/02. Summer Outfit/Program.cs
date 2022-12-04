using System;

namespace _02._Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degree = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            string outfit;
            string shoes;
            if (10 <= degree && degree <= 18)
            {
                switch(time)
                {
                    case "Morning":
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                        Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                        break;
                    case "Afternoon":
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                        break;
                }
            }
            if (18 < degree && degree <= 24)
            {
                switch (time)
                {
                    case "Morning":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                        break;
                    case "Afternoon":
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                        break;
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                        break;
                }
            }
            if (degree >= 25)
            {
                switch (time)
                {
                    case "Morning":
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                        break;
                    case "Afternoon":
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                        Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                        break;
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                        break;
                }
            }
        }
    }
}
