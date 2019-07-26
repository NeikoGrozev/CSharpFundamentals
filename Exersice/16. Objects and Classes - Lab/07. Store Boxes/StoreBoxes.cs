using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class StoreBoxes
    {
        static void Main()
        {
            List<Box> boxes = new List<Box>();

            while (true)
            {
                string[] product = Console.ReadLine()
                    .Split(' ');

                if (product[0] == "end")
                {
                    break;
                }

                string serialNumber = product[0];
                string name = product[1];
                int quality = int.Parse(product[2]);
                decimal price = decimal.Parse(product[3]);

                Items item = new Items(name, price);
                Box box = new Box(serialNumber, item, quality);

                boxes.Add(box);
            }

            List<Box> filterBox = boxes.OrderByDescending(a => a.PriceBox).ToList();

            foreach (Box printBox in filterBox)
            {
                Console.WriteLine(printBox.SerialNumber);
                Console.WriteLine($"-- {printBox.Item} - ${printBox.Price:F2}: {printBox.Quality}");
                Console.WriteLine($"-- ${printBox.PriceBox:F2}");
            }
        }
    }

    public class Box
    {
        public Box(string serialNumber, Items item, int quality)
        {
            this.SerialNumber = serialNumber;
            this.Item = item.Name;
            this.Quality = quality;
            this.Price = item.Price;
            this.PriceBox = quality * item.Price;
        }

        public string SerialNumber { get; set; }

        public string Item { get; set; }

        public int Quality { get; set; }

        public decimal Price { get; set; }

        public decimal PriceBox { get; set; }
    }

    public class Items
    {
        public Items(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name { get; set; }

        public decimal Price { get; set; }

    }

}
