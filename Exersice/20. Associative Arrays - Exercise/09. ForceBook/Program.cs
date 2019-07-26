namespace ForceBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            SortedDictionary<string, List<string>> forceBook = new SortedDictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                string[] command = null;

                if (input == "Lumpawaroo")
                {
                    break;
                }

                if (input.Contains("|"))
                {
                    command = input
                    .Split(" | ")
                    .ToArray();

                    string forceSide = command[0];
                    string forceUser = command[1];
                    bool isTrue = true;

                    foreach (var item in forceBook)
                    {
                        if (item.Value.Contains(forceUser))
                        {
                            isTrue = false;
                        }
                    }

                    if (isTrue)
                    {
                        if (!forceBook.ContainsKey(forceSide))
                        {
                            forceBook.Add(forceSide, new List<string>());
                        }

                        if (!forceBook[forceSide].Contains(forceUser))
                        {
                            forceBook[forceSide].Add(forceUser);
                        }
                    }
                }
                else if (input.Contains("->"))
                {
                    command = input
                    .Split(" -> ")
                    .ToArray();

                    string forceUser = command[0];
                    string forceSide = command[1];

                    foreach (var item in forceBook)
                    {
                        if (item.Value.Contains(forceUser) && !item.Key.Contains(forceSide))
                        {
                            item.Value.Remove(forceUser);
                            break;
                        }
                    }

                    if (!forceBook.ContainsKey(forceSide))
                    {
                        forceBook.Add(forceSide, new List<string>());
                    }

                    forceBook[forceSide].Add(forceUser);

                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
            }

            foreach (var item in forceBook.Where(x => x.Value.Count > 0).OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");

                foreach (var user in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
