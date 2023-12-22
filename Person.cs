using System;

namespace SetCompare
{
    internal class Person : IComparable
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

        public int CompareTo(object obj)
        {
            Person p = obj as Person;
            // return Name.CompareTo(p.Name);
            return Age.CompareTo(p.Age);
            // return Gender.CompareTo(p.Gender);
        }
    }
}
