using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildin_Interface
{
    internal class Pepole : IEnumerable<Person>, ICollection<Person>
    {
        private Person[] _person;
        private int _index;

        public int Count => _index;

        public bool IsReadOnly => true;

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

        public void Clear()
        {
            for(int i = 0; i < _person.Length; i++)
            {
                _person[i] = null;
            }
            _index = 0;
        }

        public bool Contains(Person item)
        {
            for(int i = 0; i < _person.Length; i++)
            {
                if (item.Name == _person[i].Name) return true;
            }
            return false;
        }

        public void CopyTo(Person[] array, int arrayIndex)
        {
            for(int i = 0; i < _index && arrayIndex + i < array.Length; i++)
            {
                array[arrayIndex + i] = _person[i];
            }
        }

        public bool Remove(Person item)
        {
           bool result = false;
            for(int i = 0; i < _person.Length; i++)
            {
                if(item.Name == _person[i].Name) {
                    result = true;
                    for (int j = i + 1; j < _person.Length; j++)
                    {
                        _person[j - 1] = _person[j];
                    }
                    _index--;
                }
               
            }
            return result;
        }
    }
}
