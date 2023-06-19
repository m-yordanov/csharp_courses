int n = int.Parse(Console.ReadLine());
Stack<int> stack = new Stack<int>();
for (int i = 0; i < n; i++)
{
    int[] query = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    int queryType = query[0];
    if (queryType == 1)
    {
        int x = query[1];
        stack.Push(x);
    }
    else if (queryType == 2)
    {
        stack.Pop();
    }
    else if (queryType == 3)
    {
        if (stack.Any())
        {
            Console.WriteLine(stack.Max());
        }
    }
    else if (queryType == 4)
    {
        if (stack.Any())
        {
            Console.WriteLine(stack.Min());
        }
    }
}
Console.WriteLine(String.Join(", ", stack));
