namespace Vehicles;

public interface IVehicleFactory
{
    IVehicle Create(string type, double fuelQuantity, double fuelConsumption);
}