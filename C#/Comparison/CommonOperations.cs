using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison
{
    public class CommonOperations<T>
    {
        public static (T x,T y) Swap(T a, T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
            return (a, b);
        }
    }
}
