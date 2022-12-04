using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numberOcc = new SortedDictionary<double, int>();
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            foreach(double number in numbers)
            {
                if(!numberOcc.ContainsKey(number))
                {
                    numberOcc.Add(number, 0);
                }

                numberOcc[number] += 1;
            }
            foreach(var item in numberOcc)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
