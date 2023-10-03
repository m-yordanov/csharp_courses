using BirthdayCelebrations;

List<IBirthday> societyBirths = new();

string input;
while ((input = Console.ReadLine()) != "End")
{
    string[] inputArgs = input.Split();
    if (inputArgs[0] == "Citizen")
    {
        IBirthday citizen = new Citizen(inputArgs[1], int.Parse(inputArgs[2]), inputArgs[3], inputArgs[4]);
        societyBirths.Add(citizen);
    }
    else if (inputArgs[0] == "Pet")
    {
        IBirthday pet = new Pet(inputArgs[1], inputArgs[2]);
        societyBirths.Add(pet);
    }
}

int year = int.Parse(Console.ReadLine());
foreach (IBirthday ident in societyBirths)
{
    string date = ident.BirthDate;
    string[] dateArgs = date.Split('/');
    string currYear = dateArgs[2];
    if (currYear == year.ToString())
    {
        Console.WriteLine(date);
    }
}