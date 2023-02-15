using NHamcrest;
using NHamcrest.NUnit;

namespace NHamcrestDemo.Test
{
    public class AssertSameAs
    {
        public static void Test()
        {
            Police police = new Police();

            AssertEx.That(police, Is.SameAs<Police>(police));
        }

        private class Police { };
    }

}
