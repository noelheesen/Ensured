namespace Ensured
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Exposes <see cref="object"/> extentions for <see cref="ArgumentContext{T}"/> to provide a fluent API
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Ensures the given <see cref="object"/> value is not <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="object"/> if validation passes</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static object NotNull(this ArgumentContext<object> argument, string message = null, string paramName = null) {
            return Ensure.NotNull(argument.Value, message, paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="object"/> value equals <paramref name="value"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="value">The value to compare with <paramref name="argument.Value"/></param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="object"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the <see cref="object"/> does not contain <paramref name="value"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="value"/> is <c>null</c></exception>
        public static object Equals(this ArgumentContext<object> argument, object value, string message = null, string paramName = null) {
            Ensure.NotNull(value, "Value");
            return Ensure.Condition(
                argument.Value,
                a => a.Equals(value),
                message ?? $"Expected <{argument.Value}> to be equal to <{value}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="object"/>'s type is assignable from <paramref name="type"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="type">The <see cref="Type"/> the object should be assignable from.</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="object"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the <see cref="object"/> is not assignable from <paramref name="type"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="type"/> is <c>null</c></exception>
        public static object IsAssignableFrom(this ArgumentContext<object> argument, Type type, string message = null, string paramName = null) {
            Ensure.NotNull(type, "Type");
            return Ensure.Condition(
                argument.Value,
                a => a.GetType().GetTypeInfo().IsAssignableFrom(type.GetTypeInfo()),
                message ?? $"Exptected that <{argument.Value.GetType().Name}> is assignable from <{type.Name}>",
                paramName);
        }
    }
}
