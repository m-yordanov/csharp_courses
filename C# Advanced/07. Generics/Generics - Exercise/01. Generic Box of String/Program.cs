namespace GenericBoxOfString;

class StartUp
{
    static void Main(string[] args)
    {
        Box<string> box = new Box<string>();
        int count = int.Parse(Console.ReadLine());
        for(int i = 0; i < count; i++)
        {
            string input = Console.ReadLine();
            box.Add(input);
        }
        Console.WriteLine(box.ToString());
    }
}