using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main()
        {
            List<VehicleCatalogue> catalogue = new List<VehicleCatalogue>();

            while (true)
            {
                List<string> command = Console.ReadLine()
                    .Split(" ")
                    .ToList();

                if (command[0] == "End")
                {
                    break;
                }

                string type = command[0];
                string model = command[1];
                string color = command[2];
                int horsePower = int.Parse(command[3]);

                VehicleCatalogue vehicle = new VehicleCatalogue(type, model, color, horsePower);
                catalogue.Add(vehicle);
            }

            List<string> modelPrint = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Close the Catalogue")
                {
                    break;
                }

                modelPrint.Add(input);
            }

            foreach (var model in modelPrint)
            {
                foreach (var vehicleColection in catalogue)
                {
                    if (vehicleColection.Model == model)
                    {
                        Console.WriteLine($"Type: {vehicleColection.Type.First().ToString().ToUpper() + vehicleColection.Type.Substring(1)}");
                        Console.WriteLine($"Model: {vehicleColection.Model}");
                        Console.WriteLine($"Color: {vehicleColection.Color}");
                        Console.WriteLine($"Horsepower: {vehicleColection.HorsePower}");
                        break;
                    }
                }
            }

            double averageHorsepowerCar = 0;
            double averageHorsepowerTruck = 0;
            int counterCar = 0;
            int counterTruck = 0;

            foreach (var model in catalogue)
            {
                if (model.Type == "car")
                {
                    averageHorsepowerCar += model.HorsePower;
                    counterCar++;
                }
                else if (model.Type == "truck")
                {
                    averageHorsepowerTruck += model.HorsePower;
                    counterTruck++;
                }
            }

            averageHorsepowerCar /= counterCar;
            averageHorsepowerTruck /= counterTruck;

            if (counterCar > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageHorsepowerCar:F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:F2}.");
            }

            if (counterTruck > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageHorsepowerTruck:F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");
            }
        }
    }

    class VehicleCatalogue
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public VehicleCatalogue(string type, string model, string color, int horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
    }
}
