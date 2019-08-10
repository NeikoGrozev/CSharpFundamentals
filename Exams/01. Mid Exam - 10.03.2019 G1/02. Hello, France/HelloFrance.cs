using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloFrance
{
    class HelloFrance
    {
        static void Main()
        {

            string[] collectionOfItem = Console.ReadLine()
                .Split(new char[] { '|', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            double budget = double.Parse(Console.ReadLine());

            List<double> priceCollections = new List<double>();

            for (int i = 0; i < collectionOfItem.Length; i += 2)
            {
                double price = double.Parse(collectionOfItem[i + 1]);

                if (collectionOfItem[i] == "Clothes" && price > 50.00)
                {
                    continue;
                }
                else if (collectionOfItem[i] == "Shoes" && price > 35.00)
                {
                    continue;
                }
                else if (collectionOfItem[i] == "Accessories" && price > 20.50)
                {
                    continue;
                }

                if (budget >= price)
                {
                    budget -= price;
                    priceCollections.Add(double.Parse(collectionOfItem[i + 1]));
                }
            }

            double profit = 0;
            

            for (int i = 0; i < priceCollections.Count; i++)
            {
                double newPrice = priceCollections[i] * 1.40;

                profit += newPrice - priceCollections[i];

                priceCollections[i] = newPrice;
              
                Console.Write($"{priceCollections[i]:F2} ");
            }

            Console.WriteLine();
            Console.WriteLine($"Profit: {profit:F2}");


            if (budget + priceCollections.Sum() >= 150)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }
        }
    }
}
