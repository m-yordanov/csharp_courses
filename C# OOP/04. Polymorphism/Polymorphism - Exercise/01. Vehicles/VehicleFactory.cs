﻿namespace Vehicles;

public class VehicleFactory : IVehicleFactory
{
    public IVehicle Create(string type, double fuelQuantity, double fuelConsumption)
    {
        switch (type)
        {
            case "Car":
                return new Car(fuelQuantity, fuelConsumption);
            case "Truck":
                return new Truck(fuelQuantity, fuelConsumption);
            default:
                throw new ArgumentException("Invalid vehicle type");
        }
    }
}