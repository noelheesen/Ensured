namespace Ensured.Tests
{
    using System;
    using Shouldly;

    class EnsureArrayTests
    {
        private int[] intArray;
        private string[] stringArray;
        

        public void Array_IsNotEmpty_should_pass_validation() {
            string[] array = new[] { "Hello" };
            Ensure.That(array).IsNotEmpty().ShouldNotBeEmpty();
        }

        public void Array_IsNotEmpty_should_throw_exception_when_array_empty() {
            string[] array = new string[0];
            Should.Throw<ArgumentException>(() => Ensure.That(array).IsNotEmpty());
        }

        public void Array_CountIs_should_pass_validation() {
            string[] array = new[] { "Hello" };
            var sut = Ensure.That(array).CountIs(1);
            sut.ShouldNotBeNull();
        }

        public void Array_CountIs_should_throw_exception() {
            string[] array = new string[0];
            Should.Throw<ArgumentException>(() => Ensure.That(array).CountIs(1));
        }

        public void Array_Contains_should_pass_validation() {
            string[] array = new[] { "Hello" };
            var sut = Ensure.That(array).Contains("Hello");
            sut.ShouldNotBeNull();
        }

        public void Array_Contains_should_throw_exception() {
            string[] array = new string[0];
            Should.Throw<ArgumentException>(() => Ensure.That(array).Contains("Hello"));
        }
    }
}
