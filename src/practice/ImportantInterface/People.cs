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
        private Person[] _person;
        private int index;
        public People(int size)
        {
            _person = new Person[size];
            index = 0;

        }
        public IEnumerator<Person> GetEnumerator()
        {
           return new PersonEnumeratore(_person);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Person person)
        {
            _person[index++] = person;  
        }
    }
}
