namespace Race
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string[] nameOfPlayer = Console.ReadLine()
                .Split(", ")
                .ToArray();

            string patternName = $"[A-Z]|[a-z]";
            Regex regexName = new Regex(patternName);

            string patternDigit = $"[0-9]";
            Regex regexDigit = new Regex(patternDigit);

            Dictionary<string, int> dict = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of race")
                {
                    break;
                }

                string name = string.Empty;
                int distance = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    Match match = regexName.Match(input[i].ToString());

                    if (match.Success)
                    {
                        name += match;
                    }
                }

                if (nameOfPlayer.Contains(name))
                {
                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, 0);
                    }
                }
                else
                {
                    continue;
                }

                for (int i = 0; i < input.Length; i++)
                {
                    Match match = regexDigit.Match(input[i].ToString());

                    if (match.Success)
                    {
                        distance += int.Parse(match.ToString());
                    }
                }

                dict[name] += distance;
            }

            int count = 0;

            foreach (var item in dict.OrderByDescending(x => x.Value))
            {
                count++;

                if (count == 1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                }
                else if (count == 2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                }
                else if (count == 3)
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                }
                else
                {
                    break;
                }
            }
        }
    }
}
