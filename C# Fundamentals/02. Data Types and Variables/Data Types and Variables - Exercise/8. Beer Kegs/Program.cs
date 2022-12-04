using System;

namespace _8._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal max = decimal.MinValue;
            string maxModel = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                decimal radius = decimal.Parse(Console.ReadLine());
                int heigth = int.Parse(Console.ReadLine());
                decimal volume = (decimal)(Math.PI * heigth) * (radius * radius);
                if (volume > max)
                {
                    max = volume;
                    maxModel = model;
                }
            }
            Console.WriteLine(maxModel);
        }
    }
}
