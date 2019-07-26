namespace BreadFactory
{
    using System;

    class Program
    {
        static void Main()
        {
            int energy = 100;
            int coins = 100;

            string[] str = Console.ReadLine()
                 .Split('|');

            for (int i = 0; i < str.Length; i++)
            {
                string[] command = str[i].Split('-');

                switch (command[0])
                {
                    case "rest":

                        int addEnergy = int.Parse(command[1]);

                        if (energy + addEnergy < 100)
                        {
                            energy += addEnergy;

                            Console.WriteLine($"You gained {addEnergy} energy.");
                        }
                        else
                        {
                            int currentenergy = 100 - energy;
                            energy = 100;

                            Console.WriteLine($"You gained {currentenergy} energy.");
                        }

                        Console.WriteLine($"Current energy: {energy}.");
                        break;

                    case "order":

                        energy -= 30;

                        int addCoins = int.Parse(command[1]);

                        if (energy >= 0)
                        {
                            coins += addCoins;
                            Console.WriteLine($"You earned {addCoins} coins.");
                        }
                        else
                        {
                            energy += 80;
                            Console.WriteLine($"You had to rest!");
                        }
                        break;

                    default:

                        int sumForProduct = int.Parse(command[1]);
                        string product = command[0];

                        if (coins - sumForProduct > 0)
                        {
                            coins -= sumForProduct;
                            Console.WriteLine($"You bought {product}.");
                        }
                        else
                        {
                            Console.WriteLine($"Closed! Cannot afford {product}.");
                            return;
                        }
                        break;
                }
            }

            Console.WriteLine("Day completed!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Energy: {energy}");
        }
    }
}
