namespace VehiclesExtension;

public class Startup
{
    public static void Main()
    {
        IVehicleFactory vehicleFactory = new VehicleFactory();

        ICollection<IVehicle> vehicles;

        vehicles = new List<IVehicle>();

        vehicles.Add(CreateVehicle());
        vehicles.Add(CreateVehicle());
        vehicles.Add(CreateVehicle());

        int commandsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < commandsCount; i++)
        {
            try
            {
                ProcessCommand();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                throw;
            }
        }

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle.ToString());
        }


        IVehicle CreateVehicle()
        {
            string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            return vehicleFactory.Create(tokens[0], double.Parse(tokens[1]), double.Parse(tokens[2]), double.Parse(tokens[3]));
        }

        void ProcessCommand()
        {
            string[] commandTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string command = commandTokens[0];
            string vehicleType = commandTokens[1];

            IVehicle vehicle = vehicles
                .FirstOrDefault(v => v.GetType().Name == vehicleType);

            if (vehicle == null)
            {
                throw new ArgumentException("Invalid vehicle type");
            }

            if (command == "Drive")
            {
                double distance = double.Parse(commandTokens[2]);
                Console.WriteLine(vehicle.Drive(distance));
            }
            else if (command == "DriveEmpty")
            {
                double distance = double.Parse(commandTokens[2]);
                Console.WriteLine(vehicle.Drive(distance, false));
            }
            else if (command == "Refuel")
            {
                double fuelAmount = double.Parse(commandTokens[2]);
                vehicle.Refuel(fuelAmount);
            }
        }
    }
}