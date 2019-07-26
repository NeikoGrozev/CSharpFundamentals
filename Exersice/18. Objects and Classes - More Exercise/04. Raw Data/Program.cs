namespace RawData
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Cars cargoCars = new Cars();

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ");

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType);
                cargoCars.AddCar(car);
            }

            string command = Console.ReadLine();
            cargoCars.PrintCar(command);

        }
    }

    class Car
    {
        public string Model { get; set; }
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }

        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType)
        {
            this.Model = model;
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
            this.CargoWeight = cargoWeight;
            this.CargoType = cargoType;
        }
    }

    class Cars
    {
        List<Car> CarCargo { get; set; }

        public Cars()
        {
            this.CarCargo = new List<Car>();
        }

        public void AddCar(Car car)
        {
            if (!CarCargo.Contains(car))
            {
                CarCargo.Add(car);
            }
        }

        public void PrintCar(string command)
        {
            if (command == "fragile")
            {
                foreach (var item in CarCargo)
                {
                    if (item.CargoType == "fragile" && item.CargoWeight < 1000)
                    {
                        Console.WriteLine($"{item.Model}");
                    }
                }
            }
            else if (command == "flamable")
            {
                foreach (var item in CarCargo)
                {
                    if (item.CargoType == "flamable" && item.EnginePower > 250)
                    {
                        Console.WriteLine($"{item.Model}");
                    }
                }
            }
        }
    }
}
