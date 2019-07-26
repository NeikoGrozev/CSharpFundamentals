using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Train
    {
        static void Main()
        {
            List<int> colection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int limitNumber = int.Parse(Console.ReadLine());

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
                else if (command[0] == "Add")
                {
                    int num = int.Parse(command[1]);

                    colection.Add(num);
                }
                else
                {
                    int number = int.Parse(command[0]);

                    for (int i = 0; i < colection.Count; i++)
                    {
                        if (colection[i] + number <= limitNumber)
                        {
                            colection.Insert(i, colection[i] + number);
                            colection.RemoveAt(i + 1);
                            break;
                        }
                    }
                }
            }
        }
    }
}
