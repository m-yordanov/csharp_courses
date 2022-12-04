using System;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> registry = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string username = input[1];
                if (input[0] == "register")
                {
                    string licensePlate = input[2];
                    if (registry.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    }
                    else
                    {
                        registry[username] = licensePlate;
                        Console.WriteLine($"{username} registered {licensePlate} successfully");
                    }
                }
                else if (input[0] == "unregister")
                {
                    if (!registry.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        registry.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }
            foreach (var item in registry)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
