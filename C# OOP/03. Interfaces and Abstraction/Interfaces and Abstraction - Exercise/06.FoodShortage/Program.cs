using FoodShortage;

List<IBuyer> buyers = new();
int count = int.Parse(Console.ReadLine());

for(int i = 0 ; i < count; i++)
{
    string person = Console.ReadLine();
    string[] personInfo = person.Split();
    if(personInfo.Length == 4)
    {
        IBuyer citizen = new Citizen(personInfo[0], int.Parse(personInfo[1]), personInfo[2], personInfo[3]);
        buyers.Add(citizen);
    }
    else if (personInfo.Length == 3) 
    {
        IBuyer rebel = new Rebel(personInfo[0], int.Parse(personInfo[1]), personInfo[2]);
        buyers.Add(rebel);
    }
}

string input;
while ((input = Console.ReadLine()) != "End")
{
    string[] inputArgs = input.Split();
    buyers.FirstOrDefault(buyer => buyer.Name == input)?.BuyFood();
}

Console.WriteLine(buyers.Sum(b => b.Food));
