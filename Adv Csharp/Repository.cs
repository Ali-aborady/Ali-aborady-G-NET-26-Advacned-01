namespace Adv_Csharp
{
    public class Repository<T>
    {
        protected System.Collections.Generic.List<T> _items = new();

        public virtual void Add(T item)
        {
            _items.Add(item);
            Console.WriteLine($"[Base] Added: {item}");
        }

        public int Count => _items.Count;
    }

    // 1. CLOSED — fixes T = string
    class StringRepository : Repository<string>
    {
        public override void Add(string item)
        {
            _items.Add(item.ToUpper()); 
            Console.WriteLine($"[String] Added uppercase: {item.ToUpper()}");
        }
    }

    // 2. OPEN — passes T through
    class LoggedRepository<T> : Repository<T>
    {
        public override void Add(T item)
        {
            Console.WriteLine($"[LOG] About to add: {item}");
            base.Add(item); 
        }
    }

    // 3. PARTIAL — adds a second type parameter
    class KeyedRepository<TKey, TValue> : Repository<TValue>
    {
        private System.Collections.Generic.Dictionary<TKey, TValue> _map = new ();

        public void AddWithKey(TKey key, TValue value)
        {
            _map[key] = value;
            base.Add(value);
        }

        public TValue GetByKey(TKey key)
            => _map.TryGetValue(key, out TValue v) ? v : default!;
    }
}
