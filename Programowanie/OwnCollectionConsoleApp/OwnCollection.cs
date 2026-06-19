using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OwnCollectionConsoleApp
{
    public class OwnCollection<T> : IEnumerable<T>
    {
        private T[] items;
        private int count = 0;

        public int Count
        {
            get { return count; }
        }

        public OwnCollection(int capacity = 5)
        {
            items = new T[capacity];
        }

        public void Add(T item)
        {
            if (count == items.Length)
                Resize();

            items[count++] = item;
        }

        private void Resize()
        {
            T[] newArray = new T[items.Length * 2];
            for (int i = 0; i < items.Length; i++)
                newArray[i] = items[i];

            items = newArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
