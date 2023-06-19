int commandsAmount = int.Parse(Console.ReadLine());
SortedSet<string> elements = new SortedSet<string>();

for (int i = 0; i < commandsAmount; i++)
{
    string[] inputElements = Console.ReadLine().Split();
    elements.UnionWith(inputElements);
}

Console.WriteLine(String.Join(" ", elements));
