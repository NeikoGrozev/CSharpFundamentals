namespace _RepeatStrings
{
    using System;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main()
        {
            string[] str = Console.ReadLine()
                .Split(" ")
                .ToArray();

            var result = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str[i].Length; j++)
                {
                    result = result.Append(str[i]);
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}

