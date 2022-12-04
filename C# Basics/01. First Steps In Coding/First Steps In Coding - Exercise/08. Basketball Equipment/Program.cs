using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());
            double shoes = tax - (tax * 0.40);
            double gear = shoes - (shoes * 0.20);
            double ball = gear / 4;
            double accessories = ball / 5;
            Console.WriteLine(tax + shoes + gear + ball + accessories);
        }
    }
}
