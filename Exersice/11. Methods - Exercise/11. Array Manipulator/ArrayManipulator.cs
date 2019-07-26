using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main()
        {
            List<int> arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (command[0] == "end")
                {
                    Console.WriteLine($"[{string.Join(", ", arr)}]");
                    break;
                }

                switch (command[0])
                {
                    case "exchange":
                        int numberOfEnchenge = int.Parse(command[1]);
                        Exchange(arr, numberOfEnchenge);
                        break;
                    case "max":
                        string oddAndEvenMax = command[1];
                        Max(arr, oddAndEvenMax);
                        break;
                    case "min":
                        string oddAndEvenMin = command[1];
                        Min(arr, oddAndEvenMin);
                        break;
                    case "first":
                        int numberOfElementsFirst = int.Parse(command[1]);
                        string oddAndEvenFirst = command[2];
                        First(arr, numberOfElementsFirst, oddAndEvenFirst);
                        break;
                    case "last":
                        int numberOfElementsLast = int.Parse(command[1]);
                        string oddAndEvenLast = command[2];
                        Last(arr, numberOfElementsLast, oddAndEvenLast);
                        break;
                }
            }
        }

        private static void Exchange(List<int> arr, int numberOfEnchenge)
        {
            if (numberOfEnchenge < 0 || numberOfEnchenge > arr.Count - 1)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                List<int> temp = new List<int>();

                for (int i = 0; i <= numberOfEnchenge; i++)
                {
                    temp.Add(arr[i]);
                }
                arr.RemoveRange(0, numberOfEnchenge + 1);
                arr.AddRange(temp);
            }
        }

        private static void Max(List<int> arr, string oddAndEven)
        {
            int maxOddAndEvenIndex = -1;
            int maxOddAndEvenElement = int.MinValue;

            if (oddAndEven == "odd")
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i] % 2 != 0 && arr[i] >= maxOddAndEvenElement)
                    {
                        maxOddAndEvenIndex = i;
                        maxOddAndEvenElement = arr[i];
                    }
                }
            }
            else if (oddAndEven == "even")
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i] % 2 == 0 && arr[i] >= maxOddAndEvenElement)
                    {
                        maxOddAndEvenIndex = i;
                        maxOddAndEvenElement = arr[i];
                    }
                }
            }

            if (maxOddAndEvenIndex == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxOddAndEvenIndex);
            }
        }

        private static void Min(List<int> arr, string oddAndEvenMin)
        {
            int minOddAndEvenIndex = -1;
            int minOddAndEvenElement = int.MaxValue;

            if (oddAndEvenMin == "odd")
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i] % 2 != 0 && arr[i] <= minOddAndEvenElement)
                    {
                        minOddAndEvenIndex = i;
                        minOddAndEvenElement = arr[i];
                    }
                }
            }
            else if (oddAndEvenMin == "even")
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i] % 2 == 0 && arr[i] <= minOddAndEvenElement)
                    {
                        minOddAndEvenIndex = i;
                        minOddAndEvenElement = arr[i];
                    }
                }
            }

            if (minOddAndEvenIndex == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minOddAndEvenIndex);
            }
        }

        private static void First(List<int> arr, int numberOfElementsFirst, string oddAndEvenFirst)
        {
            if (IsValidCount(arr, numberOfElementsFirst))
            {
                int counter = 0;
                List<int> newColection = new List<int>();

                if (oddAndEvenFirst == "odd")
                {
                    for (int i = 0; i < arr.Count; i++)
                    {
                        if (arr[i] % 2 != 0)
                        {
                            newColection.Add(arr[i]);
                            counter++;

                            if (counter == numberOfElementsFirst)
                            {
                                break;
                            }

                        }
                    }
                }
                else if (oddAndEvenFirst == "even")
                {
                    for (int i = 0; i < arr.Count; i++)
                    {
                        if (arr[i] % 2 == 0)
                        {
                            newColection.Add(arr[i]);
                            counter++;

                            if (counter == numberOfElementsFirst)
                            {
                                break;
                            }

                        }
                    }
                }

                Console.WriteLine($"[{string.Join(", ", newColection)}]");
            }
        }

        private static void Last(List<int> arr, int numberOfElementsLast, string oddAndEvenLast)
        {
            if (IsValidCount(arr, numberOfElementsLast))
            {
                int counter = 0;
                List<int> newColection = new List<int>();

                if (oddAndEvenLast == "odd")
                {
                    for (int i = arr.Count - 1; i >= 0; i--)
                    {
                        if (arr[i] % 2 != 0)
                        {
                            newColection.Add(arr[i]);
                            counter++;

                            if (counter == numberOfElementsLast)
                            {
                                newColection.Reverse();
                                break;
                            }

                        }
                    }
                }
                else if (oddAndEvenLast == "even")
                {
                    for (int i = arr.Count - 1; i >= 0; i--)
                    {
                        if (arr[i] % 2 == 0)
                        {
                            newColection.Add(arr[i]);
                            counter++;

                            if (counter == numberOfElementsLast)
                            {
                                newColection.Reverse();
                                break;
                            }
                        }
                    }
                }

                Console.WriteLine($"[{string.Join(", ", newColection)}]");

            }

        }

        private static bool IsValidCount(List<int> arr, int count)
        {
            if (count > arr.Count || count < 0)
            {
                Console.WriteLine("Invalid count");
                return false; ;
            }

            return true;
        }
    }
}
