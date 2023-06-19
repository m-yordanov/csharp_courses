string word = Console.ReadLine();
Stack<char> text = new Stack<char>();

foreach(var item in word)
{
    text.Push(item);
}

while(text.Any())
{
    char result = text.Pop();
    Console.Write(result);
}