using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvertisementMessage
{
    class AdvertisementMessage
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            string[] phrases = new string[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            string[] events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            string[] autors = new string[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            string[] cities = new string[]
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            Random randomOne = new Random();
            Random randomTwo = new Random();
            Random randomThrid = new Random();
            Random randomFourt = new Random();

            for (int i = 0; i < num; i++)
            {
                int indexOne = randomOne.Next(0, phrases.Length);
                int indexTwo = randomTwo.Next(0, events.Length);
                int indexThurd = randomThrid.Next(0, autors.Length);
                int indexFourt = randomFourt.Next(0, cities.Length);

                Console.WriteLine($"{phrases[indexOne]} {events[indexTwo]} {autors[indexThurd]} - {cities[indexFourt]}");
            }
        }
    }
}
