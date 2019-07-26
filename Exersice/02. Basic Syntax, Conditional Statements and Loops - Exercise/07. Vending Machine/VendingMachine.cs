using System;

class VendingMachine
{
    static void Main()
    {
        string command = string.Empty;

        double sum = 0.0;
        double price = 0.0;
        bool locic = false;

        while ((command = Console.ReadLine()) != "Start")
        {
            double coins = Convert.ToDouble(command);

            if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
            {
                sum += coins;
            }
            else
            {
                Console.WriteLine("Cannot accept {0}", coins);
            }           
        }

        while ((command = Console.ReadLine()) != "End")
        {
            if (command == "Nuts")
            {
                price = 2.0;
                locic = true;
            }
            else if (command == "Water")
            {
                price = 0.7;
                locic = true;
            }
            else if (command == "Crisps")
            {
                price = 1.5;
                locic = true;
            }
            else if (command == "Soda")
            {
                price = 0.8;
                locic = true;
            }
            else if (command == "Coke")
            {
                price = 1.0;
                locic = true;
            }
            else
            {
                locic = false;                
                Console.WriteLine("Invalid product");
            }

            if (locic)
            {
                if (price <= sum)
                {
                    sum -= price;
                    Console.WriteLine("Purchased {0}", command.ToLower());
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
        }

        Console.WriteLine("Change: {0:F2}", sum);
    }
}

