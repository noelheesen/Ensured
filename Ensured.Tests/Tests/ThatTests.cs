namespace Ensured.Tests
{
    using System;
    using System.Text;
    using Shouldly;

    using Helpers;
    using Attributes;

    public partial class EnsureTests
    {
        public class ThatTests : IDisposable
        {
            readonly StringBuilder log;

            #region Setup - TearDown

            static object[] fixtures = Fixtures.Get(3, FixType.Value);

            // Setup
            public ThatTests()
            {
                log = new StringBuilder();
                log.WhereAmI();
            }

            // Tear Down
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
            public void That_Object_Returns_ArgumentContext(object input)
            {
                Ensure.That(input).GetType().ShouldBe(typeof(ArgumentContext<object>));
            }

            [TestCaseSource("fixtures")]
            public void That_Expression_Returns_ArgumentContext(object input)
            {
                Ensure.That(() => input).GetType().ShouldBe(typeof(ArgumentContext<object>));
            }
        }
    }
}
