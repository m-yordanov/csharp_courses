﻿namespace GenericBoxOfInteger;

class StartUp
{
    static void Main(string[] args)
    {
        Box<int> box = new Box<int>();
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            int input = int.Parse(Console.ReadLine());
            box.Add(input);
        }
        Console.WriteLine(box.ToString());
    }
}