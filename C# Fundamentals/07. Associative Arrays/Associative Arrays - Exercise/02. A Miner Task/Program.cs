using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourceManagement = new Dictionary<string, int>();

            string resource;
            while ((resource = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!resourceManagement.ContainsKey(resource))
                {
                    resourceManagement.Add(resource, quantity);
                }
                else
                {
                    resourceManagement[resource] += quantity;
                }
            }
            foreach (var item in resourceManagement)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
