using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace T06_Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            List<Vehicle> list = new List<Vehicle>();
            while ((command = Console.ReadLine()) != "End")
            {
                string[] vechicalInfo = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string type = vechicalInfo[0].ToLower();
                string model = vechicalInfo[1];
                string color = vechicalInfo[2].ToLower();
                int horsePower = int.Parse(vechicalInfo[3]);
                Vehicle vehicle = new Vehicle(type, model, color, horsePower);
                list.Add(vehicle);
            }

                    List<int> numCars = new List<int>();
                    List<int> numTrucks = new List<int> ();
                    double horsePowerCars = 0;
                    double horsePowerTrucks = 0;
            while ((command = Console.ReadLine()) != "Close the Catalogue")
            {

                foreach (Vehicle vehicle in list)
                {

                    if (vehicle.Type == "car")
                    {
                        numCars.Add(1);
                        horsePowerCars += vehicle.HorsePower;
                    }
                    else if (vehicle.Type == "truck")
                    {
                        numTrucks.Add(1);
                        horsePowerTrucks += vehicle.HorsePower;
                    }
                    if (vehicle.Model == command)
                    {
                        Console.WriteLine(string.Join(Environment.NewLine, vehicle));
                    }


                }

                

            }
            double averageHorsePowCars = horsePowerCars / numCars.Count;
            double avarageHorsePowTrucks = horsePowerTrucks / numTrucks.Count;
            if (numCars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageHorsePowCars:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            if (numTrucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {avarageHorsePowTrucks:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }
    public class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; set; }
        public string Model { get; set; }

        public string Color { get; set; }
        public int HorsePower { get; set; }

        public override string ToString()
        {
            string vehicaleStr = $"Type: {(this.Type == "car" ? "Car" : "Truck")}{Environment.NewLine}" +
                                 $"Model: {this.Model}{Environment.NewLine}" +
                                 $"Color: {this.Color}{Environment.NewLine}" + 
                                 $"Horsepower: {this.HorsePower}";

            return vehicaleStr;
        }

    }
}
