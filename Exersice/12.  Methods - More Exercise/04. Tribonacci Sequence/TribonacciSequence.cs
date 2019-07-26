using System;

namespace TribonacciSequence
{
    class TribonacciSequence
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine(0);
            }
            else if (num == 1)
            {
                Console.WriteLine(1);
            }
            else if (num == 2)
            {
                Console.WriteLine(1 + " " + 1);
            }
            else if (num == 3)
            {
                Console.WriteLine(1 + " " + 1 + " " + 2);
            }
            else
            {
                Console.Write(1 + " " + 1 + " " + 2);
                
                int numberOfTribonacciOne = 1;
                int numberOfTribonacciTwo = 1;
                int numberOfTribonacciThree = 2;
                int numberOfTribonacci = 0;


                for (int i = 0; i < num - 3; i++)
                {
                    numberOfTribonacci = numberOfTribonacciOne + numberOfTribonacciTwo + numberOfTribonacciThree;
                    numberOfTribonacciOne = numberOfTribonacciTwo;
                    numberOfTribonacciTwo = numberOfTribonacciThree;
                    numberOfTribonacciThree = numberOfTribonacci;

                    Console.Write(" " + numberOfTribonacci);
                }
            }
        }
    }
}
