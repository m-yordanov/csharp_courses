using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Catalogue catalogue = new Catalogue();
            while((input = Console.ReadLine()) != "end")
            {
                string[] carInfo = input.Split('/');
                string vehicleType = carInfo[0];
                string brand = carInfo[1];
                string model = carInfo[2];
                int value = int.Parse(carInfo[3]);
                if(vehicleType == "Truck")
                {
                    Truck truck = new Truck(brand, model, value);
                    catalogue.Trucks.Add(truck);
                }

                else if(vehicleType == "Car")
                {
                    Car car = new Car(brand, model, value);
                    catalogue.Cars.Add(car);
                }
            }

            if (catalogue.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
            }

            foreach (var car in catalogue.Cars.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            if (catalogue.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
            }

            foreach (var truck in catalogue.Trucks.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }

    public class Catalogue
    {
        public Catalogue()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }

        public List<Truck> Trucks { get; set; }
    }

    public class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    public class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
}
