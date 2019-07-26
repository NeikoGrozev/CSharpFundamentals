using System;

class Student_Information
{
    static void Main()
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        double averageGrade = double.Parse(Console.ReadLine());

        Console.WriteLine("Name: {0}, Age: {1}, Grade: {2:F2}", name, age, averageGrade);
    }
}

