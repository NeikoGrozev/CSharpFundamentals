namespace ActivationKeys
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class ActivationKeysProg
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split("&", StringSplitOptions.RemoveEmptyEntries);

            List<string> keys = new List<string>();

            foreach (var item in input)
            {
                StringBuilder key = new StringBuilder();
                bool isValidChar = true;
                bool isValidLength = false;

                if (item.Length == 16)
                {
                    isValidLength = true;

                    for (int i = 0; i < item.Length; i++)
                    {
                        if (!char.IsLetterOrDigit(item[i]))
                        {
                            isValidChar = false;
                            break;
                        }

                        if (i % 4 == 0 && i != 0)
                        {
                            key.Append('-');
                        }                       

                        key.Append(item[i].ToString().ToUpper());
                    }
                }
                else if (item.Length == 25)
                {
                    isValidLength = true;

                    for (int i = 0; i < item.Length; i++)
                    {
                        if (!char.IsLetterOrDigit(item[i]))
                        {
                            isValidChar = false;
                            break;
                        }

                        if (i % 5 == 0 && i != 0)
                        {
                            key.Append('-');
                        }

                        key.Append(item[i].ToString().ToUpper());
                    }                    
                }

                if (isValidChar && isValidLength)
                {
                    for (int i = 0; i < key.Length; i++)
                    {
                        if (char.IsDigit(key[i]))
                        {
                            int digit = int.Parse(key[i].ToString());
                            int currentDigit = 9 - digit;

                            key[i] = char.Parse(currentDigit.ToString());
                        }
                    }

                    keys.Add(key.ToString());
                }
            }

            Console.WriteLine(string.Join(", ", keys));
        }
    }
}
