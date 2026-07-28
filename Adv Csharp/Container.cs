namespace Adv_Csharp
{
    public class Container<T>
    {
        private List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
            Console.WriteLine($"Added: {item}");
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _items.Count)
                throw new IndexOutOfRangeException($"Index {index} is out of range.");
            return _items[index];
        }
        public int Count => _items.Count;
    }
}
