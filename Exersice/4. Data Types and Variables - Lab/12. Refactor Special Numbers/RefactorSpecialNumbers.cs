using System;
class RefactorSpecialNumbers
{
    static void Main()
    {
        int finishNumber = int.Parse(Console.ReadLine());
        int sum = 0;
        int currentNum = 0;
        bool isTrue = false;
        for (int i = 1; i <= finishNumber; i++)
        {
            currentNum = i;
            while (i > 0)
            {
                sum += i % 10;
                i = i / 10;
            }

            if ((sum == 5) || (sum == 7) || (sum == 11))
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }

            Console.WriteLine("{0} -> {1}", currentNum, isTrue);
            sum = 0;
            i = currentNum;
        }
    }
}

