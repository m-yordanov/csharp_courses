using System;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            foreach(char c in text)
            {
                if(Char.IsDigit(c))
                {
                    Console.Write(c);
                }
            }
            Console.WriteLine();
            foreach(char c in text)
            {
                if(Char.IsLetter(c))
                {
                    Console.Write(c);
                }
            }
            Console.WriteLine();
            foreach(char c in text)
            {
                if(!Char.IsDigit(c) && !Char.IsLetter(c))
                {
                    Console.Write(c);
                }
            }
        }
    }
}
