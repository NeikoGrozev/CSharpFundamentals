namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string inputOne = Console.ReadLine();
            string inputTwo = Console.ReadLine();

            List<Person> personsCollection = new List<Person>();
            List<Product> productsCollection = new List<Product>();

            string[] commandOne = inputOne
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            string[] commandTwo = inputTwo
                .Split(";");

            for (int i = 0; i < commandOne.Length; i++)
            {
                string[] token = commandOne[i]
                    .Split("=", StringSplitOptions.RemoveEmptyEntries);

                if (token.Length == 0)
                {
                    break;
                }

                string name = token[0];
                int money = int.Parse(token[1]);

                Person person = new Person(name, money);
                personsCollection.Add(person);
            }

            for (int i = 0; i < commandTwo.Length; i++)
            {
                string[] token = commandTwo[i]
                    .Split("=", StringSplitOptions.RemoveEmptyEntries);

                if (token.Length == 0)
                {
                    break;
                }
                string name = token[0];
                int cost = int.Parse(token[1]);

                Product products = new Product(name, cost);
                productsCollection.Add(products);
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                string[] token = command
                    .Split(" ");

                string personName = token[0];
                string productName = token[1];

                int price = 0;
                bool isHave = false;

                foreach (var item in productsCollection)
                {
                    if (item.Name == productName)
                    {
                        price = item.Cost;
                        isHave = true;
                    }
                }

                if (isHave)
                {
                    foreach (var item in personsCollection)
                    {
                        if (item.Name == personName)
                        {
                            if (item.Money >= price)
                            {
                                item.Money -= price;
                                item.Products.Add(productName);

                                Console.WriteLine($"{personName} bought {productName}");
                            }
                            else
                            {
                                Console.WriteLine($"{personName} can't afford {productName}");
                            }
                        }
                    }
                }
            }

            foreach (var item in personsCollection)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public List<string> Products { get; set; }
        public Person(string name, int money)
        {
            this.Name = name;
            this.Money = money;
            this.Products = new List<string>();
        }

        public override string ToString()
        {
            if (this.Products.Count == 0)
            {
                return $"{this.Name} - Nothing bought";
            }                        

            return $"{this.Name} - {string.Join(", ", Products)}";
        }
    }

    class Product
    {
        public string Name { get; set; }
        public int Cost { get; set; }

        public Product(string name, int cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
    }
}
