using System;
using System.Collections.Generic;
using System.Text;

namespace Adv_Csharp
{
    public class CacheEntry<TValue>
    {
        public TValue Value { get; }
        public DateTime ExpiresAt { get; }
        public bool IsExpired => DateTime.UtcNow > ExpiresAt;

        public CacheEntry(TValue value, TimeSpan duration)
        {
            Value = value;
            ExpiresAt = DateTime.UtcNow + duration;
        }
    }
}
