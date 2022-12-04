using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int maxWagonCapacity = int.Parse(Console.ReadLine());
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputParts = input.Split().ToArray();
                string firstPart = inputParts[0];
                if(firstPart == "Add")
                {
                    wagons.Add(int.Parse(inputParts[1]));
                }
                else
                {
                    int value = int.Parse(inputParts[0]);
                    int index = wagons.FindIndex(x => x <= maxWagonCapacity - value);
                    if(index >= 0)
                    {
                        wagons[index] += value;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
