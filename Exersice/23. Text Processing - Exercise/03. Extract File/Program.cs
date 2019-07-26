namespace ExtractFile
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] directory = Console.ReadLine()
                .Split("\\")
                .ToArray();

            int finishIndex = directory.Length;

            string[] programName = directory[finishIndex - 1]
                .Split(".")
                .ToArray();

            Console.WriteLine($"File name: {programName[0]}");
            Console.WriteLine($"File extension: {programName[1]}");
        }
    }
}
