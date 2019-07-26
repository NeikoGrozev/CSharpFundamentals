namespace CountCharsInAString
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            string collection = Console.ReadLine();

            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < collection.Length; i++)
            {
                if (dict.ContainsKey(collection[i]))
                {
                    dict[collection[i]]++;
                }
                else if (collection[i] == ' ')
                {
                    continue;
                }
                else
                {
                    dict.Add(collection[i], 1);
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
