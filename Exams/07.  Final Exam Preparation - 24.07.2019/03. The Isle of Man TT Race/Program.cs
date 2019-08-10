namespace TheIsleOfManTTRace
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string pattern = @"^([#$%*&])(?<name>[A-Za-z]+)\1=(?<length>[\d]+)!!(?<code>.*)$";
            Regex regex = new Regex(pattern);

            string name = string.Empty;
            StringBuilder cryptedCode = new StringBuilder();

            while (true)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);
                               
                if (match.Success)
                {
                    int length = int.Parse(match.Groups["length"].Value);
                    int lenghtCode = int.Parse(match.Groups["code"].Length.ToString());

                    if (length == lenghtCode)
                    {
                        name = match.Groups["name"].Value;
                        string code = match.Groups["code"].Value;

                        for (int i = 0; i < code.Length; i++)
                        {
                            cryptedCode.Append((char)(code[i] + length));
                        }

                        break;
                    }
                    else
                    {
                        PrintError();
                    }
                }
                else
                {
                    PrintError();
                }
            }

            Console.WriteLine($"Coordinates found! {name} -> {string.Join("", cryptedCode)}");
        }

        private static void PrintError()
        {
            Console.WriteLine("Nothing found!");
        }
    }
}
