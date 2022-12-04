using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chicken = double.Parse(Console.ReadLine()) * 10.35;
            double fish = double.Parse(Console.ReadLine()) * 12.40;
            double vegetarian = double.Parse(Console.ReadLine()) * 8.15;
            Console.WriteLine((chicken + fish + vegetarian) + ((chicken + fish + vegetarian) * 0.20) + 2.50);
        }
    }
}
