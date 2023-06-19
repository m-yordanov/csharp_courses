List<Predicate<int>> predicates = new(); 

int lastNumber = int.Parse(Console.ReadLine());
int[] numbers = Enumerable.Range(1, lastNumber).ToArray();

HashSet<int> dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToHashSet();

foreach (int divider in dividers)
{
    predicates.Add(n => n % divider == 0);
}

foreach (int number in numbers)
{
    bool isDivisible = true;

    foreach(var match in predicates)
    {
        if(!match(number))
        {
            isDivisible = false;
            break;
        }
    }

    if(isDivisible)
    {
        Console.Write($"{number} ");
    }
}

