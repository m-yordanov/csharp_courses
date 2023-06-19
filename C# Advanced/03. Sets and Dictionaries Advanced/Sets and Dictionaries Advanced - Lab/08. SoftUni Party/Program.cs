using System.Data;

HashSet<string> guestsRegular = new HashSet<string>();
HashSet<string> guestsVIP = new HashSet<string>();
int missingGuests = 0;

string guestList = Console.ReadLine();
while (guestList != "PARTY")
{
    if (Char.IsDigit(guestList, 0))
    {
        guestsVIP.Add(guestList);
    }
    else
    {
        guestsRegular.Add(guestList);
    }

    guestList = Console.ReadLine();
}

string visitors = Console.ReadLine();
while(visitors != "END")
{
    if(guestsVIP.Contains(visitors))
    {
        guestsVIP.Remove(visitors);
    }
    else if(guestsRegular.Contains(visitors))
    {
        guestsRegular.Remove(visitors);
    }

    visitors = Console.ReadLine();
}

missingGuests = guestsVIP.Count + guestsRegular.Count;
Console.WriteLine(missingGuests);

foreach (string guest in guestsVIP)
{
    Console.WriteLine(guest);
}

foreach(string guest in guestsRegular)
{
    Console.WriteLine(guest);
}