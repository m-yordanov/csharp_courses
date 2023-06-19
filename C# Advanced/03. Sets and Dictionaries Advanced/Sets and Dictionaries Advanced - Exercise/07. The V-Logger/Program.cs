using System.Data;

Dictionary<string, Dictionary<string, HashSet<string>>> users = new Dictionary<string, Dictionary<string, HashSet<string>>>();
string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

while (input[0] != "Statistics")
{
    string firstVlogger = input[0];
    string inputType = input[1];
    if(inputType == "joined")
    {
        if(!users.ContainsKey(firstVlogger))
        {
            users.Add(firstVlogger, new Dictionary<string, HashSet<string>>());
            users[firstVlogger].Add("followers", new HashSet<string>());
            users[firstVlogger].Add("following", new HashSet<string>());
        }
    }
    else if (inputType == "followed")
    {
        string secondVlogger = input[2];
        if(users.ContainsKey(secondVlogger) && users.ContainsKey(firstVlogger) && firstVlogger != secondVlogger)
        {
            users[firstVlogger]["following"].Add(secondVlogger);
            users[secondVlogger]["followers"].Add(firstVlogger);
        }
    }

    input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
}

Console.WriteLine($"The V-Logger has a total of {users.Count} vloggers in its logs.");

int counter = 1;

foreach (var vlogger in users.OrderByDescending(v => v.Value["followers"].Count).ThenBy(v => v.Value["following"].Count))
{
    Console.WriteLine($"{counter}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");
    if (counter == 1)
    {
        foreach(var item in vlogger.Value["followers"].OrderBy(x => x))
        {
            Console.WriteLine($"*  {item}");
        }
    }
    counter++;
}
