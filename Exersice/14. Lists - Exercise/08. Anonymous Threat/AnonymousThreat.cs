using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class AnonymousThreat
    {
        static void Main()
        {
            List<string> collection = Console.ReadLine()
                .Split()
                .ToList();
                        
            while (true)
            {
                string[] command = Console.ReadLine()
                .Split();

                if (command[0] == "3:1")
                {
                    Console.WriteLine(string.Join(" ", collection));
                    break;
                }
                else if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    Merge(collection, startIndex, endIndex);
                }
                else if (command[0] == "divide")
                {
                    int index = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);

                    Divide(collection, index, partitions);
                }
            }
        }

        private static void Merge(List<string> collection, int startIndex, int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            else if (startIndex > collection.Count - 1)
            {
                startIndex = collection.Count - 1;
            }

            if (endIndex < 0)
            {
                endIndex = 0;
            }
            else if (endIndex > collection.Count - 1)
            {
                endIndex = collection.Count - 1;
            }

            string temp = string.Empty;

            for (int i = startIndex; i <= endIndex; i++)
            {
                temp += collection[i];
            }

            collection.RemoveRange(startIndex, endIndex - startIndex + 1);
            collection.Insert(startIndex, temp);                        
        }

        private static void Divide(List<string> collection, int index, int partitions)
        {
            List<string> newCollection = new List<string>();            
            string temp = collection[index];
            collection.RemoveAt(index);
            int parts = temp.Length / partitions;
            for (int i = 0; i < partitions; i++)
            {
                if (i == partitions - 1)
                {
                    newCollection.Add(temp.Substring(i * parts));
                }
                else
                {
                    newCollection.Add(temp.Substring(i * parts, parts));
                }                
            }
            collection.InsertRange(index, newCollection);
        }          
    }
}
