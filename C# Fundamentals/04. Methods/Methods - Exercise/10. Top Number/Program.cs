using System;
using System.Numerics;
using System.Linq;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            GetTopNumbers(n);
        }
        static void GetTopNumbers(int num)
        {
            for(int i = 1; i <= num; i++)
            {
                bool oddDigit = false;
                int currNum = i;
                int sum = 0;
                while(currNum != 0)
                {
                    sum += currNum % 10;
                    if ((currNum % 10) % 2 != 0)
                    {
                        oddDigit = true;
                    }
                    currNum /= 10;

                }
                if (oddDigit && sum % 8 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
