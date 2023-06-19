int n = int.Parse(Console.ReadLine());
string command = Console.ReadLine();
Queue<string> cars = new Queue<string>();
int carsCount = 0;

while (command != "end")
{
    if (command != "green")
    {
        cars.Enqueue(command);
        command = Console.ReadLine();
        continue;
    }

    int currentCount = n;

    while (cars.Count > 0 && currentCount > 0)
    {
        carsCount++;
        Console.WriteLine($"{cars.Dequeue()} passed!");
        currentCount--;
    }
    command = Console.ReadLine();
}
Console.WriteLine($"{carsCount} cars passed the crossroads.");