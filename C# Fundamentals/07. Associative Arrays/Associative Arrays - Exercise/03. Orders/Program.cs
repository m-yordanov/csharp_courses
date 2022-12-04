using System;
using System.Collections.Generic;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(" ");
            var products = new Dictionary<string, List<double>>();

            while (strings[0] != "buy")
            {
                string productName = strings[0];
                double price = double.Parse(strings[1]);
                int quantity = int.Parse(strings[2]);
                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, new List<double>());
                    products[productName].Add(price);
                    products[productName].Add(quantity);
                }
                else
                {
                    products[productName][1] += quantity;
                    products[productName][0] = price;
                }
                strings = Console.ReadLine().Split();
            }
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {(product.Value[0] * product.Value[1]):f2}");
            }
        }
    }
}
