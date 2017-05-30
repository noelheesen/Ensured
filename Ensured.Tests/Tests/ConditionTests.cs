namespace Ensured.Tests
{
    using System;
    using System.Text;
    using Shouldly;

    using Helpers;
    using Attributes;

    public partial class EnsureTests
    {
        public class ConditionTests : IDisposable
        {
            #region Setup - TearDown

            readonly StringBuilder log;

            static object[] fixtures = Fixtures.Get(3, FixType.Value);

            // Setup
            public ConditionTests()
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


            // .Condition(value)

            public void Condition_Value_Returns_ArgumentNullException_If_Condition_Is_Null()
            {
                Should.Throw<ArgumentNullException>(() =>
                    Ensure.Condition(testObj, nullCondition));
            }

            [TestCaseSource("fixtures")]
            public void Condition_Value_Returns_Value_If_Meets_Condition(object input)
            {
                Ensure.Condition(input, trueCondition).ShouldBe(input);
            }
            [TestCaseSource("fixtures")]
            public void Condition_Value_Returns_ArgumentException_If_Condition_Not_Met(object input)
            {
                Should.Throw<ArgumentException>(() =>
                    Ensure.Condition(input, falseCondition));
            }

            public void Condition_Value_Returns_Null_If_Condition_Met_And_AllowNull()
            {
                Ensure.Condition(nullObj, trueCondition, null, null, true).ShouldBe(nullObj);
            }
            public void Condition_Value_Returns_ArgumentNullException_If_Condition_Met_With_NullValue_And_Not_AllowNull()
            {
                Should.Throw<ArgumentNullException>(() =>
                    Ensure.Condition(nullObj, trueCondition));
            }
            public void Condition_Value_Returns_ArgumentNullException_If_Condition_Not_Met_With_NullValue_And_Not_AllowNull()
            {
                Should.Throw<ArgumentNullException>(() =>
                    Ensure.Condition(nullObj, falseCondition));
            }

            public void Condition_Value_ArgumentException_Returns_Custom_ParamName_If_Condition_Not_Met()
            {
                Should.Throw<ArgumentException>(() =>
                    Ensure.Condition(testObj, falseCondition, null, customParamName)).ParamName.ShouldBe(customParamName);
            }
            public void Condition_Value_ArgumentException_Returns_Custom_Message_If_Condition_Not_Met()
            {
                Should.Throw<ArgumentException>(() =>
                    Ensure.Condition(testObj, falseCondition, customMessage)).Message.ShouldContain(customMessage);
            }


            // .Condition(expression)

            public void Condition_Expression_Returns_ArgumentNullException_If_Expression_Is_Null()
            {
                Should.Throw<ArgumentNullException>(() => Ensure.Condition(nullExpression, trueCondition));
            }
            public void Condition_Expression_Returns_ArgumentNullException_If_Condition_Is_Null()
            {
                Should.Throw<ArgumentNullException>(() => Ensure.Condition(() => testObj, nullCondition));
            }

            [TestCaseSource("fixtures")]
            public void Condition_Expression_Returns_Value_If_Condition_Met(object input)
            {
                Ensure.Condition(() => input, trueCondition).ShouldBe(input);
            }
            [TestCaseSource("fixtures")]
            public void Condition_Expression_Returns_ArgumentException_If_Condition_Not_Met(object input)
            {
                Should.Throw<ArgumentException>(() => 
                    Ensure.Condition(() => input, falseCondition));
            }

            public void Condition_Expression_Returns_Null_If_Condition_Met_And_AllowNull()
            {
                Ensure.Condition(() => nullObj, trueCondition, null, null, true).ShouldBe(nullObj);
            }
            public void Condition_Expression_Returns_ArgumentNullException_If_Condition_Met_With_NullValue_And_Not_AllowNull()
            {
                Should.Throw<ArgumentNullException>(() => Ensure.Condition(() => nullObj, trueCondition));
            }
            public void Condition_Expression_Returns_ArgumentNullException_If_Condition_Not_Met_With_NullValue_And_Not_AllowNull()
            {
                Should.Throw<ArgumentNullException>(() => Ensure.Condition(() => nullObj, falseCondition));
            }

            public void Condition_Expression_ArgumentException_Returns_Custom_ParamName_If_Condition_Not_Met()
            {
                Should.Throw<ArgumentException>(() => 
                    Ensure.Condition(() => testObj, falseCondition, null, customParamName)).ParamName.ShouldBe(customParamName);
            }
            public void Condition_Expression_ArgumentException_Returns_Custom_Message_If_Condition_Not_Met()
            {
                Should.Throw<ArgumentException>(() =>
                    Ensure.Condition(() => testObj, falseCondition, customMessage)).Message.ShouldContain(customMessage);
            }
        }
    }
    
}
