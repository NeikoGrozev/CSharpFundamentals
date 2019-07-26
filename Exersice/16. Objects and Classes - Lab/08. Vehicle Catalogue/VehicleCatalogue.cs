using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class VehicleCatalogue
    {
        static void Main()
        {

            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split('/');

                if (command[0] == "end")
                {
                    break;
                }

                if (command[0] == "Car")
                {
                    string brand = command[1];
                    string model = command[2];
                    string horsePower = command[3];

                    Car car = new Car(brand, model, horsePower);

                    cars.Add(car);
                }
                else if (command[0] == "Truck")
                {
                    string brand = command[1];
                    string model = command[2];
                    string weight = command[3];

                    Truck truck = new Truck(brand, model, weight);

                    trucks.Add(truck);
                }
            }

            List<Car> filterCar = cars.OrderBy(a => a.Brand).ToList();
            List<Truck> filterTruck = trucks.OrderBy(a => a.Brand).ToList();

            PrintCatalog(filterCar, filterTruck);

        }

        private static void PrintCatalog(List<Car> filterCar, List<Truck> filterTruck)
        {
            if (filterCar.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (Car car in filterCar)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (filterTruck.Count > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (Truck truck in filterTruck)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public string HorsePower { get; set; }

        public Car(string brand, string model, string horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }
    }

    class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public string Weight { get; set; }

        public Truck(string brand, string model, string weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
    }    
}
