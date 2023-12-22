using System;

namespace SetCompare
{
    class IEnumerable
    {
        static void Main(string[] args)
        {
            People people = new People();
            people.AddPerson(new Person("가", 25, "남"));
            people.AddPerson(new Person("나", 30, "남"));
            people.AddPerson(new Person("다", 22, "여"));

            foreach (Person person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, Gender: {person.Gender}");
            }
        }
    }
}