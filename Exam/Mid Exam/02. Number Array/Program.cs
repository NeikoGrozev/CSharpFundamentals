namespace NumberArray
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] collection = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(" ")
                    .ToArray();

                if (command[0] == "End")
                {
                    break;
                }

                switch (command[0])
                {
                    case "Switch":
                        Switch(collection, int.Parse(command[1]));
                        break;
                    case "Change":
                        Change(collection, int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    case "Sum":
                        Sum(collection, command[1]);
                        break;
                }
            }

            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] >= 0)
                {
                    Console.Write($"{collection[i]} ");
                }
            }
        }

        private static void Switch(int[] collection, int index)
        {
            if (index >= 0 && index < collection.Length)
            {
                collection[index] *= -1;
            }
        }

        private static void Change(int[] collection, int index, int value)
        {
            if (index >= 0 && index < collection.Length)
            {
                collection[index] = value;
            }
        }

        private static void Sum(int[] collection, string positiveOrNegativeOrAll)
        {
            int sum = 0;

            if (positiveOrNegativeOrAll == "Negative")
            {
                for (int i = 0; i < collection.Length; i++)
                {
                    if (collection[i] < 0)
                    {
                        sum += collection[i];
                    }
                }
            }
            else if (positiveOrNegativeOrAll == "Positive")
            {
                for (int i = 0; i < collection.Length; i++)
                {
                    if (collection[i] > 0)
                    {
                        sum += collection[i];
                    }
                }
            }
            else if (positiveOrNegativeOrAll == "All")
            {
                for (int i = 0; i < collection.Length; i++)
                {
                    sum += collection[i];
                }
            }

            Console.WriteLine($"{sum}");
        }
    }
}
