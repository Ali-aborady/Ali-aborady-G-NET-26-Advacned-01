using System;
using System.Collections.Generic;
using System.Text;

namespace Adv_Csharp
{
    class Counter<T>
    {
        private static int _count = 0;

        public T Value { get; }

        public Counter(T value)
        {
            Value = value;
            _count++;
        }

        public static int GetCount() => _count;

        public static void Reset() => _count = 0;
    }
}
