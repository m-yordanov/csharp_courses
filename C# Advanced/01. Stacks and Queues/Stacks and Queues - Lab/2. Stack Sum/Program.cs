string input = "";
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
Stack<int> stack = new Stack<int>(numbers);
while(input != "end")
{
    input = Console.ReadLine().ToLower();
    if (input == "end")
    {
        break;
    }
    string[] inputArgs = input.Split();
    string command = inputArgs[0];
    int n = int.Parse(inputArgs[1]);
    if(command == "add")
    {
        int n2 = int.Parse(inputArgs[2]);
        stack.Push(n);
        stack.Push(n2);
    }
    else if (command == "remove")
    {
        if(n < stack.Count)
        {
            for (int i = 0; i < n; i++)
            {
                stack.Pop();
            }
        }
    }
}
Console.WriteLine($"Sum: {stack.Sum()}");
