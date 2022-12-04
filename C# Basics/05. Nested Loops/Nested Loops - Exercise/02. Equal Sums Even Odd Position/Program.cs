using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            for(int i = n1; i <= n2; i++) //100 000
            {
                int oddSum = 0;
                int evenSum = 0;

                string currentNum = i.ToString(); //"100000"
                for(int j = 0; j <= 5; j++) 
                {
                    if(j % 2 == 0)
                    {
                        evenSum += currentNum[j];
                    }
                    else if (j % 2 != 0)
                    {
                        oddSum += currentNum[j];
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write(currentNum + " ");
                }
            }
        }
    }
}
