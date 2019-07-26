namespace WordSynonyms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int numberOfWords = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            for (int i = 0; i < numberOfWords; i++)
            {
                string wordKey = Console.ReadLine();
                string wordValue = Console.ReadLine();

                if (dict.ContainsKey(wordKey))
                {
                    dict[wordKey].Add(wordValue);
                }
                else
                {
                    dict.Add(wordKey, new List<string>());
                    dict[wordKey].Add(wordValue);
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
