namespace ExtractPersonInformation
{
    using System;

    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string str = Console.ReadLine();

                int startIndexName = str.IndexOf('@') + 1;
                int finishIndexName = str.IndexOf('|');

                string name = str.Substring(startIndexName, finishIndexName - startIndexName);

                int startIndexAge = str.IndexOf('#') + 1;
                int finishIndexAge = str.IndexOf('*');

                string age = str.Substring(startIndexAge, finishIndexAge - startIndexAge);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
