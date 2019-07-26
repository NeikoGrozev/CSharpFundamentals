using System;
using System.Linq;

class KaminoFactory
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        string command = string.Empty;
        int[] arr = new int[number];

        int length = 0;
        int bestLength = 0;

        int startIndex;
        int bestIndex = -1;

        int sum;
        int bestSum = 0;

        int line = 0;
        int bestLine = 0;

        int[] currentArray = new int[number];

        while ((command = Console.ReadLine()) != "Clone them!")
        {
            arr = command
                .Split('!', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            startIndex = -1;
            length = 0;
            sum = 0;
            line++;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    sum++;

                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    length++;

                    if (length == 1)
                    {
                        startIndex = i;
                    }
                }
                else if (arr[i] == 0)
                {
                    length = 0;
                }

                if (length > bestLength)
                {
                    bestLength = length;
                    bestIndex = startIndex;
                    bestSum = sum;
                    bestLine = line;
                    currentArray = arr;
                }

                if (length == bestLength)
                {
                    if (startIndex < bestIndex)
                    {
                        bestLength = length;
                        bestIndex = startIndex;
                        bestSum = sum;
                        bestLine = line;
                        currentArray = arr;
                    }
                    else if (startIndex == bestIndex)
                    {
                        if (sum > bestSum)
                        {
                            bestLength = length;
                            bestSum = sum;
                            bestLine = line;
                            currentArray = arr;
                        }
                    }
                }
            }
        }

        if (bestLength == 0)
        {
            bestLine = 1;
            Console.WriteLine($"Best DNA sample {bestLine} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", arr));
        }
        else
        {
            Console.WriteLine($"Best DNA sample {bestLine} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", currentArray));
        }
    }
}

