using System;
using System.Collections.Generic;
using System.Text;

namespace Adv_Csharp
{
    public class Utilities
    {
       
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;   
            a = b;        
            b = temp;     
        }
    }
}
