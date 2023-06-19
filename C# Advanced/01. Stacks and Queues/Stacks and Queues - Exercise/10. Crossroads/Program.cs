int greenTime = int.Parse(Console.ReadLine());
int freeWindow = int.Parse(Console.ReadLine());
int totalTime = greenTime + freeWindow;
string command = "";
Queue<string> cars = new Queue<string>();
int carsLength = 0;
int carsPassed = 0;

while(command != "END")
{
    command = Console.ReadLine();
    if (command == "green")
    {
        foreach(var item in cars)
        {
            if(carsLength < greenTime)
            {
                carsPassed++;
                foreach (char c in item)
                {
                    carsLength++;
                    if (carsLength > totalTime)
                    {
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{item} was hit at {c}.");
                        return;
                    }
                }
            }
        }
        cars.Clear();
        carsLength = 0;
    }
    else
    {
        cars.Enqueue(command);
    }
}
Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{carsPassed} total cars passed the crossroads.");