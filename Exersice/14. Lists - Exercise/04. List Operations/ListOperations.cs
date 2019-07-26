using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class ListOperations
    {
        static void Main()
        {
            List<int> colection = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] command = new string[3];


            while (true)
            {
                command = Console.ReadLine()
                    .Split()
                    .ToArray();


                if (command[0] == "End")
                {
                    Console.WriteLine(string.Join(" ", colection));
                    break;
                }

                switch (command[0])
                {
                    case "Add":
                        Add(colection, int.Parse(command[1]));
                        break;
                    case "Insert":
                        Insert(colection, int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    case "Remove":
                        Remove(colection, int.Parse(command[1]));
                        break;
                    case "Shift":
                        Shift(colection, command[1], int.Parse(command[2]));
                        break;
                }
            }
        }

        private static void Add(List<int> colection, int number)
        {
            colection.Add(number);
        }

        private static void Insert(List<int> colection, int index, int element)
        {
            if (index < 0 || index >= colection.Count)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                colection.Insert(index, element);
            }
        }

        private static void Remove(List<int> colection, int index)
        {
            if (index < 0 || index >= colection.Count)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                colection.RemoveAt(index);
            }
        }

        private static void Shift(List<int> colection, string destination, int counter)
        {
            if (counter > colection.Count)
            {
                counter = counter % colection.Count;
            }
            
            if (destination == "left")
            {
                for (int i = 0; i < counter; i++)
                {
                    int temp = colection[0];
                    colection.Add(temp);
                    colection.RemoveAt(0);
                }                
            }
            else if (destination == "right")
            {
                for (int i = 0; i < counter; i++)
                {
                    int temp = colection[colection.Count - 1];
                    colection.Insert(0, temp);
                    colection.RemoveAt(colection.Count - 1);
                }                
            }
        }
    }
}
