using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            int n = int.Parse(Console.ReadLine());
            int littersPouring = 0;
            int littersPoured = 0;
            for (int i = 0; i < n; i++)
            {
                littersPouring = int.Parse(Console.ReadLine());
                if (littersPouring > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    littersPoured += littersPouring;
                    capacity -= littersPouring;
                }
            }
            Console.WriteLine(littersPoured);
        }
    }
}
