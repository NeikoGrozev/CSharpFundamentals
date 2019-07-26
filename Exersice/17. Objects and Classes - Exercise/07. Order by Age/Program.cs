using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main()
        {
            List<Person> persons = new List<Person>();
            while (true)
            {
                string[] people = Console.ReadLine()
                    .Split();

                if (people[0] == "End")
                {
                    break;
                }

                string name = people[0];
                string ID = people[1];
                int age = int.Parse(people[2]);

                Person person = new Person(name, ID, age);

                persons.Add(person);
            }

            persons = persons.OrderBy(x => x.Age).ToList();

            foreach (Person person in persons)
            {
                Console.WriteLine(person);
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public Person(string name, string ID, int age)
        {
            this.Name = name;
            this.ID = ID;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.ID} is {this.Age} years old.";
        }
    }
}
