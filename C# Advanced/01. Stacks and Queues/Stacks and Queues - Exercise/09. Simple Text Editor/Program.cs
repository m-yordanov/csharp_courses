using System.ComponentModel.Design;
using System.Text;

int n = int.Parse(Console.ReadLine());
Stack<string> changes = new Stack<string>();
string text = String.Empty;

for (int i = 0; i < n; i++)
{
    string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int type = int.Parse(command[0]);
    switch (type)
    {
        case 1:
            changes.Push(text);
            text += command[1];
            break;
        case 2:
            changes.Push(text);
            int count = int.Parse(command[1]);
            text = text.Remove(text.Length - count);
            break;
        case 3:
            int index = int.Parse(command[1]) - 1;
            Console.WriteLine(text[index]);
            break;
        case 4:
            text = changes.Pop();
            break;
    }
}