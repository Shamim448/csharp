using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterfaceForExam
{
    internal class PersonEnumerator : IEnumerator<Person>
    {
        Person[] person;
        int _current;
        public PersonEnumerator(Person[] person)
        {
            this.person = person;
            _current = -1;
        }

        public Person Current => person[_current];

        object IEnumerator.Current => person[_current];

        public void Dispose()
        {
            person=null;
        }

        public bool MoveNext()
        {
            _current++;
            return _current < person.Length;
        }

        public void Reset()
        {
            _current = -1;
        }
    }
}
