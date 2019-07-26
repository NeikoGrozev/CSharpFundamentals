using System;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            int[] number = new int[3];

            bool isNegative = false;

            int counterPositive = 0;
            int counterNegative = 0;

            for (int i = 0; i < 3; i++)
            {
                number[i] = int.Parse(Console.ReadLine());

                if (number[i] == 0)
                {
                    Console.WriteLine("zero");
                    return;
                }
                else if (number[i] < 0)
                {
                    counterNegative++;

                    if (counterNegative == 1 || counterNegative == 3)
                    {
                        isNegative = true;
                    }
                    else
                    {
                        isNegative = false;
                    }
                }
                else if (number[i] > 0)
                {
                    counterPositive++;

                    if (counterPositive == 3)
                    {
                        Console.WriteLine("positive");
                        return;
                    }
                }
            }

            if (isNegative)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
    }
}
