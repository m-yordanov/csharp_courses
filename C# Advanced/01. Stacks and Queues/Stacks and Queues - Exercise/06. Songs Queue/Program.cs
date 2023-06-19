using Microsoft.VisualBasic;
using System.ComponentModel.Design;

Queue<string> songs  = new (Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries));
while(songs.Any())
{
    string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    if (command[0] == "Play")
    {
        songs.Dequeue();
    }
    else if (command[0] == "Add")
    {
        string request = string.Join(" ", command.Skip(1));
        if(!songs.Contains(request))
        {
            songs.Enqueue(request);
        }
        else
        {
            Console.WriteLine($"{request} is already contained!");
        }
    }
    else if (command[0] == "Show")
    {
        Console.WriteLine(string.Join(", ", songs));
    }
}
Console.WriteLine("No more songs!");