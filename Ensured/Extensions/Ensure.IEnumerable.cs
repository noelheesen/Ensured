namespace Ensured.Extensions
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    /// <summary>
    /// Exposes <see cref="IEnumerable{T}"/> extensions for <see cref="ArgumentContext{T}"/>
    /// </summary>
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Ensures the given <see cref="IEnumerable{T}"/> is not empty
        /// </summary>
        /// <typeparam name="T">The <see cref="Type"/> of items in the IEnumerable</typeparam>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="IEnumerable{T}"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the <see cref="IEnumerable{T}"/> has no items</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static IEnumerable<T> IsNotempty<T>(this ArgumentContext<IEnumerable<T>> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a.Count() > 0,
                message ?? $"Exptected the IEnumerable of <{typeof(T).Name}> to have an item.",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="IEnumerable{T}"/> has <paramref name="count"/> amount of items
        /// </summary>
        /// <typeparam name="T">The <see cref="Type"/> of items in the IEnumerable</typeparam>
        /// <param name="argument">The context describing the value</param>
        /// <param name="count">The amount of items expected in the <see cref="IEnumerable{T}"/></param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="IEnumerable{T}"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the amount of items in the <see cref="IEnumerable{T}"/> differs from <paramref name="count"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="count"/> is <c>null</c></exception>
        public static IEnumerable<T> CountIs<T>(this ArgumentContext<IEnumerable<T>> argument, int count, string message = null, string paramName = null) {
            Ensure.NotNull(count, "Count");
            return Ensure.Condition(
                argument.Value,
                a => a.Count().Equals(count),
                message ?? $"Exptected the IEnumerable of <{typeof(T).Name}> to have <{count}> items, it has <{argument.Value.Count()}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="IEnumerable{T}"/> contains <typeparamref name="T"/> <paramref name="value"/>
        /// </summary>
        /// <typeparam name="T">The <see cref="Type"/> of items in the IEnumerable</typeparam>
        /// <param name="argument">The context describing the value</param>
        /// <param name="value">The value to find in the collection</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="IEnumerable{T}"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the <see cref="IEnumerable{T}"/> does not contain <paramref name="value"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="value"/> is <c>null</c></exception>
        public static IEnumerable<T> Contains<T>(this ArgumentContext<IEnumerable<T>> argument, T value, string message = null, string paramName = null) {
            Ensure.NotNull(value, "Value");
            return Ensure.Condition(
                argument.Value,
                a => a.Contains(value),
                message ?? $"Exptected the IEnumerable of <{typeof(T).Name}> to contain <{value}>",
                paramName);
        }
    }
}
