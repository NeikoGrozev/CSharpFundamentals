using System;
using System.Linq;

class FromLeftToTheRight
{
    static void Main()
    {
        int lineOfNumber = int.Parse(Console.ReadLine());

        for (int i = 1; i <= lineOfNumber; i++)
        {
            string num = Console.ReadLine();

            long[] number = num.Split()
                .Select(long.Parse)
                .ToArray();

            long leftNumber = number[0];
            long rightNumber = number[1];

            if (leftNumber.CompareTo(rightNumber) == 1)
            {
                long sum = 0;
                while (leftNumber != 0)
                {
                    long currentLeftNumber = leftNumber % 10;
                    leftNumber /= 10;
                    sum += currentLeftNumber;
                }

                Console.WriteLine(Math.Abs(sum));

            }
            else if (leftNumber.CompareTo(rightNumber) == -1 ||
                leftNumber.CompareTo(rightNumber) == 0)
            {
                long sum = 0;
                while (rightNumber != 0)
                {
                    long currentRightNumber = rightNumber % 10;
                    rightNumber /= 10;
                    sum += currentRightNumber;
                }

                Console.WriteLine(Math.Abs(sum));
            }

        }
    }
}

