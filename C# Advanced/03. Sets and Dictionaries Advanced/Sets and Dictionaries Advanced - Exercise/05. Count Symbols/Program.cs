using System;

SortedDictionary<char, int> chars = new SortedDictionary<char, int>();
string inputString = Console.ReadLine();

foreach (char c in inputString)
{
    if (!chars.ContainsKey(c))
    {
        chars.Add(c, 1);
    }
    else
    {
        chars[c]++;
    }
}

foreach (var item in chars)
{
    Console.WriteLine($"{item.Key}: {item.Value} time/s");
}