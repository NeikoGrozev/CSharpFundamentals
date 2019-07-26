using System;
using System.Linq;

class LadyBugs
{
    static void Main()
    {
        int lineOfNumbers = int.Parse(Console.ReadLine());

        int[] array = new int[lineOfNumbers];

        int[] arrInput = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int arrInputLength = arrInput.Length;
        string command = string.Empty;

        string[] arrCommand = new string[3];
        int index;
        string destination = string.Empty;
        int step;
        int currentIndex;

        for (int i = 0; i < arrInput.Length; i++)
        {
            if (arrInput[i] >= 0 && arrInput[i] <= array.Length - 1)
            {
                array[arrInput[i]] = 1;
            }
        }

        while ((command = Console.ReadLine()) != "end")
        {
            arrCommand = command
                .Split()
                .ToArray();
            index = int.Parse(arrCommand[0]);
            destination = arrCommand[1];
            step = int.Parse(arrCommand[2]);

            if (index < 0 || index > array.Length - 1 || step == 0 || array[index] == 0)
            {
                continue;
            }
            else if (array[index] == 1)
            {
                if (destination == "left")
                {
                    if (index - step < 0 || index - step > array.Length - 1)
                    {
                        array[index] = 0;
                    }
                    else if (index - step >= 0 && index - step <= array.Length - 1)
                    {
                        currentIndex = index - step;

                        if (array[currentIndex] == 0)
                        {
                            array[currentIndex] = 1;
                            array[index] = 0;
                        }
                        else if (array[currentIndex] == 1)
                        {
                            if (currentIndex > index)
                            {
                                for (int i = currentIndex; i <= array.Length - 1; i += step)
                                {
                                    currentIndex += step;

                                    if (array[i] == 0)
                                    {
                                        array[i] = 1;
                                        array[index] = 0;
                                        break;
                                    }
                                }

                                currentIndex += step;

                                if (currentIndex > array.Length - 1)
                                {
                                    array[index] = 0;
                                }
                            }
                            else if (currentIndex < index)
                            {
                                for (int i = currentIndex; i >= 0; i -= step)
                                {
                                    currentIndex -= step;
                                    if (array[i] == 0)
                                    {
                                        array[i] = 1;
                                        array[index] = 0;
                                        break;
                                    }
                                }

                                currentIndex -= step;

                                if (currentIndex < 0)
                                {
                                    array[index] = 0;
                                }
                            }
                        }
                    }
                }
                else if (destination == "right")
                {
                    if (index + step > array.Length - 1 || index + step < 0)
                    {
                        array[index] = 0;
                    }
                    else if (index + step >= 0 && index + step <= array.Length - 1)
                    {
                        currentIndex = index + step;

                        if (array[currentIndex] == 0)
                        {
                            array[currentIndex] = 1;
                            array[index] = 0;
                        }
                        else if (array[currentIndex] == 1)
                        {
                            if (currentIndex > index)
                            {
                                for (int i = currentIndex; i <= array.Length - 1; i += step)
                                {
                                    currentIndex += step;

                                    if (array[i] == 0)
                                    {
                                        array[i] = 1;
                                        array[index] = 0;
                                        break;
                                    }
                                }

                                currentIndex += step;

                                if (currentIndex > array.Length - 1)
                                {
                                    array[index] = 0;
                                }
                            }
                            else if (currentIndex < index)
                            {
                                for (int i = currentIndex; i >= 0; i -= step)
                                {
                                    currentIndex -= step;

                                    if (array[i] == 0)
                                    {
                                        array[i] = 1;
                                        array[index] = 0;
                                        break;
                                    }
                                }

                                currentIndex -= step;

                                if (currentIndex > 0)
                                {
                                    array[index] = 0;
                                }
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine(string.Join(" ", array));
    }
}

