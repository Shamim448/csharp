using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsApps
{
    internal class Box<T> where T : Item
    {
        T[] _items;
        int _index;
        public Box()
        {
            _index = 0;
            _items = new T[_index++];

        }
        public Box(int size)
        {
            _index = 0;
            _items = new T[size];

        }
        public void Add(T item)
        {
            if(_index < _items.Length)
            {
                _items[_index++] = item;
            }
        }
        public T Get(int index)
        {
            if (index < _items.Length)
            {
                return _items[index];
            }
            else
                return default(T);
        }
        public void Clear()
        {
            _index = 0;
            for(int i = 0; i < _items.Length; i++)
            {
                _items[i] = null;
            }
        }
    }
}
