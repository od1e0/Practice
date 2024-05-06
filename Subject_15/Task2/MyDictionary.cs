using System;
using System.Collections.Generic;

namespace Task2
{
    public class MyDictionary<TKey, TValue>
    {
        private List<TKey> keys;
        private List<TValue> values;

        public MyDictionary()
        {
            keys = new List<TKey>();
            values = new List<TValue>();
        }

        public TValue this[TKey key]
        {
            get
            {
                int index = keys.IndexOf(key);
                if (index == -1)
                {
                    throw new KeyNotFoundException();
                }
                return values[index];
            }
        }

        public int Count
        {
            get { return keys.Count; }
        }

        public void Add(TKey key, TValue value)
        {
            if (keys.Contains(key))
            {
                throw new ArgumentException("An element with the same key already exists in the MyDictionary");
            }
            keys.Add(key);
            values.Add(value);
        }
    }
}
