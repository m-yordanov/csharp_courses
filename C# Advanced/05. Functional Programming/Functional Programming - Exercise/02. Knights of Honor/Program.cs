Action<string[]> printWithAddedTitle = names =>
{
    foreach (var name in names)
    {
        Console.WriteLine($"Sir {name}");
    }
};

string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

printWithAddedTitle(input);