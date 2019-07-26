using System;

namespace NxNMatrix
{
    class NxNMatrix
    {
        static void Main()
        {
            int numberN = int.Parse(Console.ReadLine());

            PrintMatrix(numberN);
        }

        private static void PrintMatrix(int numberN)
        {
            for (int i = 0; i < numberN; i++)
            {
                for (int j = 0; j < numberN; j++)
                {
                    Console.Write(numberN + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
