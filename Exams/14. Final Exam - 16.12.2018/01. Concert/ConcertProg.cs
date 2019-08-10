namespace Concert
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ConcertProg
    {
        static void Main()
        {
            Dictionary<string, int> bandTimes = new Dictionary<string, int>();
            Dictionary<string, List<string>> bandMembersNames = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "start of concert")
                {
                    break;
                }

                List<string> collection = input
                    .Split(new string[] { "; ", ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string bandName = String.Empty;

                if (collection[0] == "Add")
                {
                    bandName = collection[1];

                    if (!bandMembersNames.ContainsKey(bandName))
                    {
                        bandMembersNames.Add(bandName, new List<string>());
                    }

                    for (int i = 2; i < collection.Count; i++)
                    {
                        string memberName = collection[i];
                        bool isTrue = true;

                        foreach (var member in bandMembersNames[bandName])
                        {
                            if (member == memberName)
                            {
                                isTrue = false;
                            }
                        }

                        if (isTrue)
                        {
                            bandMembersNames[bandName].Add(memberName);
                        }
                    }
                }
                else if (collection[0] == "Play")
                {
                    bandName = collection[1];
                    int time = int.Parse(collection[2]);

                    if (!bandTimes.ContainsKey(bandName))
                    {
                        bandTimes.Add(bandName, time);
                    }
                    else
                    {
                        bandTimes[bandName] += time;
                    }
                }
            }

            string listOfMembersOfBand = Console.ReadLine();

            Console.WriteLine($"Total time: {bandTimes.Values.Sum()}");

            foreach (var band in bandTimes.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }

            Console.WriteLine($"{listOfMembersOfBand}");

            foreach (var name in bandMembersNames[listOfMembersOfBand])
            {
                Console.WriteLine($"=> {name}");
            }
        }
    }
}
