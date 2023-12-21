using System;
using System.Collections.Generic;

namespace SetCompare
{
    class IComparable
    {
        class Person : IComparable<Person>
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }

            public Person(string name, int age, string gender)
            {
                Name = name;
                Age = age;
                Gender = gender;
            }

            public int CompareTo(Person person)
            {
                return Gender.CompareTo(person.Gender);
            }
        }
        static void Main(string[] args)
        {
            List<Person> plist = new List<Person>
            {
                new Person("가", 20, "남"),
                new Person("나", 23, "남"),
                new Person("라", 21, "여"),
                new Person("마", 25, "남"),
                new Person("다", 21, "남"),
            };

            foreach (var p in plist)
            {
                Console.WriteLine($"{p.Name} {p.Age} {p.Gender}");
            }

            plist.Sort();

            Console.WriteLine();

            foreach (var p in plist)
            {
                Console.WriteLine($"{p.Name} {p.Age} {p.Gender}");
            }
        }
    }
}