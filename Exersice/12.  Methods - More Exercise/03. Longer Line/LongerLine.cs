using System;

namespace LongerLine
{
    class LongerLine
    {
        static void Main()
        {
            double firstLineX1 = double.Parse(Console.ReadLine());
            double firstLineY1 = double.Parse(Console.ReadLine());
            double firstLineX2 = double.Parse(Console.ReadLine());
            double firstLineY2 = double.Parse(Console.ReadLine());

            double secondLineX1 = double.Parse(Console.ReadLine());
            double secondLineY1 = double.Parse(Console.ReadLine());
            double secondLineX2 = double.Parse(Console.ReadLine());
            double secondLineY2 = double.Parse(Console.ReadLine());

            double resultFirstLine = FindLongerLine(firstLineX1, firstLineY1, firstLineX1, firstLineY2);
            double resultSecondLine = FindLongerLine(secondLineX1, secondLineY1, secondLineX2, secondLineY2);

            if (resultFirstLine >= resultSecondLine)
            {
                double firstPoint = FindCenterPoint(firstLineX1, firstLineY1);
                double secondPoint = FindCenterPoint(firstLineX2, firstLineY2);

                if (firstPoint <= secondPoint)
                {
                    Console.WriteLine($"({firstLineX1}, {firstLineY1})({firstLineX2}, {firstLineY2})");
                }
                else
                {
                    Console.WriteLine($"({firstLineX2}, {firstLineY2})({firstLineX1}, {firstLineY1})");
                }
            }
            else
            {
                double firstPoint = FindCenterPoint(secondLineX1, secondLineY1);
                double secondPoint = FindCenterPoint(secondLineX2, secondLineY2);

                if (firstPoint <= secondPoint)
                {
                    Console.WriteLine($"({secondLineX1}, {secondLineY1})({secondLineX2}, {secondLineY2})");
                }
                else
                {
                    Console.WriteLine($"({secondLineX2}, {secondLineY2})({secondLineX1}, {secondLineY1})");
                }
            }
        }

        private static double FindLongerLine(double firstLineX1, double firstLineY1, double firstLineX2, double firstLineY2)
        {
            double result = Math.Sqrt(Math.Pow(firstLineX2 - firstLineX1, 2) + Math.Pow(firstLineY2 - firstLineY1, 2));

            return result;
        }

        private static double FindCenterPoint(double x, double y)
        {
            double result = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            return result;
        }
    }
}
