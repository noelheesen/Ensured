using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensured.Internal
{
    internal static class ArrayExtensions
    {
        public static bool Contains<T>(this T[] array, T value) {
            var enumerator = array.GetEnumerator();
            enumerator.Reset();
            while(enumerator.MoveNext()) {
                if (enumerator.Current.Equals(value)) {
                    return true;
                }
            }
            return false;
        }
    }
}
