namespace VehiclesExtension;

public interface IVehicleFactory
{
    IVehicle Create(string type, double fuelQuantity, double fuelConsumption, double tankCapacity);
}