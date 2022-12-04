using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int cleaner = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());
            Console.WriteLine((pens * 5.80 + markers * 7.20 + cleaner * 1.20) - (pens * 5.80 + markers * 7.20 + cleaner * 1.20) * percent / 100);
        }
    }
}
