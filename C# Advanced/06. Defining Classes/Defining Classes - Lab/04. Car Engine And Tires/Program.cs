﻿namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Engine engine = new Engine(265, 2);
            Tire[] tires = new Tire[4]
            {
                new Tire(2020, 2.2),
                new Tire(2020, 2.2),
                new Tire(2020, 2.4),
                new Tire(2020, 2.4),
            };
            Car car = new Car("BMW", "X3", 2006, 100, 2, engine, tires);
        }
    }
}