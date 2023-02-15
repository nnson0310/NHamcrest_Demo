using NHamcrest.NUnit;
using Is = NHamcrest.Is;

namespace NHamcrestDemo.Test
{
    public class AssertNot
    {
        public static void Test()
        {
            string student1 = "David";
            string student2 = "David";

            AssertEx.That(student1, Is.Not(student2), $"{student1} is same as {student2}");
        }
    }
}
