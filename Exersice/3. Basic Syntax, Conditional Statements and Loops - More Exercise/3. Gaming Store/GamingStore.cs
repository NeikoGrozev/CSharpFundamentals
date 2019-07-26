using System;
class Program
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());

        double currentBudget = budget;
        string command = string.Empty;
        bool logic = false;
        double price = 0.0;

        while ((command = Console.ReadLine()) != "Game Time")
        {
            switch (command)
            {
                case "OutFall 4":
                    price = 39.99;
                    logic = true;
                    break;
                case "CS: OG":
                    price = 15.99;
                    logic = true;
                    break;
                case "Zplinter Zell":
                    price = 19.99;
                    logic = true;
                    break;
                case "Honored 2":
                    price = 59.99;
                    logic = true;
                    break;
                case "RoverWatch":
                    price = 29.99;
                    logic = true;
                    break;
                case "RoverWatch Origins Edition":
                    price = 39.99;
                    logic = true;
                    break;
                default:
                    Console.WriteLine("Not Found");
                    logic = false;
                    break;
            }
            if (logic)
            {
                if (currentBudget - price >= 0)
                {
                    currentBudget -= price;
                    Console.WriteLine("Bought {0}", command);

                }
                else if (currentBudget - price < 0)
                {
                    Console.WriteLine("Too Expensive");
                }
            }

            if (currentBudget == 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }
        }

        double totalSpend = budget - currentBudget;
        Console.WriteLine($"Total spent: ${totalSpend:F2}. Remaining: ${currentBudget:F2}");
    }
}

