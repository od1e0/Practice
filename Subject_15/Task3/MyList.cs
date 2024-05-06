using System;

namespace Task3
{
    public class MyList<T>
    {
        private T[] _items;
        private int _count;

        public MyList()
        {
            _items = new T[0];
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _count)
                {
                    throw new IndexOutOfRangeException();
                }
                return _items[index];
            }
        }

        public int Count
        {
            get { return _count; }
        }

        public void Add(T item)
        {
            if (_count == _items.Length)
            {
                Array.Resize(ref _items, _count == 0 ? 4 : _count * 2);
            }
            _items[_count] = item;
            _count++;
        }
    }
}
