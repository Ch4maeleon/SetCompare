using System.Collections;
using System.Collections.Generic;

namespace SetCompare
{
    internal class People : IEnumerable
    {
        public List<Person> peopleList = new List<Person>();

        public void AddPerson(Person person)
        {
            peopleList.Add(person);
        }

        public IEnumerator<Person> GetEnumerator()
        {
            return peopleList.GetEnumerator();
        }
    }
}