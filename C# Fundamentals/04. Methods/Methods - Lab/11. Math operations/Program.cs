using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());
            int result = GetResult(num1, @operator, num2);
            Console.WriteLine(result);
        }
        static int GetResult(int a, string @operator, int b)
        {
            int result = 0;
            switch (@operator)
            {
                case "+":
                    result = a + b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "/":
                    result = a / b;
                    break;
            }
            return result;
        }
    }
}
