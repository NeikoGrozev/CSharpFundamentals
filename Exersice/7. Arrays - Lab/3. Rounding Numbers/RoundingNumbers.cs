using System;
using System.Linq;

class RoundingNumbers
{
    static void Main()
    {
        string lineOfNumber = Console.ReadLine();

        double[] arr = lineOfNumber
            .Split()
            .Select(double.Parse)
            .ToArray();

        double[] newArray = new double[arr.Length];

        for (int i = 0; i <= arr.Length - 1; i++)
        {
            newArray[i] = arr[i];
            newArray[i] = (int)Math.Round(newArray[i], MidpointRounding.AwayFromZero) ;

            Console.WriteLine($"{arr[i]} => {newArray[i]}");
        }              
    }
}
