using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MyList<T> : IEnumerable<T>
    {
        private T[] items = Array.Empty<T>();

        public T this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }

        public int Count 
        {
            get 
            {
                return items.Length; 
            } 
        }

        public void Add(T value)
        {
            var newArray = new T[items.Length + 1];

            for (int i = 0; i < items.Length; i++)
            {
                newArray[i] = items[i];
            }
            newArray[items.Length] = value;
            items = newArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in items)
            {
                yield return item;
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
