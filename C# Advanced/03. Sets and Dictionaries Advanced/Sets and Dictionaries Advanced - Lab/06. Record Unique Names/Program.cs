int namesAmount = int.Parse(Console.ReadLine());

HashSet<string> names = new HashSet<string>();

for(int i = 0; i < namesAmount; i++)
{
    names.Add(Console.ReadLine());
}

foreach(string name in names)
{
    Console.WriteLine(name);
}