using Ensured.Tests.Helpers;
using System;
using System.Text;

namespace Ensured.Tests
{
    using Attributes;
    using Shouldly;
    using System.Linq.Expressions;

    public partial class EnsureTests
    {
        public class NotNullTests : IDisposable
        {
            #region Setup - TearDown

            readonly StringBuilder log;

            static object[] fixtures = Fixtures.Get(3, FixType.Value);

            // Setup
            public NotNullTests()
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
            public void NotNull_Value_Returns_Value_If_Not_Null(object input)
            {
                Ensure.NotNull(input).ShouldBe(input);
            }
            public void NotNull_Value_Returns_ArgumentNullException_If_Null()
            {
                Should.Throw<ArgumentNullException>(() => Ensure.NotNull(nullObj));
            }
            public void NotNull_Value_Exception_Returns_Custom_ParamName()
            {
                Should.Throw<ArgumentNullException>(() =>
                    Ensure.NotNull(nullObj, customParamName)).ParamName.ShouldBe(customParamName);
            }
            public void NotNull_Value_Exception_Returns_Custom_Message()
            {
                Should.Throw<ArgumentNullException>(() =>
                    Ensure.NotNull(nullObj, null, customMessage)).Message.ShouldContain(customMessage);
            }

            [TestCaseSource("fixtures")]
            public void NotNull_Expression_Returns_Value_If_Not_Null(object input)
            {
                Ensure.NotNull(() => input).ShouldBe(input);
            }
            public void NotNull_Expression_Returns_ArgumentNullException_If_Expression_Null()
            {
                Should.Throw<ArgumentNullException>(() => Ensure.NotNull(nullExpression));
            }
            public void NotNull_Expression_Returns_ArgumentNullException_If_Value_Null()
            {
                Should.Throw<ArgumentNullException>(() => Ensure.NotNull(() => nullObj));
            }
            public void NotNull_Expression_Exception_Returns_Custom_ParamName()
            {
                Should.Throw<ArgumentNullException>(() => 
                    Ensure.NotNull(() => nullObj, customParamName)).ParamName.ShouldBe(customParamName);
            }
            public void NotNull_Expression_Exception_Returns_Custom_Message()
            {
                Should.Throw<ArgumentNullException>(() =>
                    Ensure.NotNull(() => nullObj, null, customMessage)).Message.ShouldContain(customMessage);
            }
        }
    }
}
