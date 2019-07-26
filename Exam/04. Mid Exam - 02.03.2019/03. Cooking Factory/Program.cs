using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CookingFactory
{
    class Program
    {
        static void Main()
        {
            double sum = double.MinValue;
            double averageSum = double.MinValue;
            double currentSum = double.MinValue;
            double currentAverageSum = double.MinValue;
            double count = 0;
            List<int> currentNum = new List<int>();

            while (true)
            {
                List<string> collection = Console.ReadLine()
                    .Split("#")
                    .ToList();

                if (collection[0] == "Bake It!")
                {
                    break;
                }

                List<int> num = new List<int>();
                num = collection.Select(int.Parse).ToList();


                currentSum = num.Sum();
                currentAverageSum = currentSum / num.Count;

                if (currentSum > sum)
                {
                    currentNum.RemoveRange(0, currentNum.Count);
                    sum = currentSum;
                    averageSum = currentAverageSum;
                    count = num.Count;
                    currentNum.AddRange(num);
                }
                else if (currentSum == sum)
                {
                    if (averageSum < currentAverageSum)
                    {
                        currentNum.RemoveRange(0, currentNum.Count);
                        averageSum = currentAverageSum;
                        count = num.Count;
                        currentNum.AddRange(num);
                    }
                    else if (averageSum == currentAverageSum)
                    {
                        if (count > num.Count)
                        {
                            currentNum.RemoveRange(0, currentNum.Count);
                            count = num.Count;
                            currentNum.AddRange(num);
                        }
                    }
                }
            }

            Console.WriteLine($"Best Batch quality: {sum}");
            Console.WriteLine(string.Join(" ", currentNum));
        }
    }
}
