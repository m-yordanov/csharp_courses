using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (j == arr.Length)
                    {
                        rightSum = 0;
                        break;
                    }
                    else
                    {
                        int nextNum = arr[j];
                        rightSum += nextNum;
                    }
                }
                for(int m = i-1; m >= 0; m--)
                {
                    if(i == 0)
                    {
                        leftSum = 0;
                        break;
                    }
                    else
                    {
                        int prevSum = arr[m];
                        leftSum += prevSum;
                    }
                }
                if(leftSum == rightSum)
                {
                    Console.Write(i);
                    return;
                }
                rightSum = 0;
                leftSum = 0;
            }
            Console.WriteLine("no");
        }
    }
}
