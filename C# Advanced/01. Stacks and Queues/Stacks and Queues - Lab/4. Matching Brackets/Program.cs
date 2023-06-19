string expression = Console.ReadLine();
Stack<int> indexes = new Stack<int>();
for(int i = 0; i < expression.Length; i++)
{
    if (expression[i] == '(')
    {
        indexes.Push(i);
    }
    else if (expression[i] == ')')
    {
        int indexesOfOpenBracket = indexes.Pop();
        for(int j = indexesOfOpenBracket; j <= i; j++)
        {
            Console.Write(expression[j]);
        }
        Console.WriteLine();
    }
}
