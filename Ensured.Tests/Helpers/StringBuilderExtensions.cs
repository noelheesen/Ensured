namespace Ensured.Tests.Helpers
{
    using Shouldly;
    using System.Text;
    using System.Runtime.CompilerServices;

    public static class StringBuilderExtensions
    {
        public static void WhereAmI(this StringBuilder sb, [CallerMemberName] string method = null)
        {
            sb.AppendLine(method);
        }

        public static void ShouldHaveLines(this StringBuilder sb, params string[] expected)
        {
            var expectation = new StringBuilder();

            foreach (var line in expected)
                expectation.AppendLine(line);

            sb.ToString().ShouldBe(expectation.ToString());
        }
    }
}
