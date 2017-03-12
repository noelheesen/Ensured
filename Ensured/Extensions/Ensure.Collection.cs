namespace Ensured
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Exposes <see cref="ICollection"/> extensions for <see cref="ArgumentContext{T}"/>
    /// </summary>
    public static class CollectionExtensions
    {
        /// <summary>
        /// Ensures the given <see cref="ICollection"/> is not empty
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="ICollection"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the collection has no items</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static ICollection IsNotEmpty(this ArgumentContext<ICollection> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a.Count > 0,
                message ?? $"Expected the collection to have an item.",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="ICollection{T}"/> is not empty
        /// </summary>
        /// <typeparam name="T">The <see cref="Type"/> of items in the collection</typeparam>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="ICollection{T}"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the collection has no items</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static ICollection<T> IsNotEmpty<T>(this ArgumentContext<ICollection<T>> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a.Count > 0,
                message ?? $"Expected the collection to have an item.",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="ICollection"/> has an exact amount of items, see <paramref name="count"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="count">The amount of items expected in the <see cref="ICollection"/></param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="ICollection"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the amount of items in the <see cref="ICollection"/> differs from <paramref name="count"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="count"/> is <c>null</c></exception>
        public static ICollection CountIs(this ArgumentContext<ICollection> argument, int count, string message = null, string paramName = null) {
            Ensure.NotNull(count, "Count");
            return Ensure.Condition(
                argument.Value,
                a => a.Count.Equals(count),
                message ?? $"Expected the collection to have <{count}> items, it has <{argument.Value.Count}>.",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="ICollection{T}"/> has an exact amount of items, see <paramref name="count"/>
        /// </summary>
        /// <typeparam name="T">The <see cref="Type"/> of items in the collection</typeparam>
        /// <param name="argument">The context describing the value</param>
        /// <param name="count">The amount of items expected in the <see cref="ICollection{T}"/></param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="ICollection{T}"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the amount of items in the <see cref="ICollection{T}"/> differs from <paramref name="count"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="count"/> is <c>null</c></exception>
        public static ICollection<T> CountIs<T>(this ArgumentContext<ICollection<T>> argument, int count, string message = null, string paramName = null) {
            Ensure.NotNull(count, "Count");
            return Ensure.Condition(
                argument.Value,
                a => a.Count.Equals(count),
                message ?? $"Expected the collection to have <{count}> items, it has <{argument.Value.Count}>.",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="ICollection{T}"/> contains <typeparamref name="T"/> <paramref name="value"/>
        /// </summary>
        /// <typeparam name="T">The <see cref="Type"/> of items in the collection</typeparam>
        /// <param name="argument">The context describing the value</param>
        /// <param name="value">The value to find in the collection</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="ICollection{T}"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the <see cref="ICollection{T}"/> does not contain <paramref name="value"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="value"/> is <c>null</c></exception>
        public static ICollection<T> Contains<T>(this ArgumentContext<ICollection<T>> argument, T value, string message = null, string paramName = null) {
            Ensure.NotNull(value, "Value");
            return Ensure.Condition(
                argument.Value,
                a => a.Contains(value),
                message ?? $"Expected to find <{value}> in the collection of <{typeof(T).Name}>",
                paramName);
        }
    }
}
