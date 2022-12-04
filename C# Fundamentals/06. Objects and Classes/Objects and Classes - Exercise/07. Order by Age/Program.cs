using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ID> citizens = new List<ID>();

            string input;
            while((input = Console.ReadLine()) != "End")
            {
                string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = inputArgs[0];
                string idNumber = inputArgs[1];
                int age = int.Parse(inputArgs[2]);
                ID newCitizen = new ID(name, idNumber, age);
                if(citizens.Any(x => x.IDNumber == idNumber))
                {
                    int replaceIndex= citizens.FindIndex(x => x.IDNumber == idNumber);
                    citizens[replaceIndex] = newCitizen;
                }
                else
                {
                    citizens.Add(newCitizen);
                }
            }
            List<ID> sortedCitizens = citizens.OrderBy(x => x.Age).ToList();
            foreach(ID citizen in sortedCitizens)
            {
                Console.WriteLine($"{citizen.Name} with ID: {citizen.IDNumber} is {citizen.Age} years old.");
            }
        }
    }
    public class ID
    {
        public ID(string name, string idNumber, int age)
        {
            Name = name;
            IDNumber = idNumber;
            Age = age;
        }

        public string Name { get; set; }
        
        public string IDNumber { get; set; }

        public int Age { get; set; }
    }
}
