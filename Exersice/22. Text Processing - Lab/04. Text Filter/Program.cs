namespace TextFilter
{
    using System;

    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine()
                .Split(", ");

            string input = Console.ReadLine();


            foreach (var word in words)
            {
                if (input.Contains(word))
                {
                    int count = word.Length;

                    input = input.Replace(word, new string('*', count));
                }
            }

            Console.WriteLine(input);

        }
    }
}
