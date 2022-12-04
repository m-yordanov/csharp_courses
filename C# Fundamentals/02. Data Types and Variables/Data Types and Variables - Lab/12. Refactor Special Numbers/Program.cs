using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            int currentNum = 0;

            bool isNum = false;

            for (int ch = 1; ch <= n; ch++)

            {

                currentNum = ch;

                while (ch > 0)

                {

                    sum += ch % 10;

                    ch = ch / 10;

                }

                isNum = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine("{0} -> {1}", currentNum, isNum);

                sum = 0;

                ch = currentNum;

            }
        }
    }
}
