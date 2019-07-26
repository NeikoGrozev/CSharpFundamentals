using System;
class SpecialNumbers
{
    static void Main()
    {
        int finishNumber = int.Parse(Console.ReadLine());
        bool specialNumber = false;

        for (int i = 1; i <= finishNumber; i++)
        {
            int currentNum = i;
            int sum = 0;

            while (currentNum != 0)
            {
                int num = currentNum % 10;
                sum += num;
                currentNum /= 10;
            }

            if (sum == 5 || sum == 7 || sum == 11)
            {
                specialNumber = true;
            }
            else
            {
                specialNumber = false;
            }
            Console.WriteLine($"{i} -> {specialNumber}");
        }
    }
}

