using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> employeeList = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArgs = input.Split(" -> ");
                string companyName = inputArgs[0];
                string employeeID = inputArgs[1];
                if (!employeeList.ContainsKey(companyName))
                {
                    employeeList[companyName] = new List<string>();
                }
                if (!employeeList[companyName].Contains(employeeID))
                {
                    employeeList[companyName].Add(employeeID);
                }
            }
            foreach (var company in employeeList)
            {
                string companyName = company.Key;
                List<string> employeeID = company.Value;
                Console.WriteLine(companyName);
                foreach (string employee in employeeID)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
