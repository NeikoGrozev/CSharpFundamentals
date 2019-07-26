using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class ChangeList
    {
        static void Main()
        {
            List<int> colection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                List<string> command = Console.ReadLine()
                    .Split()
                    .ToList();

                if (command[0] == "end")
                {
                    Console.WriteLine(string.Join(" ", colection));
                    break;
                }

                switch (command[0])
                {
                    case "Insert":
                        Insert(colection, int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    case "Delete":
                        Delete(colection, int.Parse(command[1]));
                        break;
                }
            }
        }
        
        private static void Insert(List<int> colection, int index, int element)
        {
            colection.Insert(index, element);
        }

        private static void Delete(List<int> colection, int element)
        {
            for (int i = 0; i < colection.Count; i++)
            {
                if (colection[i] == element)
                {
                    colection.RemoveAt(i);
                }
            }
        }
    }
}
