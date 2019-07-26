using System;

namespace TopNumber
{
    class TopNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            FindTopNumber(number);
        }

        private static void FindTopNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                int digit = 0;
                int currentnumber = i;
                int sum = 0;
                bool oddDigit = false;

                while (currentnumber != 0)
                {
                    digit = currentnumber % 10;
                    currentnumber /= 10;
                    sum += digit;

                    if (digit % 2 != 0)
                    {
                        oddDigit = true;
                    }
                }

                if (sum % 8 == 0 && oddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
