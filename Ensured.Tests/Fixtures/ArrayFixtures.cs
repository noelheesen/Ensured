using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensured.Tests
{
    public static class ArrayFixtures
    {
        static object[] StringArrays = new string[][] 
        {
            new [] { "Hello", "from", "the", "Netherlands" }
            , new [] { "How", "is", "your", "day?" }
        };

        static object[] IntArrays = new int[][]
        {
            new [] { 1, 2, 3, 4 }
            , new [] { 5, 6, 7, 8 }
        };
    }
}
