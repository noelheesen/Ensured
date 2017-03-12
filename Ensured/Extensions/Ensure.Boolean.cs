namespace Ensured
{
    using System;

    /// <summary>
    /// Exposes <see cref="bool"/> extensions for <see cref="ArgumentContext{T}"/>
    /// </summary>
    public static class BooleanExtensions
    {
        #region IsTrue

        /// <summary>
        /// Ensures the given <see cref="bool"/> value equals <c>true</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="bool"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="bool"/> not equals <c>true</c></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static bool IsTrue(this ArgumentContext<bool> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => Equals(a, true),
                message ?? $"Expected <{argument}> to be true.",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="bool?"/> value equals <c>true</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="bool?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="bool?"/> not equals <c>true</c></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static bool? IsTrue(this ArgumentContext<bool?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => Equals(a, true),
                message ?? $"Expected <{argument}> to be true.",
                paramName);
        }

        #endregion

        #region IsTrueOrNull

        /// <summary>
        /// Ensures the given <see cref="bool?"/> value equals <c>true</c> or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="bool?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="bool?"/> is not <c>null</c> and not equals <c>true</c></exception>
        public static bool? IsTrueOrNull(this ArgumentContext<bool?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a == null | Equals(a, true),
                message ?? $"Expected <{argument}> to be true.",
                paramName,
                true);
        }

        #endregion

        #region IsFalse

        /// <summary>
        /// Ensures the given <see cref="bool"/> value equals <c>false</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="bool"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="bool"/> not equals <c>false</c></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static bool IsFalse(this ArgumentContext<bool> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => Equals(a, false),
                message ?? $"Expected <{argument}> to be false.",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="bool?"/> value equals <c>false</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="bool?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="bool?"/> not equals <c>false</c></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static bool? IsFalse(this ArgumentContext<bool?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => Equals(a, false),
                message ?? $"Expected <{argument}> to be false.",
                paramName);
        }

        #endregion

        #region IsFalseOrNull

        /// <summary>
        /// Ensures the given <see cref="bool?"/> value equals <c>false</c> or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="bool?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="bool?"/> is not <c>null</c> and not equals <c>false</c></exception>
        public static bool? IsFalseOrNull(this ArgumentContext<bool?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => Equals(a, null) | Equals(a, false),
                message ?? $"Expected <{argument}> to be false.",
                paramName,
                true);
        }

        #endregion
    }
}
