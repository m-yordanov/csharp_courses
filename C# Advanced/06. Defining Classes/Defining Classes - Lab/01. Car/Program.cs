﻿using Microsoft.VisualBasic;
using System.Xml.Schema;

namespace CarManufacturer
{
    public class StartUp
{
        static void Main()
        {
            Car car = new Car()
            {
                Make = "BMW",
                Model = "X3",
                Year = 2006
            };

            Console.WriteLine(car.Make);
        }
}
}