namespace StringManipulator
{
    using System;
    using System.Text;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            StringBuilder word = new StringBuilder();

            while (true)
            {
                string[] token = Console.ReadLine()
                    .Split(" ");

                string command = token[0];

                if (command == "End")
                {
                    break;
                }
                else if (command == "Add")
                {
                    string currentWord = token[1];
                    word.Append(currentWord);
                }
                else if (command == "Upgrade")
                {
                    char symbol = char.Parse(token[1]);
                    word.Replace(symbol, (char)(symbol + 1));
                }
                else if (command == "Print")
                {
                    Console.WriteLine(string.Join("", word));
                }
                else if (command == "Index")
                {
                    char symbol = char.Parse(token[1]);
                    bool isTrue = true;

                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == symbol)
                        {
                            Console.Write($"{i} ");
                            isTrue = false;
                        }
                    }
                    Console.WriteLine();

                    if (isTrue)
                    {
                        Console.WriteLine("None");
                    }
                }
                else if (command == "Remove")
                {
                    string currentStr = token[1];
                    word.Replace(currentStr, "");
                }
            }
        }
    }
}
