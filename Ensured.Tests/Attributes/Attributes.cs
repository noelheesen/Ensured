using System;

namespace Ensured.Tests.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class TestCaseAttribute : Attribute
    {
        public TestCaseAttribute(params object[] parameters)
        {
            this.Parameters = parameters;
        }

        public object[] Parameters { get; private set; }
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class TestCaseSourceAttribute : Attribute
    {
        public TestCaseSourceAttribute(string sourceName) : this(sourceName, null)
        {
        }

        public TestCaseSourceAttribute(string sourceName, Type sourceType)
        {
            this.SourceName = sourceName;
            this.SourceType = sourceType;
        }

        public Type SourceType { get; set; }
        public string SourceName { get; private set; }
    } 
}
