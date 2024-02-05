using System.Collections;


namespace List
{
    public class MyList<T> : IEnumerable<T>
    {
        private T[] _items = new T[100];
        private int _index = 0;

        public T this[int i]
        {
            get { return _items[i]; }
            set { _items[i] = value; }
        }

        public void Add(T item)
        {
            _items[_index] = item;
            _index++;
        }

        public void AddItem(T item)
        {
            _items[_index] = item;
            _index++;

            if (_index >= _items.Length)
            {
                T[] array = new T[_items.Length * 2];
                for (int i = 0; i < _items.Length; i++)
                {
                    array[i] = _items[i];
                }

                _items = array;
            }
        }

        public void AddRange(ICollection<T> items)
        {
            foreach (T item in items)
            {
                AddItem(item);
            }
        }

        public void Remove(T item)
        {
            T[] newArray = new T[_items.Length];
            int counter = 0;

            for (int i = 0; i < _index; i++)
            {
                if (_items[i].Equals(item))
                {
                    continue;
                }
                else
                {
                    newArray[counter] = _items[i];
                    counter++;
                }
            }

            _index--;
            _items = newArray;
        }

        public void SetDefaultAt(int index)
        {
            T[] newArray = new T[_items.Length];
            int counter = 0;
            for (int i = 0; i < _index; i++)
            {
                if (_items[i].Equals(_items[index]))
                {
                    continue;
                }
                else
                {
                    newArray[counter] = _items[i];
                    counter++;
                }
            }

            _index--;
            _items = newArray;
        }

        public void Sort()
        {
            Array.Sort(_items, 0, _index);
        }

        public IEnumerator<T> GetEnumerator()
        {
            int index = 0;
            while (index < _index)
            {
                yield return _items[index];
                index++;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}