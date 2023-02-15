using NHamcrest;
using NHamcrest.NUnit;

namespace NHamcrestDemo.Test
{
    public class AssertContains
    {
        public static void Test()
        {
            string actual = "Maria Ozawa";
            string expected = "marias";
            AssertEx.That(actual, Contains.String(expected).CaseInsensitive(), $"{actual} does not contain {expected}");
        }
    }

}
