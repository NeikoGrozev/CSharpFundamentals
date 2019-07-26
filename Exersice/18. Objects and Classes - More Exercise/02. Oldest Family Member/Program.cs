namespace OldestFamilyMember
{
using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ");

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);
                family.AddMember(person);            
            }

            Person oldPerson = family.GetOldestMember();

            Console.WriteLine($"{oldPerson.Name} {oldPerson.Age}");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age =age;
        }
    }

    class Family
    {       
        public List<Person> AllFamily { get; set; }

        public Family()
        {
            this.AllFamily = new List<Person>();
        }

        public  void AddMember(Person person)
        {
            this.AllFamily.Add(person);
        }

        public Person GetOldestMember()
        {
            Person result = this.AllFamily.OrderByDescending(x => x.Age).First();

            return result;
        }
    }
}
