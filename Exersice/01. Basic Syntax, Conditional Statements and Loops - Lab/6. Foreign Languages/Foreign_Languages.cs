using System;

class Foreign_Languages
{
    static void Main()
    {
        string country = Console.ReadLine();

        switch (country)
        {
            case "England":
            case "USA":
                Console.WriteLine("English");
                break;
            case "Spain":               
            case "Mexico":
            case "Argentina":
                Console.WriteLine("Spanish");
                break;
            default:
                Console.WriteLine("unknown");
                break;
        }
    }
}

