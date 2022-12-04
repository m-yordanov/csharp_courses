using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^\%(?<name>[A-Z][a-z]+)\%[^\%\|\$\.]*?\<(?<product>\w+)\>[^\%\|\$\.]*?\|(?<quantity>\d+)\|[^\%\|\$\.]*?(?<price>\d+(\.\d+)?)\$[^\%\|\$\.]*?$";
            Regex regex = new Regex(pattern);
            double sum = 0;

            string input;
            while((input = Console.ReadLine()) != "end of shift")
            {
                Match match = regex.Match(input);
                if(match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    double itemPrice = double.Parse(match.Groups["price"].Value);
                    double finalPrice = itemPrice * quantity;
                    sum += finalPrice;
                    Console.WriteLine($"{name}: {product} - {finalPrice:f2}");
                }
            }
            Console.WriteLine($"Total income: {sum:f2}");
        }
    }
}
