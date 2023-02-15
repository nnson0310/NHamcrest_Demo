using NHamcrest.NUnit;
using Is = NHamcrest.Is;

namespace NHamcrestDemo.Test
{
    public class AssertEqual
    {
        public static void Test()
        {
            bool statement = 2 > 3;
            AssertEx.That(statement, Is.True(), $"This statement is {statement}");
        }
    }
}
