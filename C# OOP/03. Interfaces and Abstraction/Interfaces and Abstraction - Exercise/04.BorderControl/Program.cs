using BorderControl;

List<IIdentifiable> society = new();

string input;
while ((input = Console.ReadLine()) != "End")
{
    string[] inputArgs = input.Split();
    if (inputArgs.Length == 3)
    {
        IIdentifiable citizen = new Citizen(inputArgs[0], int.Parse(inputArgs[1]), inputArgs[2]);
        society.Add(citizen);
    }
    else
    {
        IIdentifiable robot = new Robot(inputArgs[0], inputArgs[1]);
        society.Add(robot);
    }
}

int suspiciousNumber = int.Parse(Console.ReadLine());
foreach (IIdentifiable ident in society)
{
    string id = ident.Id;
    if (id.EndsWith(suspiciousNumber.ToString()))
    {
        Console.WriteLine(id);
    }
}