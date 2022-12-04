using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                //.Select(int.Parse)
                .ToList();
            List<string> nums2 = new List<string>();
            for (int i = nums.Count-1; i >= 0; i--)
            {
                List<string> inputArgs = nums[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                for (int j = 0; j < inputArgs.Count; j++)
                {
                    nums2.Add(inputArgs[j]);
                }
            }
            Console.WriteLine(String.Join(" ", nums2));
        }
    }
}
