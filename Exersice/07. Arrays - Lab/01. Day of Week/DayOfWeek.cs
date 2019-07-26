using System;

class DayOfWeek
{
    static void Main()
    {
        string[] dayOfWeak = {
            "Invalid day!",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };

        int day = int.Parse(Console.ReadLine());

        if (day >= 1 && day <= 7)
        {
            Console.WriteLine(dayOfWeak[day]);
        }
        else
        {
            Console.WriteLine(dayOfWeak[0]);
        }
    }
}

