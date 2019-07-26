using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class MergingLists
    {
        static void Main()
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();
            int count = 0;

            if (firstList.Count >= secondList.Count)
            {
                count = firstList.Count;
            }
            else
            {
                count = secondList.Count;
            }

            for (int i = 0; i < count; i++)
            {
                if (firstList.Count > i)
                {
                    result.Add(firstList[i]);
                }

                if (secondList.Count > i)
                {
                    result.Add(secondList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
