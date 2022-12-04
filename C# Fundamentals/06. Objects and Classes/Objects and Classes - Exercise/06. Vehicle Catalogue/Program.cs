using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = inputArgs[0];
                string model = inputArgs[1];
                string color = inputArgs[2];
                double horsepower = double.Parse(inputArgs[3]);
                Vehicle newVehicle = new Vehicle(type, model, color, horsepower);
                if (!vehicles.Any(x => x.Model == model))
                    vehicles.Add(newVehicle);
            }
            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                Vehicle specialVehicle = vehicles.Find(x => x.Model.Contains(input));
                if (specialVehicle.Type == "car")
                {
                    Console.WriteLine($"Type: Car");
                }
                else
                {
                    Console.WriteLine($"Type: Truck");
                }
                Console.WriteLine($"Model: {specialVehicle.Model}");
                Console.WriteLine($"Color: {specialVehicle.Color}");
                Console.WriteLine($"Horsepower: {specialVehicle.Horsepower}");
            }
            double carsAverage = 0;
            double trucksAverage = 0;
            if (vehicles.Any(x => x.Type.Contains("car")))
            {
                carsAverage = vehicles.Where(x => x.Type.Contains("car")).Average(x => x.Horsepower);
            }
            if (vehicles.Any(x => x.Type.Contains("truck")))
            {
                trucksAverage = vehicles.Where(x => x.Type.Contains("truck")).Average(x => x.Horsepower);
            }
            Console.WriteLine($"Cars have average horsepower of: {carsAverage:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverage:f2}.");
        }
    }
    public class Vehicle
    {
        private readonly List<string> vehicles;

        public Vehicle(string type, string model, string color, double horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;

            vehicles = new List<string>();
        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public double Horsepower { get; set; }

        public List<string> Vehicles
            => vehicles;
    }
}
