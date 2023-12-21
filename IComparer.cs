using System;
using System.Collections;

namespace SetCompare
{
    class PersonComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Person personX = (Person)x;
            Person personY = (Person)y;
            return personX.Age.CompareTo(personY.Age);
        }
    }

    class Person
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
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList plist = new ArrayList
            {
                new Person("가", 20, "남"),
                new Person("나", 23, "남"),
                new Person("라", 21, "여"),
                new Person("마", 25, "남"),
                new Person("다", 21, "남"),
            };

            foreach (var p in plist)
            {
                Console.WriteLine($"{((Person)p).Name} {((Person)p).Age} {((Person)p).Gender}");
            }

            plist.Sort(new PersonComparer());

            Console.WriteLine();

            foreach (var p in plist)
            {
                Console.WriteLine($"{((Person)p).Name} {((Person)p).Age} {((Person)p).Gender}");
            }
        }
    }
}