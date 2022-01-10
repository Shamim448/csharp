using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterface
{
    internal class People : IEnumerable<Person>, ICollection<Person>
    {
        private Person[] _persons;
        private int index;

        public int Count => index;

        public bool IsReadOnly => true;

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

        public void Clear()
        {

            for (int i = 0; i < _persons.Length; i++)
            {
                _persons[i] = null;
            }
            index = 0;
        }

        public bool Contains(Person item)
        {
                for (int i = 0; i < index; i++)
                {
                    if(item.Name == _persons[i].Name)
                    {
                        return true;
                    }
                }
                return false;
            }

        public void CopyTo(Person[] array, int arrayIndex)
        {
            for (int i = 0; i < index; i++)
            {
                array[arrayIndex+i] = _persons[i];    
            }
        }

        public bool Remove(Person item)
        {
            throw new NotImplementedException();
        }
    }
}
