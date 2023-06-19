Func<int[], int> smallestNumber = x => x.Min();

int[] integers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


Console.WriteLine(smallestNumber(integers));