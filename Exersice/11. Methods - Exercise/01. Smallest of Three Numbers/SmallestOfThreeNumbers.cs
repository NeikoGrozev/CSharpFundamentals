using System;

namespace SmallestOfThreeNumbers
{
    class SmallestOfThreeNumbers
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            FindSmallestNumber(firstNumber, secondNumber, thirdNumber);
        }

        private static void FindSmallestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) < 0)
            {
                if (firstNumber.CompareTo(thirdNumber) < 0)
                {
                    Console.WriteLine(firstNumber);
                }
                else
                {
                    Console.WriteLine(thirdNumber);
                }
            }
            else
            {
                if (secondNumber.CompareTo(thirdNumber) < 0)
                {
                    Console.WriteLine(secondNumber);
                }
                else
                {
                    Console.WriteLine(thirdNumber);
                }
            }
        }
    }
}
