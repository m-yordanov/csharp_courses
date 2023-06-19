using static System.Formats.Asn1.AsnWriter;

int citiesAmount = int.Parse(Console.ReadLine());
Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

for(int i = 0; i < citiesAmount; i++)
{
    string[] command = Console.ReadLine().Split();
    string continent = command[0];
    string country = command[1];
    string city = command[2];

    if(!continents.ContainsKey(continent))
    {
        continents.Add(continent, new Dictionary<string, List<string>>());
    }

    if (!continents[continent].ContainsKey(country)) 
    {
        continents[continent].Add(country, new List<string>());
    }

    continents[continent][country].Add(city);
}

foreach (var (continent, countries) in continents)
{
    Console.WriteLine($"{continent}:");

    foreach (var (country, cities) in countries)
    {
        Console.WriteLine($"  {country} -> {string.Join(", ", cities)}");
    }
}