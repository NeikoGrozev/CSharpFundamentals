using System;
using System.Collections.Generic;
using System.Linq;

namespace TakeAndSkipRope
{
    class TakeAndSkipRope
    {
        static void Main()
        {
            string cryptedWord = Console.ReadLine();

            List<int> number = new List<int>();
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < cryptedWord.Length; i++)
            {
                if (cryptedWord[i] >= '0' && cryptedWord[i] <= '9')
                {
                    number.Add(cryptedWord[i] - 48);
                    cryptedWord = cryptedWord.Remove(i, 1);
                    i -= 1;
                }
            }

            for (int i = 0; i < number.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(number[i]);
                }
                else
                {
                    skipList.Add(number[i]);
                }
            }

            int count = 0;
            char[] temp = new char[cryptedWord.Length];

            for (int i = 0; i < cryptedWord.Length; i++)
            {
                temp[i] = (char)cryptedWord[i];
            }

            List<char> word = temp.ToList();
            for (int i = 0; i < word.Count; i++)
            {
                if (takeList[count] > 0)
                {
                    
                    for (int j = 0; j < takeList[count]; j++)
                    {
                        if (j < word.Count)
                        {
                            Console.Write(word[j]);
                        }
                    }
                }

                if (takeList[count] > word.Count - 1)
                {
                    takeList[count] = word.Count;
                }

                word.RemoveRange(i, takeList[count]);

                if (skipList[count] > word.Count - 1)
                {
                    skipList[count] = word.Count;
                }

                word.RemoveRange(i, skipList[count]);

                i = -1;
                count++;

                if (count == takeList.Count)
                {
                    break;
                }
            }

            Console.WriteLine();
        }
    }
}
