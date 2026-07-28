using System;
using System.Collections.Generic;
using System.Text;

namespace Adv_Csharp
{
    class Cache<TKey, TValue>
    {
        private readonly Dictionary<TKey, CacheEntry<TValue>> _store
            = new Dictionary<TKey, CacheEntry<TValue>>();

        private readonly TimeSpan _defaultTTL; 

        public Cache(TimeSpan defaultTTL)
        {
            _defaultTTL = defaultTTL;
        }

        //Add 
        public void Add(TKey key, TValue value)
            => Add(key, value, _defaultTTL);

        public void Add(TKey key, TValue value, TimeSpan ttl)
        {
            _store[key] = new CacheEntry<TValue>(value, ttl);
            Console.WriteLine($"[Cache] Added key='{key}' expires in {ttl.TotalSeconds}s");
        }

        //Get
        public bool TryGet(TKey key, out TValue value)
        {
            if (_store.TryGetValue(key, out CacheEntry<TValue> entry))
            {
                if (!entry.IsExpired)
                {
                    value = entry.Value;
                    Console.WriteLine($"[Cache] HIT  key='{key}'");
                    return true;
                }
                _store.Remove(key);
                Console.WriteLine($"[Cache] EXPIRED key='{key}'");
            }
            else
            {
                Console.WriteLine($"[Cache] MISS key='{key}'");
            }

            value = default;
            return false;
        }

        // Get or default (convenience method)
        public TValue Get(TKey key)
            => TryGet(key, out TValue val) ? val : default!;

        //Remove 
        public bool Remove(TKey key)
        {
            bool removed = _store.Remove(key);
            Console.WriteLine(removed
                ? $"[Cache] Removed key='{key}'"
                : $"[Cache] Key='{key}' not found for removal");
            return removed;
        }

        //Contains 
        // Returns true only if key exists AND is not expired
        public bool Contains(TKey key)
        {
            if (_store.TryGetValue(key, out CacheEntry<TValue> entry))
            {
                if (!entry.IsExpired) return true;
                _store.Remove(key); 
            }
            return false;
        }

        //Cleanup
        // Remove all expired entries
        public int Cleanup()
        {
            var expired = new List<TKey>();
            foreach (var kvp in _store)
                if (kvp.Value.IsExpired)
                    expired.Add(kvp.Key);

            foreach (var key in expired)
                _store.Remove(key);

            Console.WriteLine($"[Cache] Cleaned up {expired.Count} expired entries");
            return expired.Count;
        }

        //Stats 
        public int Count => _store.Count;

        public void PrintStats()
        {
            Console.WriteLine($"[Cache] Total entries: {_store.Count}");
            foreach (var kvp in _store)
            {
                var entry = kvp.Value;
                var status = entry.IsExpired ? "EXPIRED" : "VALID";
                Console.WriteLine(
                    $"  Key='{kvp.Key}' | Value='{entry.Value}' | " +
                    $"Expires={entry.ExpiresAt:HH:mm:ss} | {status}");
            }
        }
    }
}
