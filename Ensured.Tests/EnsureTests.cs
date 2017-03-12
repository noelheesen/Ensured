namespace Ensured.Tests
{
    using Shouldly;
    using System;
    using System.Linq.Expressions;

    public class EnsureTests
    {
        [Input(1)]
        [Input(true)]
        public void argument_created_from_that(object value) {
            var sut = Ensure.That(value);
            sut.ShouldNotBeNull();
        }

        [Input(1, "one")]
        [Input(true, "true")]
        public void not_null_value(object value, string paramName) {
            var sut = Ensure.NotNull(value, paramName);
            sut.ShouldNotBeNull();
        }

        public void not_null_throws_ArgumentNullException_if_null() {
            int? i = null;
            Should.Throw<ArgumentNullException>(() => Ensure.NotNull(i, "parameter"));
        }
        
        public void argument_meets_condition() {
            var sut = Ensure.Condition(1, i => i > 0);
            sut.ShouldBe(1);
        }

        public void exception_thrown_when_argument_not_meets_condition() {
            Should.Throw<ArgumentException>(() => Ensure.Condition(1, i => i == 0));
        }


    }
}
