using System;

class Messages
{
    static void Main()
    {
        int numberOfSymbols = int.Parse(Console.ReadLine());

        string symbolsKeyTwo = "a, b, c";
        string symbolsKeyThree = "d, e, f";
        string symbolsKeyFour = "g, h, i";
        string symbolsKeyFive = "j, k, l";
        string symbolsKeySix = "m, n, o";
        string symbolsKeySeven = "p, q, r, s";
        string symbolsKeyEight = "t, u, v";
        string symbolsKeyNine = "w, x, y, z";

        string[] digitTwo = symbolsKeyTwo
        .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] digitThree = symbolsKeyThree
         .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] digitFour = symbolsKeyFour
         .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] digitFive = symbolsKeyFive
         .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] digitSix = symbolsKeySix
         .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] digitSeven = symbolsKeySeven
            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] digitEight = symbolsKeyEight
            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] digitNine = symbolsKeyNine
            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);


        for (int i = 1; i <= numberOfSymbols; i++)
        {
            string command = Console.ReadLine();
            char[] num = command.ToCharArray();

            int firstDigit = num[0] - 48;
            int lenght = num.Length;

            switch (firstDigit)
            {
                case 2:
                    Console.Write(digitTwo[lenght - 1]);
                    break;
                case 3:
                    Console.Write(digitThree[lenght - 1]);
                    break;
                case 4:
                    Console.Write(digitFour[lenght - 1]);
                    break;
                case 5:
                    Console.Write(digitFive[lenght - 1]);
                    break;
                case 6:
                    Console.Write(digitSix[lenght - 1]);
                    break;
                case 7:
                    Console.Write(digitSeven[lenght - 1]);
                    break;
                case 8:
                    Console.Write(digitEight[lenght - 1]);
                    break;
                case 9:
                    Console.Write(digitNine[lenght - 1]);
                    break;
                case 0:
                    Console.Write(" ");
                    break;
            }
        }
    }
}

