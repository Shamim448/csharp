using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildin_Interface
{
    internal class PersonEnamuretor : IEnumerator<Person>
    {
        private Person[] _person;
        private int _current;
        public Person Current => _person[_current];
        object IEnumerator.Current => _person[_current];
        public PersonEnamuretor(Person[] person)
        {
            _current= -1;
            _person= person;
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
