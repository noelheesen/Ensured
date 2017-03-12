using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensured.Internal
{
    internal static class IntegerExtensions
    {
        public static bool IsPrime(this int i, int value) {
            if (value <= 1) {
                return false;
            }

            for (int j = 2; j * j <= value; j++) {
                if ((value % j).Equals(0)) {
                    return false;
                }
            }

            return true;
        }
    }
}
