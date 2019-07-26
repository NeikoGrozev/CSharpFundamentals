namespace SpeedRacing
{
    using System;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Cars cars = new Cars();

            for (int i = 0; i < num; i++)
            {
                string[] newCar = Console.ReadLine()
                    .Split(" ");

                string carModel = newCar[0];
                double fuelAmount = double.Parse(newCar[1]);
                double fuelConsumption = double.Parse(newCar[2]);
                               
                Car car = new Car(carModel, fuelAmount, fuelConsumption);
                cars.CreateNewCar(car);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] command = input
                    .Split(" ");

                string carModel = command[1];
                int carKilometarsTraveled = int.Parse(command[2]);

                cars.CarTraveling(carModel, carKilometarsTraveled);
            }

            cars.PrintCar();
        }
    }

    class Car
    {
        public string CarModel { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumption { get; set; }
        public int KilometersTraveled { get; set; }

        public Car(string carModel, double fuelAmount, double fuelConsumption)
        {
            this.CarModel = carModel;
            this.FuelAmount = fuelAmount;
            this.FuelConsumption = fuelConsumption;
        }
    }

    class Cars
    {
        List<Car> Car { get; set; }

        public Cars()
        {
            this.Car = new List<Car>();
        }

        public void CreateNewCar(Car car)
        {
            if (!Car.Contains(car))
            {
                this.Car.Add(car);
            }
        }

        public void CarTraveling(string carModel, int kilometersTraveled)
        {
            foreach (var item in Car)
            {
                if (item.CarModel == carModel)
                {
                    if (item.FuelAmount >= kilometersTraveled * item.FuelConsumption)
                    {
                        item.FuelAmount -= kilometersTraveled * item.FuelConsumption;
                        item.KilometersTraveled += kilometersTraveled;
                    }
                    else
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }
                }
            }
        }

        public void PrintCar()
        {
            foreach (var item in Car)
            {
                Console.WriteLine($"{item.CarModel} {item.FuelAmount:F2} {item.KilometersTraveled}");
            }
        }
    }
}
