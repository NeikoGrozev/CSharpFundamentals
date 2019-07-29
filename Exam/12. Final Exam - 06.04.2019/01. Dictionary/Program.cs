namespace Dictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            List<string> words = Console.ReadLine()
                .Split("|")
                .Select(x => x.Trim())
                .ToList();

            List<string> keys = Console.ReadLine()
                .Split("|")
                .Select(x => x.Trim())
                .ToList();

            string command = Console.ReadLine();

            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            string pattern = $"(?<key>[A-Za-z]+): (?<value>.*)";
            Regex regex = new Regex(pattern);

            foreach (var word in words)
            {
                Match match = regex.Match(word);

                if (match.Success)
                {
                    string key = match.Groups["key"].Value;
                    string value = match.Groups["value"].Value;

                    if (!dict.ContainsKey(key))
                    {
                        dict.Add(key, new List<string>());
                    }

                    dict[key].Add(value);
                }
            }

            if (command == "List")
            {
                foreach (var item in dict.OrderBy(x => x.Key))
                {
                    Console.Write($"{item.Key} ");
                }
            }
            else if (command == "End")
            {
                foreach (var key in keys)
                {
                    if (dict.ContainsKey(key))
                    {
                        Console.WriteLine($"{key}");

                        foreach (var item in dict)
                        {
                            foreach (var word in item.Value.OrderByDescending(x => x.Length))
                            {
                                if (item.Key == key)
                                {
                                    Console.WriteLine($" -{word}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
