int[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int n = tokens[0];
int s = tokens[1];
int x = tokens[2];
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
Stack<int> stack = new Stack<int>();
for (int i = 0; i < n; i++)
{
    stack.Push(numbers[i]);
}
for (int i = 0; i < s; i++)
{
    stack.Pop();
}
if (stack.Contains(x))
{
    Console.WriteLine("true");
}
else
{
    if (stack.Any())
    {
        Console.WriteLine(stack.Min());
    }
    else
    {
        Console.WriteLine(0);
    }
}