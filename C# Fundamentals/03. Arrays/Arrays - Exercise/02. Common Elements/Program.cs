using System;
using System.Linq;
using System.Collections.Concurrent;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();
            string common = string.Empty;
            for (int i = 0; i < arr2.Length; i++)
            {
                int index = 0;
                while (index < arr1.Length)
                {
                    if (arr2[i] == arr1[index])
                    {
                        common += (arr2[i] + " ");
                    }
                    index++;
                }
            }
            string[] result = common.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
