using System;
using System.Collections.Generic;
using System.Linq;


namespace PokemonDoNotGo
{
    class PokemonDoNotGo
    {
        static void Main()
        {
            List<int> pokemonCollection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();
            int sum = 0;

            while (true)
            {
                int command = int.Parse(Console.ReadLine());

                if (command < 0)
                {
                    result.Add(DownOutOfRange(pokemonCollection));
                }
                else if (command > pokemonCollection.Count - 1)
                {
                    result.Add(UpOutOfRange(pokemonCollection));
                }
                else
                {
                    result.Add(InRange(pokemonCollection, command));
                }


                if (pokemonCollection.Count == 0)
                {
                    for (int i = 0; i < result.Count; i++)
                    {
                        sum += result[i];
                    }

                    break;
                }
            }

            Console.WriteLine(sum);
        }

        private static int DownOutOfRange(List<int> pokemonCollection)
        {
            int temp = pokemonCollection[0];
            pokemonCollection[0] = pokemonCollection[pokemonCollection.Count - 1];

            ConvertList(pokemonCollection, temp);
            return temp;
        }

        private static int UpOutOfRange(List<int> pokemonCollection)
        {
            int temp = pokemonCollection[pokemonCollection.Count - 1];
            pokemonCollection[pokemonCollection.Count - 1] = pokemonCollection[0];

            ConvertList(pokemonCollection, temp);
            return temp;
        }

        private static int InRange(List<int> pokemonCollection, int index)
        {
            int temp = pokemonCollection[index];
            pokemonCollection.RemoveAt(index);

            ConvertList(pokemonCollection, temp);
            return temp;
        }

        private static void ConvertList(List<int> pokemonCollection, int temp)
        {
            for (int i = 0; i < pokemonCollection.Count; i++)
            {
                if (pokemonCollection[i] <= temp)
                {
                    pokemonCollection[i] += temp;
                }
                else
                {
                    pokemonCollection[i] -= temp;
                }
            }
        }
    }
}
