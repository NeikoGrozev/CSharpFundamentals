namespace WinningTicket
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(", ")
                .Select(x => x.Trim())
                .ToArray();

            string jackpotPattern = @"[@]{10}|[#]{10}|[\$]{10}|[\^]{10}";
            Regex regexJackpot = new Regex(jackpotPattern);

            string winPattern = @"[@]{6,9}|[#]{6,9}|[$]{6,9}|[\^]{6,9}";
            Regex regexWin = new Regex(winPattern);

            for (int i = 0; i < input.Length; i++)
            {
                string ticket = input[i];

                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else if (ticket.Length == 20)
                {
                    string tiketsLeftHalf = ticket.Substring(0, 10);
                    string tiketsRightHalf = ticket.Substring(10, 10);

                    Match leftMatchJackpot = regexJackpot.Match(tiketsLeftHalf);
                    Match rightMatchJackpot = regexJackpot.Match(tiketsRightHalf);

                    string leftMatchJackpotStr = leftMatchJackpot.Value.ToString();
                    string rightMatchJacpotStr = rightMatchJackpot.Value.ToString();

                    Match leftMatchWin = regexWin.Match(tiketsLeftHalf);
                    Match rightMatchWin = regexWin.Match(tiketsRightHalf);

                    string leftMatchWinStr = leftMatchWin.Value.ToString();
                    string rightMatchWinStr = rightMatchWin.Value.ToString();

                    if (leftMatchJackpot.Success && rightMatchJackpot.Success)
                    {
                        if (leftMatchJackpotStr.Equals(rightMatchJacpotStr))
                        {
                            char symbol = leftMatchJackpotStr[0];
                            Console.WriteLine($"ticket \"{ticket}\" - 10{symbol} Jackpot!");
                        }
                    }
                    else if (leftMatchWin.Success && rightMatchWin.Success)
                    {
                        if (leftMatchWinStr[0] == rightMatchWinStr[0])
                        {
                            int minLength = Math.Min(leftMatchWinStr.Length, rightMatchWinStr.Length);
                            char symbol = leftMatchWinStr[0];

                            Console.WriteLine($"ticket \"{ticket}\" - {minLength}{symbol}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
            }
        }
    }
}
