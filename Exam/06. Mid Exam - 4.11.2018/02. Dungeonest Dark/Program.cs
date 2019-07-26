using System;
using System.Collections;

namespace DungeonestDark
{
    class Program
    {
        static void Main()
        {
            string[] args = Console.ReadLine()
                .Split("|");

            int health = 100;
            int coins = 0;
            
            for (int i = 0; i < args.Length; i++)
            {
                string[] monsterOrNot = args[i].Split(" ");
                                
                switch (monsterOrNot[0])
                {
                    case "potion":
                        int addHelth = int.Parse(monsterOrNot[1]);

                        if (health + addHelth <= 100)
                        {
                            health += addHelth;

                            Console.WriteLine($"You healed for {addHelth} hp.");
                            Console.WriteLine($"Current health: {health} hp.");
                        }
                        else if (health + addHelth > 100)
                        {
                            int currentAddHealth = 100 - health;
                            health = 100;

                            Console.WriteLine($"You healed for {currentAddHealth} hp.");
                            Console.WriteLine($"Current health: {health} hp.");
                        }
                        break;
                    case "chest":
                        int addCoins = int.Parse(monsterOrNot[1]);

                        coins += addCoins;
                        Console.WriteLine($"You found {addCoins} coins.");
                        break;
                    default:
                        string monster = monsterOrNot[0];
                        int monsterAttack = int.Parse(monsterOrNot[1]);

                        if (health - monsterAttack > 0)
                        {
                            health -= monsterAttack;
                            Console.WriteLine($"You slayed {monster}.");
                        }
                        else if (health - monsterAttack <= 0)
                        {
                            Console.WriteLine($"You died! Killed by {monster}.");
                            Console.WriteLine($"Best room: {i + 1}");
                            return;
                        }
                        break;
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
