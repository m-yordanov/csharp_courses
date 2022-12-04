using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArgs = input.Split().ToArray();
                string firstPart = inputArgs[0];
                int startIndex = int.Parse(inputArgs[1]);
                if(firstPart == "Delete")
                {
                    while(nums.Contains(startIndex))
                    {
                        nums.Remove(startIndex);
                    }
                }
                else if(firstPart == "Insert")
                {
                    int endIndex = int.Parse(inputArgs[2]);
                    nums.Insert(endIndex, startIndex);
                }
            }
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
