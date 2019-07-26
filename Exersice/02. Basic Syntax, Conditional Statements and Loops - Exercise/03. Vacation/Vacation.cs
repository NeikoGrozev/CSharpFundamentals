using System;

class Vacation
{
    static void Main(string[] args)
    {
        int peoples = int.Parse(Console.ReadLine());
        string typeOfGroup = Console.ReadLine();
        string daysOfWeek = Console.ReadLine();

        double price = 0.0;

        if (typeOfGroup == "Students")
        {
            switch (daysOfWeek)
            {
                case "Friday":
                    price = 8.45;
                    break;

                case "Saturday":
                    price = 9.80;
                    break;

                case "Sunday":
                    price = 10.46;
                    break;
            }

            price *= peoples;

            if (peoples >= 30)
            {
                price *= 0.85;
            }

        }
        else if (typeOfGroup == "Busness")
        {
            switch (daysOfWeek)
            {
                case "Friday":
                    price = 10.90;
                    break;

                case "Saturday":
                    price = 15.60;
                    break;

                case "Sunday":
                    price = 16;
                    break;
            }

            if (peoples >= 100)
            {
                peoples -= 10;
            }

            price *= peoples;

        }
        else if (typeOfGroup == "Regular")
        {
            switch (daysOfWeek)
            {
                case "Friday":
                    price = 15;
                    break;

                case "Saturday":
                    price = 20;
                    break;

                case "Sunday":
                    price = 22.50;
                    break;
            }

            price *= peoples;

            if (peoples >= 10 && peoples <= 20)
            {
                price *= 0.95;
            }            
        }

        Console.WriteLine($"Total price: {Math.Round(price)}");
    }
}


