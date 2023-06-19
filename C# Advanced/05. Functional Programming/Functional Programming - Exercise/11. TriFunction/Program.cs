Func<string, int, bool> calculateSums = (name, requiredSum) =>
{
    int charsSum = name.Sum(ch => ch);

    return charsSum >= requiredSum;
};

Func<string[], int, Func<string, int, bool>, string> getFirstName =
    (names, sum, match) =>
    {
        foreach (var name in names)
        {
            if (match(name, sum))
            {
                return name;
            }
        }

        return null;
    };

int requiredSum = int.Parse(Console.ReadLine());

string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine(getFirstName(names, requiredSum, calculateSums));