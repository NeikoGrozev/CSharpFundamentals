using System;
using System.Linq;

class MaxSequenceOfEqualElements
{
    static void Main()
    {
        int[] lineOfNumbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int counter = 1;
        int maxCounter = 0;
        int number = 0;

        for (int i = 1; i < lineOfNumbers.Length; i++)
        {
            if (lineOfNumbers[i] == lineOfNumbers[i - 1])
            {
                counter++;

                if (counter > maxCounter)
                {
                    number = lineOfNumbers[i];
                    maxCounter = counter;
                }
            }
            else
            {
                counter = 1;
            }
        }

        int[] newArray = new int[maxCounter];
        
        for (int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = number;           
        }

        Console.WriteLine(string.Join(" ", newArray));
    }
}

