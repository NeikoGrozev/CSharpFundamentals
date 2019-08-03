namespace StringManipulator
{
    using System;
    using System.Text;

    class StringManipulatorProg
    {
        static void Main()
        {
            string str = Console.ReadLine();
            StringBuilder builder = new StringBuilder(str);

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] token = command
                    .Split(" ");

                if (token[0] == "Translate")
                {
                    char oldSymbol = char.Parse(token[1]);
                    char newSymbol = char.Parse(token[2]);

                    builder.Replace(oldSymbol, newSymbol);

                    Console.WriteLine(string.Join("", builder));
                }
                else if (token[0] == "Includes")
                {
                    string findString = token[1];

                    if (builder.ToString().Contains(findString))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (token[0] == "Start")
                {
                    string word = token[1];
                    int wordLength = word.Length;
                    bool isValid = true;

                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == builder[i])
                        {
                            continue;
                        }
                        else
                        {
                            isValid = false;
                        }
                    }

                    if (isValid)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (token[0] == "Lowercase")
                {
                    string newbuilder = builder.ToString().ToLower();
                    builder.Remove(0, builder.Length);
                    builder.Append(newbuilder);

                    Console.WriteLine(string.Join("", builder));
                }
                else if (token[0] == "FindIndex")
                {
                    char symbol = char.Parse(token[1]);
                    int findIndex = -1;

                    for (int i = builder.Length - 1; i >= 0; i--)
                    {
                        if (symbol == builder[i])
                        {
                            findIndex = i;
                            break;
                        }
                    }

                    Console.WriteLine(findIndex);
                }
                else if (token[0] == "Remove")
                {
                    int startIndex = int.Parse(token[1]);
                    int counter = int.Parse(token[2]);

                    string removeWord = builder.Remove(startIndex, counter).ToString();

                    Console.WriteLine(removeWord);
                }
            }
        }
    }
}
