List<Predicate<string>> predicates = new();

List<string> visitors = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

string command;
while((command = Console.ReadLine()) != "Party!")
{
    string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string action = commandArgs[0];
    string filter = commandArgs[1];
    string value = commandArgs[2];

    if(action == "Remove")
    {
        visitors.RemoveAll(GetPredicate(filter, value));
    }
    else if(action == "Double")
    {
        List<string> peopleToDouble = visitors.FindAll(GetPredicate(filter, value));

        foreach(string person in peopleToDouble)
        {
            int index = visitors.FindIndex(p => p == person);
            visitors.Insert(index, person);
        }
    }
}

if(visitors.Any())
{
    Console.WriteLine($"{string.Join(", ", visitors)} are going to the party!");
}
else
{
    Console.WriteLine("Nobody is going to the party!");
}
static Predicate<string> GetPredicate(string filter, string value)
{
    switch (filter)
    {
        case "StartsWith":
            return n => n.StartsWith(value);
        case "EndsWith":
            return n => n.EndsWith(value);
        case "Length":
            return n => n.Length == int.Parse(value);
        default:
            return default(Predicate<string>);
    }
     
}

