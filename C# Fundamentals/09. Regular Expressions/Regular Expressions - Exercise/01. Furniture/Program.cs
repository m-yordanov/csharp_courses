using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> furniture = new List<string>();
            string pattern = @"^>>(?<furnitureName>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)(\.\d+)?$";
            Regex regex = new Regex(pattern);

            double sum = 0;
            string input;
            while((input = Console.ReadLine()) != "Purchase")
            {
                Match match = regex.Match(input);
                if(match.Success)
                {
                    string furnitureName = match.Groups["furnitureName"].Value;
                    double pricePerUnit = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    furniture.Add(furnitureName);
                    sum += pricePerUnit * quantity;
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach(string furnitureName in furniture)
            {
                Console.WriteLine(furnitureName);
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
