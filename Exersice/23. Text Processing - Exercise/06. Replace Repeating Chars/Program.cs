namespace ReplaceRepeatingChars
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            StringBuilder str = new StringBuilder();

            str = str.Append(word[0]);

            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] != word[i + 1])
                {
                    str = str.Append(word[i + 1]);
                }
            }

            Console.WriteLine(string.Join("", str));
        }
    }
}
