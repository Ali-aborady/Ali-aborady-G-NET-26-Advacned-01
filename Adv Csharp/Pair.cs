using System;
using System.Collections.Generic;
using System.Text;

namespace Adv_Csharp
{
    public class Pair<TKey, TValue>
    {
        public TKey Key { get; private set; }
        public TValue Value { get; private set; }

        public Pair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        public Pair<TValue, TKey> Swap()
        {
            return new Pair<TValue, TKey>(Value, Key);
        }

        public override string ToString()
            => $"Key: {Key} ({typeof(TKey).Name}), " +
               $"Value: {Value} ({typeof(TValue).Name})";
    }
}