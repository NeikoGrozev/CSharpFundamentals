using System;
using System.Collections.Generic;
using System.Linq;

namespace MixedUpLists
{
    class MixedUpLists
    {
        static void Main()
        {
            List<int> firstCollection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondCollection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> collection = new List<int>();
            int downRange = 0;
            int upRange = 0;

            if (firstCollection.Count > secondCollection.Count)
            {
                for (int i = 0; i < firstCollection.Count - 2; i++)
                {
                    collection.Add(firstCollection[i]);
                    collection.Add(secondCollection[secondCollection.Count - 1 - i]);
                }

                downRange = Math.Min(firstCollection[firstCollection.Count - 1], firstCollection[firstCollection.Count - 2]);
                upRange = Math.Max(firstCollection[firstCollection.Count - 1], firstCollection[firstCollection.Count - 2]);
            }
            else
            {
                for (int i = 0; i < secondCollection.Count - 2; i++)
                {
                    collection.Add(firstCollection[i]);
                    collection.Add(secondCollection[secondCollection.Count - 1 - i]);
                }

                downRange = Math.Min(secondCollection[0], secondCollection[1]);
                upRange = Math.Max(secondCollection[0], secondCollection[1]);
            }

            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i] <= downRange || collection[i] >= upRange)
                {
                    collection.RemoveAt(i);
                    i -= 1;
                }
            }

            collection.Sort();
            
            Console.WriteLine(string.Join(" ", collection));
        }
    }
}
