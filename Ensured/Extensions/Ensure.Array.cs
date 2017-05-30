namespace Ensured
{
    using Internal;
    using System;

    /// <summary>
    /// Exposes <see cref="Array"/> extensions for <see cref="ArgumentContext{T}"/>
    /// </summary>
    public static class ArrayExtensions
    {
        /// <summary>
        /// Ensures the given array has at least one item
        /// </summary>
        /// <typeparam name="T">The <see cref="Type"/> of items in the array</typeparam>
        /// <param name="argument">The context describing the array</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given if validation passes</returns>
        /// <exception cref="ArgumentException">If the <see cref="Array"/> has no items</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static T[] IsNotEmpty<T>(this ArgumentContext<T[]> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a.Length > 0,
                message ?? "Expected the array to have an item.",
                paramName);
        }

        /// <summary>
        /// Ensures the array has <paramref name="count"/> amount of items
        /// </summary>
        /// <typeparam name="T">The <see cref="Type"/> of items in the array</typeparam>
        /// <param name="argument">The context describing the array</param>
        /// <param name="count">The amount of items the array should have</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given array if validation passes</returns>
        /// <exception cref="ArgumentException">If the <see cref="Array"/> length does not equal <paramref name="count"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="count"/> is <c>null</c></exception>
        public static T[] CountIs<T>(this ArgumentContext<T[]> argument, int count, string message = null, string paramName = null) {
            Ensure.NotNull(count, "Count");
            return Ensure.Condition(
                argument.Value, 
                a => Equals(a.Length, count), 
                message ?? $"Expected the array to have <{count}> items, it has <{argument.Value.Length}> items.",
                paramName);
        }

        /// <summary>
        /// Ensures the array contains <typeparamref name="T"/> <paramref name="value"/>
        /// </summary>
        /// <typeparam name="T">The <see cref="Type"/> of items in the array</typeparam>
        /// <param name="argument">The context describing the array</param>
        /// <param name="value">The value to find in the array</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given array if validation passes</returns>
        /// <exception cref="ArgumentException">If the <see cref="Array"/> does not contain <paramref name="value"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="value"/> is <c>null</c></exception>
        public static T[] Contains<T>(this ArgumentContext<T[]> argument, T value, string message = null, string paramName = null) {
            Ensure.NotNull(value, "Value");
            return Ensure.Condition(
                argument.Value,
                a => a.Contains(value),
                message ?? $"Expected the array to contain <{value}>",
                paramName);
        }
    }
}
