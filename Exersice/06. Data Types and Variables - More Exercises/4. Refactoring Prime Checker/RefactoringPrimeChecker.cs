using System;
class RefactoringPrimeChecker
{
    static void Main()
    {
        int lastNumber= int.Parse(Console.ReadLine());

        for (int i = 2; i <= lastNumber; i++)
        {
            bool isTrue = true;
           
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isTrue = false;
                    break;
                }                              
            }

            Console.WriteLine("{0} -> {1}", i, isTrue.ToString().ToLower());
        }
    }
}

