using System;
class EncryptSortAndPrintArray
{
    static void Main() 
    {
        int rowsOfNames = int.Parse(Console.ReadLine());
        int[] arr = new int[rowsOfNames];

        for (int i = 0; i < rowsOfNames; i++)
        {
            string names = Console.ReadLine();
            int sum = 0;

            for (int j = 0; j < names.Length; j++)
            {
                switch (names[j])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        sum += names[j] * names.Length;
                        break;
                    default:
                        sum += names[j] / names.Length;
                        break;
                }
            }

            arr[i] = sum;
        }

        Array.Sort(arr);

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}

