using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensured.Tests
{
    public static partial class Fixtures
    {
        public static object[] Arrays(int count, FixType type)
        {
            return new []
            {
                new [] { new object[] { 1 } }
            };
        }
    }
}
