using System;
using System.Collections.Generic;
using System.Linq;

namespace Messaging
{
    class Messaging
    {
        static void Main()
        {
            List<int> collectionOfNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string collection = Console.ReadLine();

            for (int i = 0; i < collectionOfNumbers.Count; i++)
            {
                int sum = 0;

                while (collectionOfNumbers[i] != 0)
                {
                    int temp = collectionOfNumbers[i] % 10;
                    collectionOfNumbers[i] /= 10;

                    sum += temp;
                }

                int count = sum % collection.Length;

                Console.Write(collection[count]);
                collection = collection.Remove(count, 1);
            }            
        }
    }
}
