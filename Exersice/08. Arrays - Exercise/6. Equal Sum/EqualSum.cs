using System;
using System.Linq;

class EqualSum
{
    static void Main()
    {
        int[] lineOfNumbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int leftSum = 0;
        int rightSum = 0;

        for (int i = 0; i < lineOfNumbers.Length; i++)
        {
            leftSum = 0;
            rightSum = 0;

            for (int left = 0; left < i; left++)
            {
                leftSum += lineOfNumbers[left];
            }

            for (int right = i + 1; right < lineOfNumbers.Length; right++)
            {
                rightSum += lineOfNumbers[right];
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine(i);
                break;
            }
        }

        if (leftSum != rightSum)
        {
            Console.WriteLine("no");
        }
    }
}
