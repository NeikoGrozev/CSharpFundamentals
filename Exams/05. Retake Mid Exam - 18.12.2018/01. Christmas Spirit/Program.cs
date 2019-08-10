using System;

namespace ChristmasSpirit
{
    class Program
    {
        static void Main()
        {
            int quantity = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int ornamentSet = 2;
            int treeSkirt = 5;
            int treeGarlands = 3;
            int treeLights = 15;

            int sum = 0;
            int spirit = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i % 11 == 0)
                {
                    quantity += 2;
                }

                if (i % 2 == 0)
                {
                    sum += ornamentSet * quantity;
                    spirit += 5;
                }

                if (i % 3 == 0)
                {
                    sum += treeSkirt * quantity + treeGarlands * quantity;
                    spirit += 13;
                }

                if (i % 5 == 0)
                {
                    sum += treeLights * quantity;
                    spirit += 17;

                    if (i % 3 == 0)
                    {
                        spirit += 30;
                    }
                }

                if (i % 10 == 0)
                {
                    spirit -= 20;
                    sum += treeSkirt + treeGarlands + treeLights;

                    if (i == 10 && days % 10 == 0)
                    {
                        spirit -= 30;
                    }
                }
            }


            Console.WriteLine($"Total cost: {sum}");
            Console.WriteLine($"Total spirit: {spirit}");
        }
    }
}
