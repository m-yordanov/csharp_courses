using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>
            {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //Sum - Get the sum of all values
            Console.WriteLine(numbers.Sum());

            //Min - Get the smallest value
            Console.WriteLine(numbers.Min());

            //Average - Get the average value
            Console.WriteLine(numbers.Average());

            //Max - Get the max value
            Console.WriteLine(numbers.Max());

            //Add - Add a value to the list
            numbers.Add(11);
            Console.WriteLine(numbers);

            //Remove - Remove a certain value from a list
            numbers.Remove(11);

            //RemoveAt - Remove a value from a certain index
            numbers.RemoveAt(4);

            //AddRange - Append one collection into another
            numbers.AddRange(new int[] { 1, 2, 3, 4 });

            //Skip - Skip certain parts of the list
            Console.WriteLine(string.Join(" ", numbers.Skip(2)));

            //Take - Take only those first two elements
            Console.WriteLine(string.Join(" ", numbers.Take(2)));

            //Contains - Check if it contains a value
            if (numbers.Contains(1))
            {
                Console.WriteLine(numbers);
            }

            //OrderBy - Order the numbers
            Console.WriteLine(string.Join(" ", numbers.OrderBy(x => x)));

            //OrderByDescending - Order the numbers by descending order
            Console.WriteLine(string.Join(" ", numbers.OrderByDescending(x => x)));

            //Where
            Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));

            //All - Check if all numbers follow a certain condition(bool)
            Console.WriteLine(string.Join(" ", numbers.All(x => x % 2 == 0)));

            //Any - Check if any number follows a certain condition
            Console.WriteLine(string.Join(" ", numbers.Any(x => x % 2 == 0)));

            //First - Find first number to follow a certain condition
            global::System.Console.WriteLine(string.Join("", numbers.First(x => x % 2 != 0);

            //Select - Modify every number in the list
            Console.WriteLine(string.Join(" ", numbers.Select(x => x + 2)));
        }
    }
}
