using System;
class TriplesOfLatinLetters
{
    static void Main()
    {
        int addNumber = int.Parse(Console.ReadLine());

        for (char i = 'a'; i < 'a' + addNumber ; i++)
        {
            for (char j = 'a'; j < 'a' + addNumber; j++)
            {
                for (char k = 'a'; k < 'a' + addNumber; k++)
                {
                    Console.WriteLine($"{i}{j}{k}");
                }
            }
        }
    }
}

