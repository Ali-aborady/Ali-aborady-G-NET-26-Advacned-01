namespace Adv_Csharp
{
    class SafeList<T>
    {
        private List<T> _items = new List<T>();

        public void Add(T item) => _items.Add(item);

        public T Get(int index)
        {
            if (index < 0 || index >= _items.Count)
            {
                Console.WriteLine($"Index {index} invalid. Returning default.");
                return default!; 
            }
            return _items[index];
        }

        public bool TryGet(int index, out T result)
        {
            if (index < 0 || index >= _items.Count)
            {
                result = default!;
                return false;
            }
            result = _items[index];
            return true;
        }

        public int Count => _items.Count;
        public T this[int index] => Get(index);
    }
}
