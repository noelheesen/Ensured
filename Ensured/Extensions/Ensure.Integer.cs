namespace Ensured
{
    using System;

    /// <summary>
    /// Exposes number extensions for <see cref="ArgumentContext{T}"/> to ensure conditions.
    /// </summary>
    public static class NumberExtensions
    {
        #region IsPositive

        /// <summary>
        /// Ensures the given <see cref="int"/> value is positive 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="int"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int"/> is not a positive number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static int IsPositive(this ArgumentContext<int> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a > 0,
                message ?? $"Expected <{argument}> to be a positive number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="long"/> value is positive 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="long"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="long"/> is not a positive number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static long IsPositive(this ArgumentContext<long> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a > 0,
                message ?? $"Expected <{argument}> to be a positive number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="double"/> value is positive 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="double"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="double"/> is not a positive number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static double IsPositive(this ArgumentContext<double> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a > 0d,
                message ?? $"Expected <{argument}> to be a positive number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="float"/> value is positive 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="float"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="float"/> is not a positive number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static float IsPositive(this ArgumentContext<float> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a > 0f,
                message ?? $"Expected <{argument}> to be a positive number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="int?"/> value is positive 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="int?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int?"/> is not a positive number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static int? IsPositive(this ArgumentContext<int?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a != null && a > 0,
                message ?? $"Expected <{argument}> to be a positive number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="long?"/> value is positive 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="long?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="long?"/> is not a positive number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static long? IsPositive(this ArgumentContext<long?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a != null && a > 0,
                message ?? $"Expected <{argument}> to be a positive number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="double?"/> value is positive 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="double?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="double?"/> is not a positive number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static double? IsPositive(this ArgumentContext<double?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a != null && a > 0,
                message ?? $"Expected <{argument}> to be a positive number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="float?"/> value is positive 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="float?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="float?"/> is not a positive number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static float? IsPositive(this ArgumentContext<float?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a != null && a > 0f,
                message ?? $"Expected <{argument}> to be a positive number",
                paramName);
        }
        
        #endregion

        #region IsPositiveOrNull

        /// <summary>
        /// Ensures the given <see cref="int?"/> value is positive or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="int?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int?"/> is not <c>null</c> and not a positive number</exception>
        public static int? IsPositiveOrNull(this ArgumentContext<int?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a == null | a > 0,
                message ?? $"Expected <{argument}> to be null or a positive number",
                paramName,
                true);
        }

        /// <summary>
        /// Ensures the given <see cref="long?"/> value is positive or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="long?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int?"/> is not <c>null</c> and not a positive number</exception>
        public static long? IsPositiveOrNull(this ArgumentContext<long?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a == null | a > 0,
                message ?? $"Expected <{argument}> to be null or a positive number",
                paramName,
                true);
        }

        /// <summary>
        /// Ensures the given <see cref="double?"/> value is positive or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="double?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int?"/> is not <c>null</c> and not a positive number</exception>
        public static double? IsPositiveOrNull(this ArgumentContext<double?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a == null | a > 0d,
                message ?? $"Expected <{argument}> to be null or a positive number",
                paramName,
                true);
        }

        /// <summary>
        /// Ensures the given <see cref="float?"/> value is positive or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="float?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int?"/> is not <c>null</c> and not a positive number</exception>
        public static float? IsPositiveOrNull(this ArgumentContext<float?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a == null | a > 0f,
                message ?? $"Expected <{argument}> to be null or a positive number",
                paramName,
                true);
        }

        #endregion

        #region IsNegative

        /// <summary>
        /// Ensures the given <see cref="int"/> value is negative 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="int"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int"/> is not a negative number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static int IsNegative(this ArgumentContext<int> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a < 0,
                message ?? $"Expected <{argument}> to be a negative number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="long"/> value is negative 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="long"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="long"/> is not a negative number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static long IsNegative(this ArgumentContext<long> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a < 0,
                message ?? $"Expected <{argument}> to be a negative number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="double"/> value is negative 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="double"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="double"/> is not a negative number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static double IsNegative(this ArgumentContext<double> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a < 0d,
                message ?? $"Expected <{argument}> to be a negative number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="float"/> value is negative 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="float"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="float"/> is not a negative number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static float IsNegative(this ArgumentContext<float> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a < 0f,
                message ?? $"Expected <{argument}> to be a negative number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="int?"/> value is negative 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="int?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int?"/> is not a negative number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static int? IsNegative(this ArgumentContext<int?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a < 0,
                message ?? $"Expected <{argument}> to be a negative number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="long?"/> value is negative 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="long?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="long?"/> is not a negative number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static long? IsNegative(this ArgumentContext<long?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a < 0,
                message ?? $"Expected <{argument}> to be a negative number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="double?"/> value is negative 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="double?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="double?"/> is not a negative number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static double? IsNegative(this ArgumentContext<double?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a < 0d,
                message ?? $"Expected <{argument}> to be a negative number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="float?"/> value is negative 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="float?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="float?"/> is not a negative number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static float? IsNegative(this ArgumentContext<float?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a < 0f,
                message ?? $"Expected <{argument}> to be a negative number",
                paramName);
        }

        #endregion

        #region IsNegativeOrNull

        /// <summary>
        /// Ensures the given <see cref="int?"/> value is negative or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="int?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int?"/> is not <c>null</c> and not a negative number</exception>
        public static int? IsNegativeOrNull(this ArgumentContext<int?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a == null | a < 0,
                message ?? $"Expected <{argument}> to be null or a negative number",
                paramName,
                true);
        }

        /// <summary>
        /// Ensures the given <see cref="long?"/> value is negative or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="long?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int?"/> is not <c>null</c> and not a negative number</exception>
        public static long? IsNegativeOrNull(this ArgumentContext<long?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a == null | a < 0,
                message ?? $"Expected <{argument}> to be null or a negative number",
                paramName,
                true);
        }

        /// <summary>
        /// Ensures the given <see cref="double?"/> value is negative or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="double?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int?"/> is not <c>null</c> and not a negative number</exception>
        public static double? IsNegativeOrNull(this ArgumentContext<double?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a == null | a < 0d,
                message ?? $"Expected <{argument}> to be null or a negative number",
                paramName,
                true);
        }

        /// <summary>
        /// Ensures the given <see cref="float?"/> value is negative or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="float?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int?"/> is not <c>null</c> and not a negative number</exception>
        public static float? IsNegativeOrNull(this ArgumentContext<float?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a == null | a < 0f,
                message ?? $"Expected <{argument}> to be null or a negative number",
                paramName,
                true);
        }

        #endregion

        #region IsEven

        /// <summary>
        /// Ensures the given <see cref="int"/> value is even 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="int"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int"/> is not an even number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static int IsEven(this ArgumentContext<int> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => (a % 2).Equals(0),
                message ?? $"Expected <{argument}> to be an even number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="long"/> value is even 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="long"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="long"/> is not an even number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static long IsEven(this ArgumentContext<long> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => (a % 2).Equals(0),
                message ?? $"Expected <{argument}> to be an even number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="double"/> value is even 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="double"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="double"/> is not an even number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static double IsEven(this ArgumentContext<double> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => (a % 2d).Equals(0d),
                message ?? $"Expected <{argument}> to be an even number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="float"/> value is even 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="float"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="float"/> is not an even number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static float IsEven(this ArgumentContext<float> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => (a % 2f).Equals(0f),
                message ?? $"Expected <{argument}> to be an even number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="int?"/> value is even 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="int?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int?"/> is not an even number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static int? IsEven(this ArgumentContext<int?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => (a % 2).Equals(0),
                message ?? $"Expected <{argument}> to be an even number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="long?"/> value is even 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="long?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="long?"/> is not an even number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static long? IsEven(this ArgumentContext<long?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => (a % 2).Equals(0),
                message ?? $"Expected <{argument}> to be an even number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="double?"/> value is even 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="double?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="double?"/> is not an even number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static double? IsEven(this ArgumentContext<double?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => (a % 2d).Equals(0d),
                message ?? $"Expected <{argument}> to be an even number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="float?"/> value is even 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="float?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="float?"/> is not an even number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static float? IsEven(this ArgumentContext<float?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => (a % 2f).Equals(0f),
                message ?? $"Expected <{argument}> to be an even number",
                paramName);
        }

        #endregion

        #region IsEvenOrNull

        /// <summary>
        /// Ensures the given <see cref="int?"/> value is even or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="int?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int?"/> is not <c>null</c> and not an even number</exception>
        public static int? IsEvenOrNull(this ArgumentContext<int?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a == null | (a % 2).Equals(0),
                message ?? $"Expected <{argument}> to be an even number or null",
                paramName,
                true);
        }

        /// <summary>
        /// Ensures the given <see cref="long?"/> value is even or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="long?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int?"/> is not <c>null</c> and not an even number</exception>
        public static long? IsEvenOrNull(this ArgumentContext<long?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a == null | (a % 2).Equals(0),
                message ?? $"Expected <{argument}> to be an even number or null",
                paramName,
                true);
        }

        /// <summary>
        /// Ensures the given <see cref="double?"/> value is even or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="double?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int?"/> is not <c>null</c> and not an even number</exception>
        public static double? IsEvenOrNull(this ArgumentContext<double?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a == null | (a % 2d).Equals(0d),
                message ?? $"Expected <{argument}> to be an even number or null",
                paramName,
                true);
        }

        /// <summary>
        /// Ensures the given <see cref="float?"/> value is even or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="float?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int?"/> is not <c>null</c> and not an even number</exception>
        public static float? IsEvenOrNull(this ArgumentContext<float?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a == null | (a % 2f).Equals(0f),
                message ?? $"Expected <{argument}> to be an even number or null",
                paramName,
                true);
        }

        #endregion

        #region IsOdd

        /// <summary>
        /// Ensures the given <see cref="int"/> value is odd 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="int"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int"/> is not an odd number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static int IsOdd(this ArgumentContext<int> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => !(a % 2).Equals(0),
                message ?? $"Expected <{argument}> to be an odd number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="long"/> value is odd 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="long"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="long"/> is not an odd number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static long IsOdd(this ArgumentContext<long> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => !(a % 2).Equals(0),
                message ?? $"Expected <{argument}> to be an odd number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="double"/> value is odd 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="double"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="double"/> is not an odd number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static double IsOdd(this ArgumentContext<double> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => !(a % 2d).Equals(0d),
                message ?? $"Expected <{argument}> to be an odd number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="float"/> value is odd 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="float"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="float"/> is not an odd number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static float IsOdd(this ArgumentContext<float> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => !(a % 2f).Equals(0f),
                message ?? $"Expected <{argument}> to be an odd number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="int?"/> value is odd 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="int?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int?"/> is not an odd number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static int? IsOdd(this ArgumentContext<int?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => !(a % 2).Equals(0),
                message ?? $"Expected <{argument}> to be an odd number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="long?"/> value is odd 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="long?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="long?"/> is not an odd number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static long? IsOdd(this ArgumentContext<long?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => !(a % 2).Equals(0),
                message ?? $"Expected <{argument}> to be an odd number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="double?"/> value is odd 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="double?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="double?"/> is not an odd number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static double? IsOdd(this ArgumentContext<double?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => !(a % 2d).Equals(0d),
                message ?? $"Expected <{argument}> to be an odd number",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="float?"/> value is odd 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="float?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="float?"/> is not an odd number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static float? IsOdd(this ArgumentContext<float?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => !(a % 2f).Equals(0f),
                message ?? $"Expected <{argument}> to be an odd number",
                paramName);
        }

        #endregion

        #region IsOddOrNull

        /// <summary>
        /// Ensures the given <see cref="int?"/> value is odd or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="int?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int?"/> is not <c>null</c> and not an odd number</exception>
        public static int? IsOddOrNull(this ArgumentContext<int?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a == null | !(a % 2).Equals(0),
                message ?? $"Expected <{argument}> to be an odd number or null",
                paramName,
                true);
        }

        /// <summary>
        /// Ensures the given <see cref="long?"/> value is odd or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="long?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int?"/> is not <c>null</c> and not an odd number</exception>
        public static long? IsOddOrNull(this ArgumentContext<long?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a == null | !(a % 2).Equals(0),
                message ?? $"Expected <{argument}> to be an odd number or null",
                paramName,
                true);
        }

        /// <summary>
        /// Ensures the given <see cref="double?"/> value is odd or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="double?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int?"/> is not <c>null</c> and not an odd number</exception>
        public static double? IsOddOrNull(this ArgumentContext<double?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a == null | !(a % 2d).Equals(0d),
                message ?? $"Expected <{argument}> to be an odd number or null",
                paramName,
                true);
        }

        /// <summary>
        /// Ensures the given <see cref="float?"/> value is odd or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="float?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int?"/> is not <c>null</c> and not an odd number</exception>
        public static float? IsOddOrNull(this ArgumentContext<float?> argument, string message = null, string paramName = null) {
            return Ensure.Condition(
                argument.Value,
                a => a == null | !(a % 2f).Equals(0f),
                message ?? $"Expected <{argument}> to be an odd number or null",
                paramName,
                true);
        }

        #endregion

        #region IsPrime

        /// <summary>
        /// Ensures the given <see cref="int"/> value is a prime number 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="int"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int"/> is not a prime number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static int IsPrime(this ArgumentContext<int> argument, string message = null, string paramName = null) {
            //return Ensure.Condition(
            //    argument.Value,
            //    a => int.IsPrime(a),
            //    message ?? $"Expected {argument} to be a prime number",
            //    paramName);

            Ensure.NotNull(argument.Value);

            if (argument.Value <= 1) {
                throw new ArgumentException(message ?? $"Expected <{argument}> to be a prime number", paramName);
            }

            for (int i = 2; i * i <= argument.Value; i++) {
                if ((argument.Value % i).Equals(0)) {
                    throw new ArgumentException(message ?? $"Expected <{argument}> to be a prime number", paramName);
                }
            }

            return argument.Value;
        }

        /// <summary>
        /// Ensures the given <see cref="long"/> value is a prime number 
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="long"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="long"/> is not a prime number</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> is <c>null</c></exception>
        public static long IsPrime(this ArgumentContext<long> argument, string message = null, string paramName = null) {
            //return Ensure.Condition(
            //    argument.Value,
            //    a => int.IsPrime(a),
            //    message ?? $"Expected {argument} to be a prime number",
            //    paramName);

            Ensure.NotNull(argument.Value);

            if (argument.Value <= 1) {
                throw new ArgumentException(message ?? $"Expected <{argument}> to be a prime number", paramName);
            }

            for (int i = 2; i * i <= argument.Value; i++) {
                if ((argument.Value % i).Equals(0)) {
                    throw new ArgumentException(message ?? $"Expected <{argument}> to be a prime number", paramName);
                }
            }

            return argument.Value;
        }

        #endregion

        #region IsMoreThan

        /// <summary>
        /// Ensures the given <see cref="int"/> value is more than <paramref name="minValue"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="minValue"><paramref name="argument.Value"/> must be higher than this value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="int"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int"/> is not more than <paramref name="minValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="minValue"/> is <c>null</c></exception>
        public static int IsMoreThan(this ArgumentContext<int> argument, int minValue, string message = null, string paramName = null) {
            Ensure.NotNull(minValue, "minValue");
            return Ensure.Condition(
                argument.Value,
                a => a > minValue,
                message ?? $"Expected <{argument}> to be a more than <{minValue}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="long"/> value is more than <paramref name="minValue"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="minValue"><paramref name="argument.Value"/> must be higher than this value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="long"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="long"/> is not more than <paramref name="minValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="minValue"/> is <c>null</c></exception>
        public static long IsMoreThan(this ArgumentContext<long> argument, long minValue, string message = null, string paramName = null) {
            Ensure.NotNull(minValue, "minValue");
            return Ensure.Condition(
                argument.Value,
                a => a > minValue,
                message ?? $"Expected <{argument}> to be a more than <{minValue}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="double"/> value is more than <paramref name="minValue"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="minValue"><paramref name="argument.Value"/> must be higher than this value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="double"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="double"/> is not more than <paramref name="minValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="minValue"/> is <c>null</c></exception>
        public static double IsMoreThan(this ArgumentContext<double> argument, double minValue, string message = null, string paramName = null) {
            Ensure.NotNull(minValue, "minValue");
            return Ensure.Condition(
                argument.Value,
                a => a > minValue,
                message ?? $"Expected <{argument}> to be a more than <{minValue}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="float"/> value is more than <paramref name="minValue"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="minValue"><paramref name="argument.Value"/> must be higher than this value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="float"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="float"/> is not more than <paramref name="minValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="minValue"/> is <c>null</c></exception>
        public static float IsMoreThan(this ArgumentContext<float> argument, float minValue, string message = null, string paramName = null) {
            Ensure.NotNull(minValue, "minValue");
            return Ensure.Condition(
                argument.Value,
                a => a > minValue,
                message ?? $"Expected <{argument}> to be a more than <{minValue}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="int?"/> value is more than <paramref name="minValue"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="minValue"><paramref name="argument.Value"/> must be higher than this value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="int?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int?"/> is not more than <paramref name="minValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="minValue"/> is <c>null</c></exception>
        public static int? IsMoreThan(this ArgumentContext<int?> argument, int minValue, string message = null, string paramName = null) {
            Ensure.NotNull(minValue, "minValue");
            return Ensure.Condition(
                argument.Value,
                a => a > minValue,
                message ?? $"Expected <{argument}> to be a more than <{minValue}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="long?"/> value is more than <paramref name="minValue"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="minValue"><paramref name="argument.Value"/> must be higher than this value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="long?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="long?"/> is not more than <paramref name="minValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="minValue"/> is <c>null</c></exception>
        public static long? IsMoreThan(this ArgumentContext<long?> argument, long minValue, string message = null, string paramName = null) {
            Ensure.NotNull(minValue, "minValue");
            return Ensure.Condition(
                argument.Value,
                a => a > minValue,
                message ?? $"Expected <{argument}> to be a more than <{minValue}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="double?"/> value is more than <paramref name="minValue"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="minValue"><paramref name="argument.Value"/> must be higher than this value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="double?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="double?"/> is not more than <paramref name="minValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="minValue"/> is <c>null</c></exception>
        public static double? IsMoreThan(this ArgumentContext<double?> argument, double minValue, string message = null, string paramName = null) {
            Ensure.NotNull(minValue, "minValue");
            return Ensure.Condition(
                argument.Value,
                a => a > minValue,
                message ?? $"Expected <{argument}> to be a more than <{minValue}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="float?"/> value is more than <paramref name="minValue"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="minValue"><paramref name="argument.Value"/> must be higher than this value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="float?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="float?"/> is not more than <paramref name="minValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="minValue"/> is <c>null</c></exception>
        public static float? IsMoreThan(this ArgumentContext<float?> argument, float minValue, string message = null, string paramName = null) {
            Ensure.NotNull(minValue, "minValue");
            return Ensure.Condition(
                argument.Value,
                a => a > minValue,
                message ?? $"Expected <{argument}> to be a more than <{minValue}>",
                paramName);
        }

        #endregion

        #region IsMoreThanOrNull

        /// <summary>
        /// Ensures the given <see cref="int?"/> value is more than <paramref name="minValue"/> or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="minValue"><paramref name="argument.Value"/> must be higher than this value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="int?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int?"/> is not <c>null</c> and not more than <paramref name="minValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="minValue"/> is <c>null</c></exception>
        public static int? IsMoreThanOrNull(this ArgumentContext<int?> argument, int minValue, string message = null, string paramName = null) {
            Ensure.NotNull(minValue, "minValue");
            return Ensure.Condition(
                argument.Value,
                a => a == null | a > minValue,
                message ?? $"Expected <{argument}> to be a more than <{minValue}>",
                paramName,
                true);
        }

        /// <summary>
        /// Ensures the given <see cref="long?"/> value is more than <paramref name="minValue"/> or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="minValue"><paramref name="argument.Value"/> must be higher than this value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="long?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="long?"/> is not <c>null</c> and not more than <paramref name="minValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="minValue"/> is <c>null</c></exception>
        public static long? IsMoreThanOrNull(this ArgumentContext<long?> argument, long minValue, string message = null, string paramName = null) {
            Ensure.NotNull(minValue, "minValue");
            return Ensure.Condition(
                argument.Value,
                a => a == null | a > minValue,
                message ?? $"Expected <{argument}> to be a more than <{minValue}>",
                paramName,
                true);
        }

        /// <summary>
        /// Ensures the given <see cref="double?"/> value is more than <paramref name="minValue"/> or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="minValue"><paramref name="argument.Value"/> must be higher than this value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="double?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="double?"/> is not <c>null</c> and not more than <paramref name="minValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="minValue"/> is <c>null</c></exception>
        public static double? IsMoreThanOrNull(this ArgumentContext<double?> argument, double minValue, string message = null, string paramName = null) {
            Ensure.NotNull(minValue, "minValue");
            return Ensure.Condition(
                argument.Value,
                a => a == null | a > minValue,
                message ?? $"Expected <{argument}> to be a more than <{minValue}>",
                paramName,
                true);
        }

        /// <summary>
        /// Ensures the given <see cref="float?"/> value is more than <paramref name="minValue"/> or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="minValue"><paramref name="argument.Value"/> must be higher than this value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="float?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="float?"/> is not <c>null</c> and not more than <paramref name="minValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="minValue"/> is <c>null</c></exception>
        public static float? IsMoreThanOrNull(this ArgumentContext<float?> argument, float minValue, string message = null, string paramName = null) {
            Ensure.NotNull(minValue, "minValue");
            return Ensure.Condition(
                argument.Value,
                a => a == null | a > minValue,
                message ?? $"Expected <{argument}> to be a more than <{minValue}>",
                paramName,
                true);
        }

        #endregion

        #region IsLessThan

        /// <summary>
        /// Ensures the given <see cref="int"/> value is less than <paramref name="maxValue"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="maxValue"><paramref name="argument.Value"/> must be lower than this value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="int"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int"/> is not less than <paramref name="maxValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="maxValue"/> is <c>null</c></exception>
        public static int IsLessThan(this ArgumentContext<int> argument, int maxValue, string message = null, string paramName = null) {
            Ensure.NotNull(maxValue, "maxValue");
            return Ensure.Condition(
                argument.Value,
                a => a < maxValue,
                message ?? $"Expected <{argument}> to be a less than <{maxValue}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="long"/> value is less than <paramref name="maxValue"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="maxValue"><paramref name="argument.Value"/> must be lower than this value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="long"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="long"/> is not less than <paramref name="maxValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="maxValue"/> is <c>null</c></exception>
        public static long IsLessThan(this ArgumentContext<long> argument, long maxValue, string message = null, string paramName = null) {
            Ensure.NotNull(maxValue, "maxValue");
            return Ensure.Condition(
                argument.Value,
                a => a < maxValue,
                message ?? $"Expected <{argument}> to be a less than <{maxValue}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="double"/> value is less than <paramref name="maxValue"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="maxValue"><paramref name="argument.Value"/> must be lower than this value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="double"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="double"/> is not less than <paramref name="maxValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="maxValue"/> is <c>null</c></exception>
        public static double IsLessThan(this ArgumentContext<double> argument, double maxValue, string message = null, string paramName = null) {
            Ensure.NotNull(maxValue, "maxValue");
            return Ensure.Condition(
                argument.Value,
                a => a < maxValue,
                message ?? $"Expected <{argument}> to be a less than <{maxValue}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="float"/> value is less than <paramref name="maxValue"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="maxValue"><paramref name="argument.Value"/> must be lower than this value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="float"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="float"/> is not less than <paramref name="maxValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="maxValue"/> is <c>null</c></exception>
        public static float IsLessThan(this ArgumentContext<float> argument, float maxValue, string message = null, string paramName = null) {
            Ensure.NotNull(maxValue, "maxValue");
            return Ensure.Condition(
                argument.Value,
                a => a < maxValue,
                message ?? $"Expected <{argument}> to be a less than <{maxValue}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="int?"/> value is less than <paramref name="maxValue"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="maxValue"><paramref name="argument.Value"/> must be lower than this value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="int?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int?"/> is not less than <paramref name="maxValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="maxValue"/> is <c>null</c></exception>
        public static int? IsLessThan(this ArgumentContext<int?> argument, int maxValue, string message = null, string paramName = null) {
            Ensure.NotNull(maxValue, "maxValue");
            return Ensure.Condition(
                argument.Value,
                a => a < maxValue,
                message ?? $"Expected <{argument}> to be a less than <{maxValue}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="long?"/> value is less than <paramref name="maxValue"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="maxValue"><paramref name="argument.Value"/> must be lower than this value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="long?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="long?"/> is not less than <paramref name="maxValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="maxValue"/> is <c>null</c></exception>
        public static long? IsLessThan(this ArgumentContext<long?> argument, long maxValue, string message = null, string paramName = null) {
            Ensure.NotNull(maxValue, "maxValue");
            return Ensure.Condition(
                argument.Value,
                a => a < maxValue,
                message ?? $"Expected <{argument}> to be a less than <{maxValue}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="double?"/> value is less than <paramref name="maxValue"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="maxValue"><paramref name="argument.Value"/> must be lower than this value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="double?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="double?"/> is not less than <paramref name="maxValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="maxValue"/> is <c>null</c></exception>
        public static double? IsLessThan(this ArgumentContext<double?> argument, double maxValue, string message = null, string paramName = null) {
            Ensure.NotNull(maxValue, "maxValue");
            return Ensure.Condition(
                argument.Value,
                a => a < maxValue,
                message ?? $"Expected <{argument}> to be a less than <{maxValue}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="float?"/> value is less than <paramref name="maxValue"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="maxValue"><paramref name="argument.Value"/> must be lower than this value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="float?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="float?"/> is not less than <paramref name="maxValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/> or <paramref name="maxValue"/> is <c>null</c></exception>
        public static float? IsLessThan(this ArgumentContext<float?> argument, float maxValue, string message = null, string paramName = null) {
            Ensure.NotNull(maxValue, "maxValue");
            return Ensure.Condition(
                argument.Value,
                a => a < maxValue,
                message ?? $"Expected <{argument}> to be a less than <{maxValue}>",
                paramName);
        }

        #endregion

        #region IsLessThanOrNull

        /// <summary>
        /// Ensures the given <see cref="int?"/> value is less than <paramref name="maxValue"/> or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="maxValue"><paramref name="argument.Value"/> must be lower than this value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="int?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int?"/> is not <c>null</c> and not less than <paramref name="maxValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="maxValue"/> is <c>null</c></exception>
        public static int? IsLessThanOrNull(this ArgumentContext<int?> argument, int maxValue, string message = null, string paramName = null) {
            Ensure.NotNull(maxValue, "maxValue");
            return Ensure.Condition(
                argument.Value,
                a => a == null | a < maxValue,
                message ?? $"Expected <{argument}> to be a less than <{maxValue}>  or null",
                paramName,
                true);
        }

        /// <summary>
        /// Ensures the given <see cref="long?"/> value is less than <paramref name="maxValue"/> or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="maxValue"><paramref name="argument.Value"/> must be lower than this value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="long?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="long?"/> is not <c>null</c> and not less than <paramref name="maxValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="maxValue"/> is <c>null</c></exception>
        public static long? IsLessThanOrNull(this ArgumentContext<long?> argument, long maxValue, string message = null, string paramName = null) {
            Ensure.NotNull(maxValue, "maxValue");
            return Ensure.Condition(
                argument.Value,
                a => a == null | a < maxValue,
                message ?? $"Expected <{argument}> to be a less than <{maxValue}>  or null",
                paramName,
                true);
        }

        /// <summary>
        /// Ensures the given <see cref="double?"/> value is less than <paramref name="maxValue"/> or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="maxValue"><paramref name="argument.Value"/> must be lower than this value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="double?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="double?"/> is not <c>null</c> and not less than <paramref name="maxValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="maxValue"/> is <c>null</c></exception>
        public static double? IsLessThanOrNull(this ArgumentContext<double?> argument, double maxValue, string message = null, string paramName = null) {
            Ensure.NotNull(maxValue, "maxValue");
            return Ensure.Condition(
                argument.Value,
                a => a == null | a < maxValue,
                message ?? $"Expected <{argument}> to be a less than <{maxValue}>  or null",
                paramName,
                true);
        }

        /// <summary>
        /// Ensures the given <see cref="float?"/> value is less than <paramref name="maxValue"/> or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="maxValue"><paramref name="argument.Value"/> must be lower than this value</param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="float?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="float?"/> is not <c>null</c> and not less than <paramref name="maxValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="maxValue"/> is <c>null</c></exception>
        public static float? IsLessThanOrNull(this ArgumentContext<float?> argument, float maxValue, string message = null, string paramName = null) {
            Ensure.NotNull(maxValue, "maxValue");
            return Ensure.Condition(
                argument.Value,
                a => a == null | a < maxValue,
                message ?? $"Expected <{argument}> to be a less than <{maxValue}> or null",
                paramName,
                true);
        }

        #endregion

        #region IsInRange

        /// <summary>
        /// Ensures the given <see cref="int"/> value is in range of <paramref name="minValue"/> and <paramref name="maxValue"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="minValue">The minimal value of <paramref name="argument.Value"/></param>
        /// <param name="maxValue">The maximum value of <paramref name="argument.Value"/></param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="int"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int"/> is not within range of <paramref name="minValue"/> and <paramref name="maxValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/>, <paramref name="minValue"/> or <paramref name="maxValue"/> is <c>null</c></exception>
        public static int IsInRange(this ArgumentContext<int> argument, int minValue, int maxValue, string message = null, string paramName = null) {
            Ensure.NotNull(minValue, "minValue");
            Ensure.NotNull(maxValue, "maxValue");
            return Ensure.Condition(
                argument.Value,
                a => a > minValue && a < maxValue,
                message ?? $"Expected <{argument}> to be in range of <{minValue}> and <{maxValue}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="long"/> value is in range of <paramref name="minValue"/> and <paramref name="maxValue"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="minValue">The minimal value of <paramref name="argument.Value"/></param>
        /// <param name="maxValue">The maximum value of <paramref name="argument.Value"/></param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="long"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="long"/> is not within range of <paramref name="minValue"/> and <paramref name="maxValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/>, <paramref name="minValue"/> or <paramref name="maxValue"/> is <c>null</c></exception>
        public static long IsInRange(this ArgumentContext<long> argument, long minValue, long maxValue, string message = null, string paramName = null) {
            Ensure.NotNull(minValue, "minValue");
            Ensure.NotNull(maxValue, "maxValue");
            return Ensure.Condition(
                argument.Value,
                a => a > minValue && a < maxValue,
                message ?? $"Expected <{argument}> to be in range of <{minValue}> and <{maxValue}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="double"/> value is in range of <paramref name="minValue"/> and <paramref name="maxValue"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="minValue">The minimal value of <paramref name="argument.Value"/></param>
        /// <param name="maxValue">The maximum value of <paramref name="argument.Value"/></param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="double"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="double"/> is not within range of <paramref name="minValue"/> and <paramref name="maxValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/>, <paramref name="minValue"/> or <paramref name="maxValue"/> is <c>null</c></exception>
        public static double IsInRange(this ArgumentContext<double> argument, double minValue, double maxValue, string message = null, string paramName = null) {
            Ensure.NotNull(minValue, "minValue");
            Ensure.NotNull(maxValue, "maxValue");
            return Ensure.Condition(
                argument.Value,
                a => a > minValue && a < maxValue,
                message ?? $"Expected <{argument}> to be in range of <{minValue}> and <{maxValue}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="float"/> value is in range of <paramref name="minValue"/> and <paramref name="maxValue"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="minValue">The minimal value of <paramref name="argument.Value"/></param>
        /// <param name="maxValue">The maximum value of <paramref name="argument.Value"/></param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="float"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="float"/> is not within range of <paramref name="minValue"/> and <paramref name="maxValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/>, <paramref name="minValue"/> or <paramref name="maxValue"/> is <c>null</c></exception>
        public static float IsInRange(this ArgumentContext<float> argument, float minValue, long maxValue, string message = null, string paramName = null) {
            Ensure.NotNull(minValue, "minValue");
            Ensure.NotNull(maxValue, "maxValue");
            return Ensure.Condition(
                argument.Value,
                a => a > minValue && a < maxValue,
                message ?? $"Expected <{argument}> to be in range of <{minValue}> and <{maxValue}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="int?"/> value is in range of <paramref name="minValue"/> and <paramref name="maxValue"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="minValue">The minimal value of <paramref name="argument.Value"/></param>
        /// <param name="maxValue">The maximum value of <paramref name="argument.Value"/></param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="int?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int?"/> is not within range of <paramref name="minValue"/> and <paramref name="maxValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/>, <paramref name="minValue"/> or <paramref name="maxValue"/> is <c>null</c></exception>
        public static int? IsInRange(this ArgumentContext<int?> argument, int minValue, int maxValue, string message = null, string paramName = null) {
            Ensure.NotNull(minValue, "minValue");
            Ensure.NotNull(maxValue, "maxValue");
            return Ensure.Condition(
                argument.Value,
                a => a > minValue && a < maxValue,
                message ?? $"Expected <{argument}> to be in range of <{minValue}> and <{maxValue}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="long?"/> value is in range of <paramref name="minValue"/> and <paramref name="maxValue"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="minValue">The minimal value of <paramref name="argument.Value"/></param>
        /// <param name="maxValue">The maximum value of <paramref name="argument.Value"/></param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="long?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="long?"/> is not within range of <paramref name="minValue"/> and <paramref name="maxValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/>, <paramref name="minValue"/> or <paramref name="maxValue"/> is <c>null</c></exception>
        public static long? IsInRange(this ArgumentContext<long?> argument, long minValue, long maxValue, string message = null, string paramName = null) {
            Ensure.NotNull(minValue, "minValue");
            Ensure.NotNull(maxValue, "maxValue");
            return Ensure.Condition(
                argument.Value,
                a => a > minValue && a < maxValue,
                message ?? $"Expected <{argument}> to be in range of <{minValue}> and <{maxValue}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="double?"/> value is in range of <paramref name="minValue"/> and <paramref name="maxValue"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="minValue">The minimal value of <paramref name="argument.Value"/></param>
        /// <param name="maxValue">The maximum value of <paramref name="argument.Value"/></param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="double?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="double?"/> is not within range of <paramref name="minValue"/> and <paramref name="maxValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/>, <paramref name="minValue"/> or <paramref name="maxValue"/> is <c>null</c></exception>
        public static double? IsInRange(this ArgumentContext<double?> argument, double minValue, double maxValue, string message = null, string paramName = null) {
            Ensure.NotNull(minValue, "minValue");
            Ensure.NotNull(maxValue, "maxValue");
            return Ensure.Condition(
                argument.Value,
                a => a > minValue && a < maxValue,
                message ?? $"Expected <{argument}> to be in range of <{minValue}> and <{maxValue}>",
                paramName);
        }

        /// <summary>
        /// Ensures the given <see cref="float?"/> value is in range of <paramref name="minValue"/> and <paramref name="maxValue"/>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="minValue">The minimal value of <paramref name="argument.Value"/></param>
        /// <param name="maxValue">The maximum value of <paramref name="argument.Value"/></param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="float?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="float?"/> is not within range of <paramref name="minValue"/> and <paramref name="maxValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="argument.Value"/>, <paramref name="minValue"/> or <paramref name="maxValue"/> is <c>null</c></exception>
        public static float? IsInRange(this ArgumentContext<float?> argument, float minValue, float maxValue, string message = null, string paramName = null) {
            Ensure.NotNull(minValue, "minValue");
            Ensure.NotNull(maxValue, "maxValue");
            return Ensure.Condition(
                argument.Value,
                a => a > minValue && a < maxValue,
                message ?? $"Expected <{argument}> to be in range of <{minValue}> and <{maxValue}>",
                paramName);
        }

        #endregion

        #region IsInRangeOrNull

        /// <summary>
        /// Ensures the given <see cref="int?"/> value is in range of <paramref name="minValue"/> and <paramref name="maxValue"/> or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="minValue">The minimal value of <paramref name="argument.Value"/></param>
        /// <param name="maxValue">The maximum value of <paramref name="argument.Value"/></param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="int?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="int?"/> is not <c>null</c> and not within range of <paramref name="minValue"/> and <paramref name="maxValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="minValue"/> or <paramref name="maxValue"/> is <c>null</c></exception>
        public static int? IsInRangeOrNull(this ArgumentContext<int?> argument, int minValue, int maxValue, string message = null, string paramName = null) {
            Ensure.NotNull(minValue, "minValue");
            Ensure.NotNull(maxValue, "maxValue");
            return Ensure.Condition(
                argument.Value,
                a => a == null | (a > minValue && a < maxValue),
                message ?? $"Expected <{argument}> to be in range of <{minValue}> and <{maxValue}>  or null",
                paramName,
                true);
        }

        /// <summary>
        /// Ensures the given <see cref="long?"/> value is in range of <paramref name="minValue"/> and <paramref name="maxValue"/> or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="minValue">The minimal value of <paramref name="argument.Value"/></param>
        /// <param name="maxValue">The maximum value of <paramref name="argument.Value"/></param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="long?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="long?"/> is not <c>null</c> and not within range of <paramref name="minValue"/> and <paramref name="maxValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="minValue"/> or <paramref name="maxValue"/> is <c>null</c></exception>
        public static long? IsInRangeOrNull(this ArgumentContext<long?> argument, long minValue, long maxValue, string message = null, string paramName = null) {
            Ensure.NotNull(minValue, "minValue");
            Ensure.NotNull(maxValue, "maxValue");
            return Ensure.Condition(
                argument.Value,
                a => a == null | (a > minValue && a < maxValue),
                message ?? $"Expected <{argument}> to be in range of <{minValue}> and <{maxValue}>  or null",
                paramName,
                true);
        }

        /// <summary>
        /// Ensures the given <see cref="double?"/> value is in range of <paramref name="minValue"/> and <paramref name="maxValue"/> or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="minValue">The minimal value of <paramref name="argument.Value"/></param>
        /// <param name="maxValue">The maximum value of <paramref name="argument.Value"/></param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="double?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="double?"/> is not <c>null</c> and not within range of <paramref name="minValue"/> and <paramref name="maxValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="minValue"/> or <paramref name="maxValue"/> is <c>null</c></exception>
        public static double? IsInRangeOrNull(this ArgumentContext<double?> argument, double minValue, double maxValue, string message = null, string paramName = null) {
            Ensure.NotNull(minValue, "minValue");
            Ensure.NotNull(maxValue, "maxValue");
            return Ensure.Condition(
                argument.Value,
                a => a == null | (a > minValue && a < maxValue),
                message ?? $"Expected <{argument}> to be in range of <{minValue}> and <{maxValue}>  or null",
                paramName,
                true);
        }

        /// <summary>
        /// Ensures the given <see cref="float?"/> value is in range of <paramref name="minValue"/> and <paramref name="maxValue"/> or <c>null</c>
        /// </summary>
        /// <param name="argument">The context describing the value</param>
        /// <param name="minValue">The minimal value of <paramref name="argument.Value"/></param>
        /// <param name="maxValue">The maximum value of <paramref name="argument.Value"/></param>
        /// <param name="message">An optional message to use when validation fails</param>
        /// <param name="paramName">An optional parameter name to use when validation fails</param>
        /// <returns>The given <see cref="float?"/> if validation passes</returns>
        /// <exception cref="ArgumentException">If the given <see cref="float?"/> is not <c>null</c> and not within range of <paramref name="minValue"/> and <paramref name="maxValue"/></exception>
        /// <exception cref="ArgumentNullException">If <paramref name="minValue"/> or <paramref name="maxValue"/> is <c>null</c></exception>
        public static float? IsInRangeOrNull(this ArgumentContext<float?> argument, float minValue, float maxValue, string message = null, string paramName = null) {
            Ensure.NotNull(minValue, "minValue");
            Ensure.NotNull(maxValue, "maxValue");
            return Ensure.Condition(
                argument.Value,
                a => a == null | (a > minValue && a < maxValue),
                message ?? $"Expected <{argument}> to be in range of <{minValue}> and <{maxValue}> or null",
                paramName,
                true);
        }

        #endregion
    }
}
