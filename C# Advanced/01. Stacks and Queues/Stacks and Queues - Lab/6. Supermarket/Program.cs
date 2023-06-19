string command = "";
Queue<string> queue = new Queue<string>();
while(command != "End")
{
    command = Console.ReadLine();
    if (command == "End")
    {
        break;
    }
    else if (command == "Paid")
    {
        foreach (string item in queue)
        {
            Console.WriteLine(item);
        }
        queue.Clear();
    }
    else
    {
        queue.Enqueue(command);
    }
}
Console.WriteLine($"{queue.Count} people remaining.");