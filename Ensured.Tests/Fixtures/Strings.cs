using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ensured.Tests
{
    public static partial class Fixtures
    {
        private static string _printableChars;
        static string PrintableChars {
            get {
                return _printableChars ?? (_printableChars = new Func<string>(() =>
                {
                    StringBuilder result = new StringBuilder();

                    for (int i = char.MinValue; i < char.MaxValue; i++)
                    {
                        char c = Convert.ToChar(i);
                        if (!char.IsControl(c))
                        {
                            result.Append(c);
                        }
                    }

                    return result.ToString();
                })());
            }
        }

        public static object[] Strings(int amount)
        {
            Random rand = new Random();

            List<object[]> result = new List<object[]>();
            for (int i = 0; i < amount; i++)
            {
                result.Add(
                    new[] {
                        new string(
                            Enumerable.Repeat(PrintableChars, rand.Next(1, 30))
                            .Select(x => x[rand.Next(x.Length)]).ToArray())
                    });
            }
            return result.ToArray();
        }
    }
}
