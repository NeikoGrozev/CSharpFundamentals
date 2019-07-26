namespace Substring
{
using System;
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine().ToLower();
            string input = Console.ReadLine().ToLower();

            while (true)
            {
                if (input.Contains(word))
                {
                    int index = input.IndexOf(word);
                    int count = word.Length;
                    input = input.Remove(index, count);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(input);
        }
    }
}
