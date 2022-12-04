using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            int removedSum = 0;
            while (sequence.Count != 0)
            {
                int n = int.Parse(Console.ReadLine());
                int removeValue = 0;
                if (n < 0)
                {
                    removeValue = sequence[0];
                    sequence[0] = sequence[sequence.Count - 1];
                    sequence = ModifyElementsWithRemovedValue(sequence, removeValue);
                }
                else if (n > sequence.Count - 1)
                {
                    removeValue = sequence[sequence.Count - 1];
                    sequence[sequence.Count - 1] = sequence[0];
                    sequence = ModifyElementsWithRemovedValue(sequence, removeValue);
                }
                else
                {
                    removeValue = sequence[n];
                    sequence.RemoveAt(n);
                    sequence = ModifyElementsWithRemovedValue(sequence, removeValue);
                }
                removedSum += removeValue;
            }
            Console.WriteLine(removedSum);
        }
        static List<int> ModifyElementsWithRemovedValue(List<int> list, int removed)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > removed)
                {
                    list[i] -= removed;
                }
                else
                {
                    list[i] += removed;
                }
            }
            return list;
        }
    }
}
