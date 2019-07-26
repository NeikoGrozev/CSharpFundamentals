namespace CaesarCipher
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();

            StringBuilder newStr = new StringBuilder();
            

            for (int i = 0; i < str.Length; i++)
            {
                newStr.Append((char)(str[i] + 3));
            }

            Console.WriteLine(string.Join("", newStr));
        }
    }
}
