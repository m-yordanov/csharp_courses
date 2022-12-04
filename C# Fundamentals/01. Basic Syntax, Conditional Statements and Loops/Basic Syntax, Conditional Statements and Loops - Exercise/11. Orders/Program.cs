using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            for (int i = 1; i <= N; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int daysInMonth = int.Parse(Console.ReadLine());
                int capsules = int.Parse(Console.ReadLine());
                double price = (daysInMonth * capsules) * pricePerCapsule;
                totalPrice += price;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");

            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
