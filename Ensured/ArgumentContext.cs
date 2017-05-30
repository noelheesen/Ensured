namespace Ensured
{
    using System;
    using System.Collections;
    using System.Linq.Expressions;

    /// <summary>
    /// The context in which the argument is validated.
    /// </summary>
    /// <typeparam name="T">The <see cref="Type"/> of the argument that requires validation</typeparam>
    public sealed class ArgumentContext<T>
    {
        #region Fields

        private readonly T _value;
        private readonly string _paramName;

        #endregion

        #region Constructors

        /// <summary>
        /// Construct a context based upon the <paramref name="expression"/> passed in.
        /// </summary>
        /// <remarks>
        /// The context will extract the <see cref="_paramName"/> from the expression and use it in case none is provided later
        /// </remarks>
        /// <param name="expression">An <see cref="Expression"/> that returns a value to validate</param>
        internal ArgumentContext(Expression<Func<T>> expression) {

            this._value = expression.Compile().Invoke();

            if (!Equals(expression, null)) {
                this._paramName = ((MemberExpression)expression.Body).Member.Name;
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the value to validate
        /// </summary>
        public T Value {
            get {
                return this._value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// overriden to return <see cref="Value"/> instead of itself
        /// </summary>
        /// <returns><see cref="Value"/></returns>
        public override string ToString() {
            return this._value.ToString();
        }

        #endregion

    }
}
