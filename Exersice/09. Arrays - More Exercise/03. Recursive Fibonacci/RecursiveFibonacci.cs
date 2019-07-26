using System;
class RecursiveFibonacci
{
    static void Main()

    {
        int positionNumberOfFibonacci = int.Parse(Console.ReadLine());
        int digitOfFibonacci = 0;
        int currentdigitOfFibonacci = 1;

        for (int i = 1; i <= positionNumberOfFibonacci; i++)
        {
            digitOfFibonacci += currentdigitOfFibonacci;
            currentdigitOfFibonacci = digitOfFibonacci - currentdigitOfFibonacci;
        }
        
        Console.WriteLine(digitOfFibonacci);
    }
}

