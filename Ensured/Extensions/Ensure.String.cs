namespace Ensured.Extensions
{
    using System;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Exposes <see cref="string"/> extensions for <see cref="ArgumentContext{T}"/>
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Ensures the given <see cref="string"/> value is is not empty
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="string"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="string"/> is empty</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static string IsNotEmpty(this ArgumentContext<string> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => !string.IsNullOrEmpty(a),
                message ?? $"Expected <{argument}> to have length.",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="string"/> value is not a whitespace 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="string"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="string"/> is <c>null</c> or a whitespace</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static string IsNotNullOrWhiteSpace(this ArgumentContext<string> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => !string.IsNullOrWhiteSpace(a),
                message ?? $"Expected <{argument}> to have length.",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="string"/> value starts with <paramref name="value"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="value"></param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="string"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="string"/> does not start with <paramref name="value"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="value"/> is <c>null</c></exception>
        public static string StartsWith(this ArgumentContext<string> argument, string value, string message = null, string paramName = null) {
            Ensure.NotNull(value, "Value");
            return Ensure.Condition(
                argument.Value,
                a => a.StartsWith(value),
                message ?? $"Expected <{argument}> to start with <{value}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="string"/> value ends with <paramref name="value"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="value"></param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="string"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="string"/> does not end with <paramref name="value"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="value"/> is <c>null</c></exception>
        public static string EndsWith(this ArgumentContext<string> argument, string value, string message = null, string paramName = null) {
            Ensure.NotNull(value, "Value");
            return Ensure.Condition(
                argument.Value,
                a => a.EndsWith(value),
                message ?? $"Expected <{argument}> to end with <{value}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="string"/> value contains <paramref name="value"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="value"></param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="string"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="string"/> does not contain <paramref name="value"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="value"/> is <c>null</c></exception>
        public static string Contains(this ArgumentContext<string> argument, string value, string message = null, string paramName = null) {
            Ensure.NotNull(value, "Value");
            return Ensure.Condition(
                argument.Value,
                a => a.Contains(value),
                message ?? $"Expected <{argument}> to contain <{value}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="string"/> value does not contain <paramref name="value"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="value"></param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="string"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="string"/> contains <paramref name="value"/> </exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="value"/> is <c>null</c></exception>
        public static string DoesNotContain(this ArgumentContext<string> argument, string value, string message = null, string paramName = null) {
            Ensure.NotNull(value, "Value");
            return Ensure.Condition(
                argument.Value,
                a => !a.Contains(value),
                message ?? $"Expected <{argument}> not to contain <{value}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="string"/> value is an <see cref="int"/> 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="string"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="string"/> is not a number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static string IsNumber(this ArgumentContext<string> argument, string message = null, string paramName = null) {
            int result;
            return Ensure.Condition(
                argument.Value,
                a => int.TryParse(a, out result),
                $"Expected <{argument}> to be a number.",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="string"/> value matches the <see cref="Regex"/> <paramref name="pattern"/> 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="pattern"></param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="string"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="string"/> does not match <paramref name="pattern"/> </exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="pattern"/> is <c>null</c></exception>
        public static string IsMatch(this ArgumentContext<string> argument, string pattern, string message = null, string paramName = null) {
            Ensure.NotNull(pattern, "Pattern");
            return Ensure.Condition(
                argument.Value,
                a => Regex.IsMatch(a, pattern),
                message ?? $"Expected <{argument}> to match <{pattern}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="string"/> value is <paramref name="length"/> long.
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="length"></param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="string"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="string"/> length differs from <paramref name="length"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="length"/> is <c>null</c></exception>
        public static string Length(this ArgumentContext<string> argument, int length, string message = null, string paramName = null) {
            Ensure.NotNull(length, "Length");
            return Ensure.Condition(
                argument.Value,
                a => a.Length.Equals(length),
                message ?? $"Expected length of <{argument}> is <{length}>.",
                paramName);
        }
    }
}
