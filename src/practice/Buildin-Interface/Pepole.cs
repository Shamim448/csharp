using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildin_Interface
{
    internal class Pepole : IEnumerable<Person>
    {
        private Person[] _person;
        private int _index;
        public Pepole(int size)
        {
            _person= new Person[size];
            _index=0;
        }
        public IEnumerator<Person> GetEnumerator()
        {
            return new PersonEnamuretor(_person);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void Add(Person person)
        {
            _person[_index++] = person;
        }
    }
}
