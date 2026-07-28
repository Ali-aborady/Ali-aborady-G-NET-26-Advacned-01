using System;
using System.Collections.Generic;
using System.Text;

namespace Adv_Csharp
{
   public class NullChecker<T> where T : class
    {
        public bool IsNull(T obj) => obj == null;

        public T GetOrThrow(T obj, string message = "Value is null!")
        {
            if (obj == null)
                throw new NullReferenceException(message);
            return obj;
        }

        public string Describe(T obj)
            => obj == null ? "null" : $"{obj.GetType().Name}: {obj}";
    }
}
