string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
Action<string> print = name => Console.WriteLine(name);

foreach (var name in names)
{
    print(name);
}

