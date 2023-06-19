using System.Collections.Generic;

namespace SoftUniParking;

public class Parking
{
    private Dictionary<string, Car> cars;
    private int capacity;

    public Parking(int capacity)
    {
        cars = new Dictionary<string, Car>();
        this.capacity = capacity;
    }

    public int Count { get { return cars.Count; } }

    public string AddCar(Car car)
    {
        if(cars.ContainsKey(car.RegistrationNumber))
        {
            return "Car with that registration number, already exists!";
        }

        if(this.Count >= this.capacity)
        {
            return "Parking is full!";
        }

        this.cars.Add(car.RegistrationNumber, car);

        return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
    }

    public Car GetCar(string registrationNumber)
    {
        return cars[registrationNumber];
    }

    public string RemoveCar (string registrationNumber)
    {
        if(!cars.ContainsKey(registrationNumber))
        {
            return "Car with that registration number, doesn't exist!";
        }

        cars.Remove(registrationNumber);

        return $"Sucessfully removed {registrationNumber}";
    }
    public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
    {
        foreach (string registarionNumber in RegistrationNumbers)
        {
            RemoveCar(registarionNumber);
        }
    }
}
