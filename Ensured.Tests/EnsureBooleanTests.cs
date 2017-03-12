namespace Ensured.Tests
{
    using System;
    using Shouldly;

    public class EnsureBooleanTests
    {
        public void Boolean_IsTrue_should_pass() {
            var sut = Ensure.That(true).IsTrue();
            sut.ShouldBeTrue();
        }

        public void Boolean_IsTrue_should_throw_exception() {
            Should.Throw<ArgumentException>(() => Ensure.That(false).IsTrue());
        }

        public void Boolean_IsFalse_should_pass() {
            var sut = Ensure.That(false).IsFalse();
            sut.ShouldBeFalse();
        }

        public void Boolean_IsFalse_should_throw_exception() {
            Should.Throw<ArgumentException>(() => Ensure.That(true).IsFalse());
        }
    }
}
