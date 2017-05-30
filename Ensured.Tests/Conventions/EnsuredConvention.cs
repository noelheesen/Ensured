using Ensured.Tests.Attributes;
using Fixie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Ensured.Tests.Conventions
{
    public class EnsuredConvention : Convention
    {
        public EnsuredConvention() {

            Classes
                .NameEndsWith("Tests");

            Methods
                .Where(method => method.IsVoid());

            Parameters
                .Add<TestCaseAttributeParameterSource>()
                .Add<TestCaseSourceAttributeParameterSource>();

            ClassExecution
                .CreateInstancePerClass();
                //.SortCases((caseA, caseB) => String.Compare(caseA.Name, caseB.Name, StringComparison.Ordinal));
        }

        class TestCaseAttributeParameterSource : ParameterSource
        {
            public IEnumerable<object[]> GetParameters(MethodInfo method)
            {
                return method.GetCustomAttributes<TestCaseAttribute>(true).Select(input => input.Parameters);
            }
        }

        class TestCaseSourceAttributeParameterSource : ParameterSource
        {
            public IEnumerable<object[]> GetParameters(MethodInfo method)
            {
                var testInvocations = new List<object[]>();
                var testCaseSourceAttributes = method.GetCustomAttributes<TestCaseSourceAttribute>(true).ToList();

                foreach (var attribute in testCaseSourceAttributes)
                {
                    var sourceType = attribute.SourceType ?? method.ReflectedType;
                    if (sourceType == null)
                        throw new Exception($"Could not find source type for method: {method.Name}");

                    var members = sourceType.GetMember(attribute.SourceName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
                    if (!Equals(members.Length, 1))
                        throw new Exception($"Found {members.Length} members named '{attribute.SourceName}' on type {sourceType}");

                    var member = members.Single();
                    testInvocations.AddRange(InvocationsForTestCaseSource(member));
                }

                return testInvocations;
            }
        }

        private static IEnumerable<object[]> InvocationsForTestCaseSource(MemberInfo member)
        {
            var field = member as FieldInfo;
            if (!Equals(field, null) && field.IsStatic)
                return (IEnumerable<object[]>)field.GetValue(null);

            var property = member as PropertyInfo;
            if (!Equals(property, null) && property.GetGetMethod(true).IsStatic)
                return (IEnumerable<object[]>)property.GetValue(null, null);

            var method = member as MethodInfo;
            if (!Equals(method, null) && method.IsStatic)
                return (IEnumerable<object[]>)method.Invoke(null, null);

            throw new Exception($"Member {member.Name} must be static in order to use it with TestCaseSource");
        }
    }
}
