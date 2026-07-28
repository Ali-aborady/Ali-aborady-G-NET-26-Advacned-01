using System;
using System.Collections.Generic;
using System.Text;

namespace Adv_Csharp
{
    class SearchHelper
    {
        public static T FindMax<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Array cannot be null or empty.");

            T max = array[0];  

            for (int i = 1; i < array.Length; i++)
            {
                
                if (array[i].CompareTo(max) > 0)
                    max = array[i];
            }
            return max;
        }
    }
}
