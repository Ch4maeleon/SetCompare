using System;

namespace SetCompare
{
    internal class IEquatable
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("가", 20, "남", 3);
            Person person2 = new Person("나", 23, "여", 4);
            Person person3 = new Person("다", 20, "남", 3);
            
            if (person1.Equals(person2))
                Console.WriteLine($"{person1.Name}과 {person2.Name}는 같은 객체입니다.");
            else
                Console.WriteLine($"{person1.Name}과 {person2.Name}는 다른 객체입니다.");

            Console.WriteLine();

            if (person1.Equals(person3))
                Console.WriteLine($"{person1.Name}과 {person3.Name}는 같은 객체입니다.");
            else
                Console.WriteLine($"{person1.Name}과 {person3.Name}는 다른 객체입니다.");

            Console.WriteLine();

            Console.WriteLine($"{person1.Name}의 GetHashCode: {person1.GetHashCode()}");
            Console.WriteLine($"{person2.Name}의 GetHashCode: {person2.GetHashCode()}");
            Console.WriteLine($"{person3.Name}의 GetHashCode: {person3.GetHashCode()}");
        }
    }
}
