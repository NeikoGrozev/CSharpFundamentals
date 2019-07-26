using System;
using System.Collections.Generic;
using System.Linq;


namespace LastStop
{
    class LastStop
    {
        static void Main()
        {
            List<int> collection = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (command[0] == "END")
                {
                    Console.WriteLine(string.Join(" ", collection));
                    break;
                }

                switch (command[0])
                {
                    case "Change":
                        Change(collection, int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    case "Hide":
                        Hide(collection, int.Parse(command[1]));
                        break;
                    case "Switch":
                        Switch(collection, int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    case "Insert":
                        Insert(collection, int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    case "Reverse":
                        Reverse(collection);
                        break;
                }
            }
        }

        private static void Change(List<int> collection, int paintingNumber, int changedNumber)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (paintingNumber == collection[i])
                {
                    collection[i] = changedNumber;
                    break;
                }
            }
        }

        private static void Hide(List<int> collection, int paintingNumber)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (paintingNumber == collection[i])
                {
                    collection.RemoveAt(i);
                }
            }
        }

        private static void Switch(List<int> collection, int paintingNumber, int paintingNumber2)
        {
            bool firstNumber = collection.Contains(paintingNumber);
            bool seconfNumber = collection.Contains(paintingNumber2);

            if (firstNumber && seconfNumber)
            {
                int firstIndex = collection.IndexOf(paintingNumber);
                int secondIndex = collection.IndexOf(paintingNumber2);

                int temp = collection[firstIndex];
                collection[firstIndex] = collection[secondIndex];
                collection[secondIndex] = temp;
            }


        }

        private static void Insert(List<int> collection, int place, int paintingNumber)
        {
            if (place <= collection.Count - 1)
            {
                collection.Insert(place + 1, paintingNumber);
            }
        }

        private static void Reverse(List<int> collection)
        {
            collection.Reverse();
        }
    }
}
