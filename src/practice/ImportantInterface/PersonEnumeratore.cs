using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterface
{
   
    internal class PersonEnumeratore : IEnumerator<Person>
    {
        private Person[] _person;
        private int _current;
       
        public Person Current => _person[_current];

        object IEnumerator.Current => _person[_current];
        public PersonEnumeratore(Person[] person)
        {
            _current = -1;
            _person = person;
        }
        public void Dispose()
        {
            _person = null;
        }

        public bool MoveNext()
        {
            _current++;
            return _current < _person.Length;
        }

        public void Reset()
        {
            _current = -1;
        }
    }
}
