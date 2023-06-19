string command = Console.ReadLine();
HashSet<string> cars = new HashSet<string>();

while (command != "END")
{
    string[] commandArgs = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
    string movement = commandArgs[0];
    string carPlate = commandArgs[1];

    if(movement == "IN")
    {
        cars.Add(carPlate);
    }
    else if(movement == "OUT")
    {
        cars.Remove(carPlate);
    }

    command = Console.ReadLine();
}

if(cars.Count > 0)
{
    foreach(string car in cars)
    {
        Console.WriteLine(car);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}