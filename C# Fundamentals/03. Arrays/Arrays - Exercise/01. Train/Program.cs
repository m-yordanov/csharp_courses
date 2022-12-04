using System;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int passengers = 0;
            int sum = 0;
            int[] print = new int[n];
            for (int i = 0; i < n; i++)
            {
                passengers = int.Parse(Console.ReadLine());
                sum += passengers;
                print[i] = passengers;
            }
            Console.WriteLine(string.Join(" ", print));
            Console.WriteLine(sum);
        }
    }
}
