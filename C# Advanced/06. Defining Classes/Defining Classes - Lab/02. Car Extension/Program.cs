﻿namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Car car = new Car()
            {
                Make = "BMW",
                Model = "X3",
                Year = 2006,
                FuelConsumption = 10,
                FuelQuantity = 100
            };

            car.Drive(10);

            Console.WriteLine(car.WhoAmI());
        }
    }
}