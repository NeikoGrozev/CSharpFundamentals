using System;
using System.Collections.Generic;

namespace ListOfProducts
{
    class ListOfProducts
    {
        static void Main()
        {
            int numberOfProducts = int.Parse(Console.ReadLine());

            List<string> notes = new List<string>(numberOfProducts);

            for (int i = 0; i < numberOfProducts; i++)
            {
                notes.Add(Console.ReadLine());
            }

            notes.Sort();

            for (int i = 0; i < notes.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{notes[i]}");
            }
        }
    }
}
