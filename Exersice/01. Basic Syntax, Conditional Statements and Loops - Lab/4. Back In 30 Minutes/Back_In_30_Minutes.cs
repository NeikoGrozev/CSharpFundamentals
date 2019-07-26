using System;

class Back_In_30_Minutes
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine()) * 60;
        int minutes = int.Parse(Console.ReadLine());

        int totalMinutes = hours + minutes + 30;

        hours = totalMinutes / 60;
        minutes = totalMinutes % 60;

        if (hours >= 24)
        {
            hours -= 24;
        }

        if (minutes >= 10)
        {
            Console.WriteLine("{0}:{1}", hours, minutes);
        }
        else
        {
            Console.WriteLine("{0}:0{1}", hours, minutes);
        }
    }
}

