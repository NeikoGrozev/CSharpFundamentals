namespace QuestsJournal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<string> collection = Console.ReadLine()
                .Split(", ")
                .ToList();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(new string[] {" - ", ":" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "Retire!")
                {
                    Console.WriteLine(string.Join(", ", collection));
                    break;
                }

                switch (command[0])
                {
                    case "Start":
                        Start(collection, command[1]);
                        break;
                    case "Complete":
                        Complete(collection, command[1]);
                        break;
                    case "Side Quest":
                        SideQuest(collection, command[1], command[2]);
                        break;
                    case "Renew":
                        Renew(collection, command[1]);
                        break;
                }
            }
        }        

        private static void Start(List<string> collection, string quest)
        {
            if (!collection.Contains(quest))
            {
                collection.Add(quest);
            }
        }

        private static void Complete(List<string> collection, string quest)
        {
            if (collection.Contains(quest))
            {
                int index = collection.IndexOf(quest);
                collection.RemoveAt(index);
            }
        }

        private static void SideQuest(List<string> collection, string quest, string addQuest)
        {
            if (collection.Contains(quest) && !collection.Contains(addQuest))
            {
                int index = collection.IndexOf(quest);
                collection.Insert(index + 1, addQuest);
            }
        }

        private static void Renew(List<string> collection, string quest)
        {
            if (collection.Contains(quest))
            {
                int index = collection.IndexOf(quest);
                string temp = collection[index];
                collection.RemoveAt(index);
                collection.Add(temp);
            }
        }
    }
}
