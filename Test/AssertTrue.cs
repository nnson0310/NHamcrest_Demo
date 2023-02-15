using NHamcrest.NUnit;
using Is = NHamcrest.Is;

namespace NHamcrestDemo.Test
{
    public class AssertTrue
    {
        public static void Test()
        {
            string myName = "tomatoQA";

            AssertEx.That(myName, Is.EqualTo("tomatoQAs"), $"{myName} is not equal to 'tomatoQA'");
        }
    }
}

