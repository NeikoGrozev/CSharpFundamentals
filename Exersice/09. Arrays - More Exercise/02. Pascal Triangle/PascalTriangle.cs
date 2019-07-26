using System;
class PascalTriangle
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int[] currentArray = new int[number];

        for (int row = 1; row <= number; row++)
        {
            int[] arr = new int[row];                   

            for (int col = 0; col < row; col++)
            {
                int startAndFinalNumber = 1;

                if (col == 0 || col == row - 1)
                {
                    arr[col] = startAndFinalNumber;
                }
                else
                {
                    arr[col] = currentArray[col] + currentArray[col - 1];
                }                
            }

            Console.Write(string.Join(" ", arr));
            Console.WriteLine();
            currentArray = arr;
        }
    }
}

