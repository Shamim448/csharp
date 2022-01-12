using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericReviceForExam
{
    internal class PhoneNumberList<T> where T : Person
    {
       public T[] _phoneNumbers;
        public int _index;
       public PhoneNumberList()
        {
            _index = -1;
            _phoneNumbers = new T[10];

        }
        public void Add(T person)
        {
            if(_index < _phoneNumbers.Length)
            {
                ++_index;
                _phoneNumbers[_index] = person;
            }
           
        }
        
    }
}
