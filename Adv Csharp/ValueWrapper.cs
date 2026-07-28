using System;
using System.Collections.Generic;
using System.Text;

namespace Adv_Csharp
{
    public class ValueWrapper<T> where T : struct
    {
        private T _value;
        private bool _hasValue;

        public void Set(T value)
        {
            _value = value;
            _hasValue = true;
        }

        public T GetOrDefault()
            => _hasValue ? _value : default(T); 

        public T? ToNullable()
            => _hasValue ? (T?)_value : null;
    }
}
