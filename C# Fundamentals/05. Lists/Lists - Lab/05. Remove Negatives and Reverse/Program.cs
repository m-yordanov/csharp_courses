﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            //for(int i = 0; i < nums.Count; i++)
            //{
            //    if (nums[i] < 0)
            //    {
            //        nums.Remove(nums[i]);
            //        i--;
            //    }
            //}
            nums.RemoveAll(x => x < 0);

            if (nums.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                nums.Reverse();
                Console.WriteLine(string.Join(" ", nums));
            }
        }
    }
}
