using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            int amount = 0;
            string book = Console.ReadLine();
            while (favoriteBook != book)
            {
                book = Console.ReadLine();
                amount++;
                if(book == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {amount} books.");
                    break;
                }
            }
            if (book == favoriteBook)
            {
                Console.WriteLine($"You checked {amount} books and found it.");
            }
        }
    }
}
