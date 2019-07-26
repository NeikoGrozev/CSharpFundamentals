using System;

class Login
{
    static void Main()
    {
        string username = Console.ReadLine();
        string password = string.Empty;

        for (int i = username.Length - 1; i >= 0; i--)
        {
            char reversUsername = username[i];
            password += reversUsername;
        }

        for (int i = 0; i < 3; i++)
        {
            string input = Console.ReadLine();

            if (password == input)
            {
                Console.WriteLine("User {0} logged in.", username);
                return;
            }
            else if (password != input)
            {
                Console.WriteLine("Incorrect password. Try again.");
            }
        }

        Console.WriteLine("User {0} blocked!", username);

    }
}

