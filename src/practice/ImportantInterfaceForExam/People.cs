using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterfaceForExam
{
    internal class People : IEnumerable<Person>,ICollection<Person>
    {
        Person[] _person;
        int _index;
        public People( int size)
        {
            _person = new Person[size];
            _index = 0;
        }
        public int Count => _index;

        public bool IsReadOnly => true;

        public void Add(Person item)
        {
            _person[_index++] = item;
        }

        public void Clear()
        {
            for(int i = 0; i < _person.Length; i++)
            {
                _person[_index++] = null;
            }
            _index = 0;
        }

        public bool Contains(Person item)
        {
           bool result = false;
            for(int i = 0; i < _person.Length; i++)
            {
                if(_person[i] == item)
                {
                    result = true;
                }
            }
            return result;
        }

        public void CopyTo(Person[] array, int arrayIndex)
        {
            for(int i =0; i < _person.Length; i++)
            {
                array[arrayIndex+i] = _person[i];
            }
        }

        public IEnumerator<Person> GetEnumerator()
        {
            return new PersonEnumerator(_person);
        }

        public bool Remove(Person item)
        {
            bool result = false;
            for(int i = 0; i < _person.Length; i++)
            {
                if(item.Name == _person[i].Name)
                {
                    result = true;
                    for(int j = i+1; j < _person.Length; j++)
                    {
                        _person[j-1] = _person[j];
                    }
                }
            }
            return result; 
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
