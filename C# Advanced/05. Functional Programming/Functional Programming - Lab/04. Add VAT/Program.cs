double[] prices = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).Select(x => x * 1.20).ToArray();
foreach (var price in prices)
{
    Console.WriteLine($"{price:f2}");
}