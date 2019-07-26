using System;
using System.Linq;

class TopIntegers
{
    static void Main()
    {
        int[] arr = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
                          
        for (int i = 0; i < arr.Length; i++)
        {
            bool isBigger = true;

            if (i < arr.Length - 1)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    isBigger = false;

                    if (arr[i] > arr[j])
                    {
                        isBigger = true;
                    }
                    else if(!isBigger)
                    {
                        break;
                    }
                }
            }

            if (isBigger)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}


