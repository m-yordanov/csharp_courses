int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int firstSetLength = input[0];
int secondSetLength = input[1];

HashSet<int> firstSet = new HashSet<int>();
HashSet<int> secondSet = new HashSet<int>();

for (int i = 0; i < firstSetLength; i++)
{
    int num = int.Parse(Console.ReadLine());
    firstSet.Add(num);
}

for (int i = 0; i < secondSetLength; i++)
{
    int num = int.Parse(Console.ReadLine());
    secondSet.Add(num);
}

firstSet.IntersectWith(secondSet);

Console.WriteLine(String.Join(" ", firstSet));