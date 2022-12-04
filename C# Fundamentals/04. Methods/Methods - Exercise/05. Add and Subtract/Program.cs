using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int sum = TwoIntSum(num1, num2);
            int subtraction = SubtractTheSum(num3, sum);
            Console.WriteLine(subtraction);
        }
        static int TwoIntSum(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
        static int SubtractTheSum(int num3, int sum)
        {
            int subtraction = sum - num3;
            return subtraction;
        }
    }
}
