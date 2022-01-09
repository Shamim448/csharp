using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterface
{
    internal class People : IEnumerable<Person>
    {
        private Person[] _persons;
        private int index;
        public People(int size)
        {
            _persons = new Person[size];
            index = 0;

        }
        public IEnumerator<Person> GetEnumerator()
        {
           return new PersonEnumeratore(_persons);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Person person)
        {
            _persons[index++] = person;  
        }
    }
}
