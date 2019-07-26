using System;

class BalancedBrackets
{
    static void Main()
    {
        int numberOfLine = int.Parse(Console.ReadLine());
        int counterLeft = 0;
        int counterRight = 0;
        int countLeft = 0;
        int countRight = 0;

        for (int i = 1; i <= numberOfLine; i++)
        {
            string command = Console.ReadLine();

            if (command == "(")
            {
                counterLeft++;
                countLeft++;
                countRight = 0;

                if (countLeft == 2)
                {
                    break;
                }
            }
            else if (command == ")")
            {
                counterRight++;
                countRight++;
                countLeft = 0;

                if (countRight == 2)
                {
                    break;
                }
            }

            if (countLeft == 2)
            {
                break;
            }
            else if (countRight == 2)
            {
                break;
            }
        }

        if (counterLeft == counterRight)
        {
            Console.WriteLine("BALANCED");
        }
        else
        {
            Console.WriteLine("UNBALANCED");
        }
    }
}

