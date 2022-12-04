using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split().ToArray();
            Console.WriteLine(string.Join(" ", words.Reverse()));
        }
    }
}
