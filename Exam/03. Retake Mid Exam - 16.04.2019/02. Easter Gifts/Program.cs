using System;
using System.Diagnostics.Tracing;

namespace EasterGifts
{
    class Program
    {
        private const int V = 2;

        static void Main()
        {
            string[] gifts = Console.ReadLine()
                .Split();

            while (true)
            {
                string command = Console.ReadLine();


                if (command == "No Money")
                {
                    break;
                }

                string[] commands = command.Split();

                switch (commands[0])
                {
                    case "OutOfStock":
                        OutOfStock(gifts, commands[1]);
                        break;
                    case "Required":
                        Required(gifts, commands[1], int.Parse(commands[2]));
                        break;
                    case "JustInCase":
                        JustInCase(gifts, commands[1]);
                        break;
                }
            }

            for (int i = 0; i < gifts.Length; i++)
            {
                if (gifts[i] != "None")
                {
                    Console.Write($"{gifts[i]} ");
                }
            }
        }

        private static void OutOfStock(string[] gifts, string nameGift)
        {
            for (int i = 0; i < gifts.Length; i++)
            {
                if (gifts[i] == nameGift)
                {
                    gifts[i] = "None";
                }
            }
        }

        private static void Required(string[] gifts, string nameGift, int index)
        {
            if (index >= 0 && index <= gifts.Length - 1)
            {
                gifts[index] = nameGift;
            }
        }

        private static void JustInCase(string[] gifts, string nameGift)
        {
            gifts[gifts.Length - 1] = nameGift;
        }
    }
}
