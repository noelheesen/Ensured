namespace Ensured.Tests
{
    using System;
    using System.Linq.Expressions;

    public partial class EnsureTests
    {
        static object testObj = new object();
        static object nullObj = null;

        static string customParamName = "nullobject";
        static string customMessage = "Value can not not be null";

        static Expression<Func<object>> nullExpression = null;

        static Expression<Func<object, bool>> nullCondition = null;
        static Expression<Func<object, bool>> trueCondition = input => true;
        static Expression<Func<object, bool>> falseCondition = input => false;
    }
}
