namespace ReverseStrings
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            var result = new StringBuilder();

            while (true)
            {
                string str = Console.ReadLine();
                var currentStr = string.Empty;

                if (str == "end")
                {
                    break;
                }

                for (int i = str.Length - 1; i >= 0; i--)
                {
                    currentStr += str[i];
                }

                result = result.AppendLine($"{str} = {currentStr}");

            }

            Console.WriteLine(result.ToString());
        }
    }
}
