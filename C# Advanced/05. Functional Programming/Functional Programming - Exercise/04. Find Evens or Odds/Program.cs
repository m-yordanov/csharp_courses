Func<int, int, List<int>> generateRange = (start, end) =>
{
    List<int> range = new();

    for (int i = start; i <= end; i++)
    {
        range.Add(i);
    }

    return range;
};

Func<string, int, bool> evenOrOdd = (condition, number) =>
{
    if (condition == "even")
    {
        return number % 2 == 0;
    }
    else
    {
        return number % 2 != 0;
    }
};

int[] ranges = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

string command = Console.ReadLine();

List<int> numbers = generateRange(ranges[0], ranges[1]);

foreach(var number in numbers)
{
    if(evenOrOdd(command, number))
    {
        Console.Write($"{number} ");
    }
}