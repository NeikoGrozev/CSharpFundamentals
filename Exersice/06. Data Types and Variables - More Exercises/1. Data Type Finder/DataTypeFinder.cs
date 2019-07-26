using System;
class DataTypeFinder
{
    static void Main()
    {
        string command = string.Empty;

        int isInt = 0;
        float isFloat = 0.0F;
        char isChar = '\0';
        bool isBool = false;
        string isString = string.Empty;

        while ((command = Console.ReadLine()) != "END")
        {
            if (int.TryParse(command, out isInt))
            {
                Console.WriteLine($"{command} is integer type");
            }
            else if (float.TryParse(command, out isFloat))
            {
                Console.WriteLine($"{command} is floating point type");
            }
            else if (char.TryParse(command, out isChar))
            {
                Console.WriteLine($"{command} is character type");
            }
            else if (bool.TryParse(command, out isBool))
            {
                Console.WriteLine($"{command} is boolean type");
            }
            else
            {
                Console.WriteLine($"{command} is string type");
            }
        }
    }
}
