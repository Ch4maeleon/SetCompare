using System;

namespace SetCompare
{
    internal class Person : IEquatable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Ssn { get; set; }

        public Person(string name, int age, string gender, int ssn)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Ssn = ssn;
        }

        public bool Equals(Person other)
        {
            if (Age == other.Age && Gender == other.Gender && Ssn == other.Ssn) 
                return true;
            else 
                return false;
        }

        public override int GetHashCode()
        {
            // 딕셔너리 person 클래스 자체를 키로 쓰려면 
            return Age.GetHashCode() ^ Gender.GetHashCode() ^ Ssn.GetHashCode();
        }
    }
}