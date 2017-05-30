using Ensured.Tests.Attributes;
using Ensured.Tests.Helpers;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensured.Tests
{
    public partial class EnsureTests
    {
        public class ArrayTests : IDisposable
        {
            #region Setup - Teardown

            readonly StringBuilder log;

            static object[] fixtures = Fixtures.Arrays(1, FixType.Value);

            public ArrayTests()
            {
                log = new StringBuilder();
                log.WhereAmI();
            }

            public void Dispose()
            {
                log.WhereAmI();
                log.ShouldHaveLines(
                    ".ctor",
                    "Dispose"
                    );
            }

            #endregion

            [TestCaseSource("fixtures")]
            public void IsNotEmpty_Returns_Array_If_Not_Empty(object input)
            {
                var arr = (object[])input;
                Ensure.That(arr).IsNotEmpty().ShouldBe(arr);
            }

            public void IsNotEmpty_Returns_ArgumentException_If_Empty()
            {
                Should.Throw<ArgumentException>(() => Ensure.That(new object[0]).IsNotEmpty());
            }

            [TestCaseSource("fixtures")]
            public void CountIs_Returns_Array_When_Count_Correct(object input)
            {
                var arr = (object[])input;
                Ensure.That(arr).CountIs(arr.Length).ShouldBe(arr);
            }

            [TestCaseSource("fixtures")]
            public void CountIs_Returns_ArgumentException_When_Count_Incorrect(object input)
            {
                var arr = (object[])input;
                Should.Throw<ArgumentException>(() => Ensure.That(arr).CountIs(arr.Length + 1));
            }

            [TestCaseSource("fixtures")]
            public void Contains_Returns_Array_When_Contains_Item(object input)
            {
                var arr = (object[])input;
                Ensure.That(arr).Contains(arr.First()).ShouldBe(arr);
            }

            [TestCaseSource("fixtures")]
            public void Contains_Returns_ArgumentException_When_Not_Contains_Item(object input)
            {
                var arr = (object[])input;
                Should.Throw<ArgumentException>(() => Ensure.That(arr).Contains(new object()));
            }
        }
    }
}
