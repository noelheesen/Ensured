namespace Ensured
{
    using System;
    using System.Linq.Expressions;

    /// <summary>
    /// Exposes methods to validate values
    /// </summary>
    /// <remarks>
    /// The only public class for the API.
    /// </remarks>
    public static class Ensure
    {
        /// <summary>
        /// This method provides a context on which validation can be performed
        /// </summary>
        /// <remarks>
        /// This method creates an expression from the given <paramref name="value"/> and calls <see cref="That{T}(Expression{Func{T}})"/> internally
        /// </remarks>
        /// <typeparam name="T">The <see cref="Type"/> of the <paramref name="value"/></typeparam>
        /// <param name="value">The value to validate</param>
        /// <returns>An <see cref="ArgumentContext{T}"/> that contains information about the <paramref name="value"/></returns>
        public static ArgumentContext<T> That<T>(T value) {
            return Ensure.That<T>(() => value);
        }

        /// <summary>
        /// This method provides a context on which validation can be performed
        /// </summary>
        /// <typeparam name="T">The <see cref="Type"/> of the value that the <paramref name="expression"/> returns</typeparam>
        /// <param name="expression">An <see cref="Expression"/> that returns a value to validate</param>
        /// <returns>An <see cref="ArgumentContext{T}"/> that contains information about the <paramref name="value"/></returns>
        public static ArgumentContext<T> That<T>(Expression<Func<T>> expression) {
            return new ArgumentContext<T>(expression);
        }

        /// <summary>
        /// Ensures the given <paramref name="value"/> is not <c>null</c> without creating an <see cref="ArgumentContext{T}"/>
        /// </summary>
        /// <remarks>
        /// Calls <see cref="NotNull{T}(Expression{Func{T}}, string, string)"/> internally
        /// An optional <paramref name="paramName"/> and <paramref name="message"/> can be provided
        /// If not specified the <paramref name="paramName"/> will be extracted from the created expression and use the default message of the <see cref="ArgumentNullException"/>
        /// </remarks>
        /// <typeparam name="T">The <see cref="Type"/> of the <paramref name="value"/></typeparam>
        /// <param name="value">The value to validate</param>
        /// <param name="paramName">An optional custom parameter name for the <see cref="ArgumentNullException"/></param>
        /// <param name="message">An optional custom message for the <see cref="ArgumentNullException"/></param>
        /// <returns>The <paramref name="value"/> if it passes validation</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="value"/> is <c>null</c></exception>
        public static T NotNull<T>(T value, string paramName = null, string message = null) {
            return Ensure.NotNull(() => value, paramName, message);
        }

        /// <summary>
        /// Ensures the value returned by the expression is not <c>null</c> without creating an <see cref="ArgumentContext{T}"/>
        /// </summary>
        /// <remarks>
        /// An optional <paramref name="paramName"/> and <paramref name="message"/> can be provided
        /// If not specified the <paramref name="paramName"/> will be extracted from the <paramref name="expression"/> and use the default message of the <see cref="ArgumentNullException"/>
        /// </remarks>
        /// <typeparam name="T">The <see cref="Type"/> of the value that the <paramref name="expression"/> returns</typeparam>
        /// <param name="expression">An <see cref="Expression"/> that returns a value to validate</param>
        /// <param name="paramName">An optional custom parameter name for the <see cref="ArgumentNullException"/></param>
        /// <param name="message">An optional custom message for the <see cref="ArgumentNullException"/></param>
        /// <returns>The value that the <paramref name="expression"/> returns if validation is passed</returns>
        /// <exception cref="ArgumentNullException">If the value returned from the <paramref name="expression"/> is or compiled to <c>null</c> </exception>
        public static T NotNull<T>(Expression<Func<T>> expression, string paramName = null, string message = null) {

            if (Equals(expression, null))
                throw new ArgumentNullException("expression");

            var value = expression.Compile().Invoke();
            var name = paramName ?? ((MemberExpression)expression.Body).Member.Name;

            if (Equals(value, null)) {
                if (Equals(message, null)) {
                    throw new ArgumentNullException(name);
                } else {
                    throw new ArgumentNullException(name, message);
                }
            }

            return value;
        }

        /// <summary>
        /// Ensures the given <paramref name="condition"/> results to <c>true</c> when passing in the given <paramref name="value"/>
        /// </summary>
        /// <remarks>
        /// An optional <paramref name="paramName"/> and <paramref name="message"/> can be provided
        /// If not specified the <paramref name="paramName"/> will be extracted and use the default message of the <see cref="ArgumentException"/>
        /// </remarks>
        /// <typeparam name="T">The <see cref="Type"/> of the <paramref name="value"/></typeparam>
        /// <param name="value">The value to validate</param>
        /// <param name="condition">The condition to use when validating the value</param>
        /// <param name="message">An optional custom message for the <see cref="ArgumentException"/></param>
        /// <param name="paramName">An optional custom parameter name for the <see cref="ArgumentException"/></param>
        /// <returns>The <paramref name="value"/> if it passes validation</returns>
        /// <exception cref="ArgumentException">If the <paramref name="value"/> does not pass validation</exception>
        /// <exception cref="ArgumentNullException">If the <paramref name="value"/> or <paramref name="condition"/> is <c>null</c></exception>
        public static T Condition<T>(T value, Expression<Func<T, bool>> condition, string message = null, string paramName = null, bool allowNull = false) {
            Ensure.NotNull(condition);

            if (!allowNull)
                Ensure.NotNull(value);

            if (!condition.Compile()(value)) {
                if (Equals(paramName, null)) {
                    throw new ArgumentException(message ?? $"{value} does not pass {condition}");
                } else {
                    throw new ArgumentException(message ?? $"{value} does not pass {condition}", paramName);
                }
            }
            return value;
        }

        /// <summary>
        /// Ensures the given <paramref name="condition"/> results to <c>true</c> when passing in the value of the given <paramref name="expression"/>
        /// </summary>
        /// <remarks>
        /// An optional <paramref name="paramName"/> and <paramref name="message"/> can be provided
        /// If not specified the <paramref name="paramName"/> will be extracted and use the default message of the <see cref="ArgumentException"/>
        /// </remarks>
        /// <typeparam name="T">The <see cref="Type"/> of the value that the <paramref name="expression"/> returns</typeparam>
        /// <param name="expression">An <see cref="Expression"/> that returns a value to validate</param>
        /// <param name="condition">The condition to use when validating the value</param>
        /// <param name="paramName">An optional custom message for the <see cref="ArgumentException"/></param>
        /// <param name="message">An optional custom parameter name for the <see cref="ArgumentException"/></param>
        /// <returns>The value that the <paramref name="expression"/> returns if validation is passed</returns>
        /// <exception cref="ArgumentException">If the value returned from the <paramref name="expression"/> does not pass validation</exception>
        /// <exception cref="ArgumentNullException">If the <paramref name="expression"/> or <paramref name="condition"/> is <c>null</c></exception>
        public static T Condition<T>(Expression<Func<T>> expression, Expression<Func<T, bool>> condition, string message = null, string paramName = null, bool allowNull = false) {

            if (Equals(expression, null))
                throw new ArgumentNullException("expression");

            var value = expression.Compile().Invoke();
            var name = paramName ?? ((MemberExpression)expression.Body).Member.Name;

            return Ensure.Condition(value, condition, message, name, allowNull);
        }
    }
}
