using System;
class PokeMon
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int numberM = int.Parse(Console.ReadLine());
        int numberY = int.Parse(Console.ReadLine());

        int counter = 0;
        double numberNHalf = numberN / 2.0;

        while (numberN >= numberM)
        {
            counter++;
            numberN -= numberM;
            
            if (numberN == numberNHalf && numberY > 0)
            {
                numberN /= numberY;
            }
        }

        Console.WriteLine(numberN);
        Console.WriteLine(counter);
    }
}

