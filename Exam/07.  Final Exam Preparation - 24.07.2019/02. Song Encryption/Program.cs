namespace SongEncryption
{
    using System;

    class Program
    {
        static void Main()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] arr = input
                    .Split(":");

                string artist = arr[0];
                string song = arr[1];

                bool isArtist = true;
                bool isSong = true;

                if (artist[0] >= 'A' && artist[0] <= 'Z')
                {
                    for (int i = 1; i < artist.Length; i++)
                    {
                        if (!(artist[i] >= 'a' && artist[i] <= 'z' || artist[i] == ' ' || artist[i] == '\''))
                        {
                            isArtist = false;
                            break;
                        }
                    }
                }
                else
                {
                    isArtist = false;
                }

                for (int i = 0; i < song.Length; i++)
                {
                    if (!(song[i] >= 'A' && song[i] <= 'Z' || song[i] == ' '))
                    {
                        isSong = false;
                        break;
                    }
                }

                if (isArtist && isSong)
                {
                    string decrypted = string.Empty;
                    int key = artist.Length;

                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == ' ')
                        {
                            decrypted += ' ';
                        }
                        else if (input[i] == '\'')
                        {
                            decrypted += '\'';
                        }
                        else if (input[i] >= 'A' && input[i] <= 'Z')
                        {
                            if ((char)(input[i] + key) > 'Z')
                            {
                                int temp = key - ('Z' - input[i]);
                                decrypted += (char)(64 + temp);
                            }
                            else
                            {
                                decrypted += (char)(input[i] + key);
                            }
                        }
                        else if (input[i] >= 'a' && input[i] <= 'z')
                        {
                            if ((char)(input[i] + key) > 'z')
                            {
                                int temp = key - ('z' - input[i]);
                                decrypted += (char)(96 + temp);
                            }
                            else
                            {
                                decrypted += (char)(input[i] + key);
                            }
                        }
                        else if(input[i] == ':')
                        {
                            decrypted += '@';
                        }
                        
                    }

                    Console.WriteLine($"Successful encryption: {decrypted}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
