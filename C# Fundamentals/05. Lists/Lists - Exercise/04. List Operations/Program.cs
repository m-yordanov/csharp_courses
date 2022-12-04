using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
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
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArgs = input.Split().ToArray();
                string firstPart = inputArgs[0];
                if (firstPart == "Insert")
                {
                    int startIndex = int.Parse(inputArgs[1]);
                    int endIndex = int.Parse(inputArgs[2]);
                    if(endIndex >= 0 && endIndex < nums.Count)
                    {
                        nums.Insert(endIndex, startIndex);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if(firstPart == "Add")
                {
                    int startIndex = int.Parse(inputArgs[1]);
                    nums.Add(startIndex);
                }
                else if(firstPart == "Remove")
                {
                    int startIndex = int.Parse(inputArgs[1]);
                    if(startIndex >= 0 && startIndex < nums.Count)
                    {
                        nums.RemoveAt(startIndex);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if(firstPart == "Shift")
                {
                    string startIndex = inputArgs[1];
                    int endIndex = int.Parse(inputArgs[2]);
                    if(startIndex == "left")
                    {
                        for(int i = 0; i < endIndex; i++)
                        {
                            nums.Add(nums[0]);
                            nums.RemoveAt(0);
                        }
                    }
                    else if (startIndex == "right")
                    {
                        for(int i =0; i < endIndex; i++)
                        {
                            nums.Insert(0, nums[nums.Count-1]);
                            nums.RemoveAt(nums.Count - 1);
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
