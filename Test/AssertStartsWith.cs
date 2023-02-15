using NHamcrest;
using NHamcrest.NUnit;

namespace NHamcrestDemo.Test
{
    public class AssertStartsWith
    {
        public static void Test()
        {
            string myName = "tomatoQA";

            string start = "Toms";

            AssertEx.That(myName, Starts.With(start).CaseInsensitive(), $"{myName} does not start with {start}");
        }
    }
}

