using System;

namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dogAmount = double.Parse(Console.ReadLine());
            double catAmount = double.Parse(Console.ReadLine());
            double price = dogAmount * 2.50 + catAmount * 4;
            Console.WriteLine($"{price} lv.");
        }
    }
}
