using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    class ListManipulationAdvanced
    {
        static void Main()
        {
            List<int> colection = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            bool isChanges = false;

            while (true)
            {
                List<string> command = Console.ReadLine()
                    .Split()
                    .ToList();                              

                if (command[0] == "end")
                {
                    if (isChanges)
                    {
                        Console.WriteLine(string.Join(" ", colection));
                    }

                    break;
                }

                switch (command[0])
                {
                    case "Add":
                        colection.Add(int.Parse(command[1]));
                        isChanges = true;
                        break;
                    case "Remove":
                        colection.Remove(int.Parse(command[1]));
                        isChanges = true;
                        break;
                    case "RemoveAt":
                        colection.RemoveAt(int.Parse(command[1]));
                        isChanges = true;
                        break;
                    case "Insert":
                        colection.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        isChanges = true;
                        break;
                    case "Contains":
                        Contains(colection, command[1]);
                        break;
                    case "PrintEven":
                        PrintEven(colection);
                        break;
                    case "PrintOdd":
                        PrintOdd(colection);
                        break;
                    case "GetSum":
                        GetSum(colection);
                        break;
                    case "Filter":
                        Filter(colection, command[1], int.Parse(command[2]));
                        break;
                }
            }
        }

        private static void Contains(List<int> colection, string number)
        {
            if (colection.Contains(int.Parse(number)))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }

        private static void PrintEven(List<int> colection)
        {
            List<int> temp = new List<int>();

            temp = colection.Where(x => x % 2 == 0).ToList();

            Console.WriteLine(string.Join(" ", temp));

            //for (int i = 0; i < colection.Count; i++)
            //{
            //    if (colection[i] % 2 == 0)
            //    {
            //        Console.Write($"{colection[i]} ");
            //    }
            //}

            //Console.WriteLine();
        }

        private static void PrintOdd(List<int> colection)
        {
            List<int> temp = new List<int>();

            temp = colection.Where(x => x % 2 != 0).ToList();

            Console.WriteLine(string.Join(" ", temp));

            //for (int i = 0; i < colection.Count; i++)
            //{
            //    if (colection[i] % 2 != 0)
            //    {
            //        Console.Write($"{colection[i]} ");
            //    }
            //}

            //Console.WriteLine();
        }

        private static void GetSum(List<int> colection)
        {
            int sum = 0;

            for (int i = 0; i < colection.Count; i++)
            {
                sum += colection[i];
            }

            Console.WriteLine(sum);
        }

        private static void Filter(List<int> colection, string oper, int number)
        {
            List<int> temp = new List<int>();

            if (oper == "<")
            {
                temp = colection.Where(x => x < number).ToList();
            }
            else if (oper == ">")
            {
                temp = colection.Where(x => x > number).ToList();
            }
            else if (oper == "<=")
            {
                temp = colection.Where(x => x <= number).ToList();
            }
            else if (oper == ">=")
            {
                temp = colection.Where(x => x >= number).ToList();
            }
            //for (int i = 0; i < colection.Count; i++)
            //{
            //    if (oper == "<")
            //    {
            //        if (colection[i] < number)
            //        {
            //            temp.Add(colection[i]);
            //        }
            //    }
            //    else if (oper == ">")
            //    {
            //        if (colection[i] > number)
            //        {
            //            temp.Add(colection[i]);
            //        }
            //    }
            //    else if (oper == "<=")
            //    {
            //        if (colection[i] <= number)
            //        {
            //            temp.Add(colection[i]);
            //        }
            //    }
            //    else if (oper == ">=")
            //    {
            //        if (colection[i] >= number)
            //        {
            //            temp.Add(colection[i]);
            //        }
            //    }
            //}

            Console.WriteLine(string.Join(" ", temp));
        }
    }
}

