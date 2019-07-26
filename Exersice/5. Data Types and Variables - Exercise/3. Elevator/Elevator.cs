using System;
class Elevator
{
    static void Main()
    {
        double persons = int.Parse(Console.ReadLine());
        int capacity = int.Parse(Console.ReadLine());

        double courses = Math.Ceiling(persons / capacity);

        Console.WriteLine(courses);
    }
}

