using NHamcrest;
using NHamcrest.NUnit;

namespace NHamcrestDemo.Test
{
    public class AssertEndsWith
    {
        public static void Test()
        {
            string myName = "tomatoQA";

            string end = "qAs";

            AssertEx.That(myName, Ends.With(end).CaseInsensitive(), $"{myName} does not end with {end}");
        }
    }
}

