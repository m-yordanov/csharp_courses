using System;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] filePath = Console.ReadLine().Split("\\");
            string[] lastFile = filePath[filePath.Length - 1].Split('.');
            Console.WriteLine($"File name: {lastFile[0]}");
            Console.WriteLine($"File extension: {lastFile[1]}");
        }
    }
}
