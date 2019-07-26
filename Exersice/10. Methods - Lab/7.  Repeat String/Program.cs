using System;

namespace RepeatString
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());

            RepeatString(str, repeat);
        }

        private static void RepeatString(string str, int repeat)
        {
            for (int i = 1; i <= repeat; i++)
            {
                Console.Write(str);
            }
        }
    }
}
