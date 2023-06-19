using System.Diagnostics.Tracing;

SortedDictionary<string, SortedSet<string>> userSides =  new();
string command;

while((command = Console.ReadLine()) != "Lumpawaroo")
{
    if(command.Contains('|'))
    {
        string[] commandArgs = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries);

        string side = commandArgs[0];
        string user = commandArgs[1];

        if(!userSides.Values.Any(u  => u.Contains(user)))
        {
            AssignUserSide(userSides, user, side);
        }
    }
    else if(command.Contains("->"))
    {
        string[] commandArgs = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

        string user = commandArgs[0];
        string side = commandArgs[1];

        foreach (var sideUsers in userSides)
        {
            if (sideUsers.Value.Contains(user))
            {
                sideUsers.Value.Remove(user);
                break;
            }
        }

        AssignUserSide(userSides, user, side);

        Console.WriteLine($"{user} joins the {side} side!");
    }
}

Dictionary<string, SortedSet<string>> orderUserSides = userSides.OrderByDescending(x => x.Value.Count).ToDictionary(x => x.Key, x => x.Value);

foreach(var sideUserSide in orderUserSides)
{
    if(sideUserSide.Value.Any())
    {
        Console.WriteLine($"Side: {sideUserSide.Key}, Members: {sideUserSide.Value.Count}");
        foreach (var user in sideUserSide.Value)
        {
            Console.WriteLine($"! {user}");
        }
    }
}

static void AssignUserSide(SortedDictionary<string, SortedSet<string>> userSides, string user, string side)
{
    if (!userSides.ContainsKey(side))
    {
        userSides.Add(side, new SortedSet<string>());
    }

    userSides[side].Add(user);
}