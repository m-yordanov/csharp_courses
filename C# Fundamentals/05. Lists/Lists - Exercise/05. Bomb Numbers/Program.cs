using System;
using System.Collections.Generic;
using System.Linq;

namespace T05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int[] bombAndPower = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int specialNumber = bombAndPower[0];
            int bombPower = bombAndPower[1];

            int indexOfBomb = 0;

            while (sequence.Contains(specialNumber))
            {
                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] == specialNumber)
                    {
                        indexOfBomb = i;
                        break;
                    }
                }

                int startIndex = indexOfBomb - bombPower;
                int count = 2 * bombPower + 1;

                if (startIndex < 0)
                {
                    startIndex = 0;
                }


                if (count > sequence.Count - 1)
                {
                    count = sequence.Count - startIndex;

                }


                sequence.RemoveRange(startIndex, count);
            }
            int sum = sequence.Sum();
            Console.WriteLine(sum);
        }
    }
}
