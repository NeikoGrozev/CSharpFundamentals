using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class AppendArrays
    {
        static void Main()
        {
            List<string> collection = Console.ReadLine()
                .Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int counter = 0;

            for (int i = collection.Count - 1 ; i >= 0; i--)
            {                
                string temp = collection[collection.Count - 1];
                collection.Insert(counter,temp);
                collection.RemoveAt(collection.Count - 1);
                counter++;
            }

            List<string> reversCollection = new List<string>();

            foreach (string number in collection)
            {
                string[] tempResult = number.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                foreach (string space in tempResult)
                {
                    if (space != " ")
                    {
                        reversCollection.Add(space);
                    }
                }
            }           
           
            Console.WriteLine(string.Join(" ", reversCollection));
        }
    }
}
