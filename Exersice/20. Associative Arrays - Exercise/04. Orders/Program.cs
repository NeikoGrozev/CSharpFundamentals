namespace Orders
{
    using System;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main()
        {
            Dictionary<string, decimal> dictPrice = new Dictionary<string, decimal>();
            Dictionary<string, int> dictQuantity = new Dictionary<string, int>();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(" ");

                if (command[0] == "buy")
                {
                    break;
                }

                string product = command[0];
                decimal price = decimal.Parse(command[1]);
                int quantity = int.Parse(command[2]);

                if (dictPrice.ContainsKey(product))
                {
                    dictPrice[product] = price;
                    dictQuantity[product] += quantity;
                }
                else
                {
                    dictPrice.Add(product, price);
                    dictQuantity.Add(product, quantity);
                }
            }

            foreach (var itemPrice in dictPrice)
            {
                foreach (var itemQuantity in dictQuantity)
                {
                    if (itemPrice.Key == itemQuantity.Key)
                    {
                        Console.WriteLine($"{itemPrice.Key} -> {itemPrice.Value * itemQuantity.Value:F2}");
                    }
                }
            }
        }
    }
}
