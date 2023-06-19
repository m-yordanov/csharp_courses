Dictionary<double, int> timesContained = new Dictionary<double, int>();
double[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

foreach (double number in numbers)
{
    if (!timesContained.ContainsKey(number))
    {
        timesContained.Add(number, 1);
    }
    else
    {
        timesContained[number]++;
    }
}

foreach (var item in timesContained)
{
    Console.WriteLine($"{item.Key} - {item.Value} times");
}