using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Box<T>where T : Item
    {
        T[] _item;
        int _index;
        public Box()
        {
            _index = 0;
            _item = new T[100];
        }
        public void Add(T item)
        {
            if(_index < _item.Length)
            {
                _item[_index++] = item;
            }
        }
        public T Get( int index)
        {
            if(index < _item.Length) {
                return _item[index];
            }
            else
            {
                return default(T);
            }
           
        }
        public void Clear()
        {

            for(int i= 0; i<_item.Length; i++)
                _item[i] = null;
        }
        public K GetItem<K>() where K : ICollection<T>, new()
        {
            var items = new K();
            foreach(T item in _item)
            {
                items.Add(item); 
            }
            return items;
        }
            
    }
}
