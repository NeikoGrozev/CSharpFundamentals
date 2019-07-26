using System;

namespace CalculateRectangleArea
{
    class Program
    {
        static void Main()
        {
            double wigth = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            CalculateRectangleArea(wigth, height);
        }

        private static void CalculateRectangleArea(double wigth, double height)
        {
            double rectangleArea = wigth * height;

            Console.WriteLine(rectangleArea);
        }
    }
}
