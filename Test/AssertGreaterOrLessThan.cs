using NHamcrest.NUnit;
using Is = NHamcrest.Is;

namespace NHamcrestDemo.Test
{
    public class AssertGreaterOrLessThan
    {
        public static void assertGreaterOrLessThan()
        {
            int a = 5;
            int b = 6;

            AssertEx.That(a, Is.GreaterThan(b), $"{a} is not greater than {b}");

            string str1 = "maria";
            string str2 = "robert";

            AssertEx.That(str1, Is.LessThan(str2), $"{str1} is not less than {str2}");

            int c = 4;
            int d = 5;

            AssertEx.That(c, Is.GreaterThanOrEqualTo(d), $"{c} is not greater than or equal to {d}");

            int e = 6;
            int f = 5;

            AssertEx.That(e, Is.LessThanOrEqualTo(f), $"{e} is not less than or equal to {f}");
        }
    }
}

