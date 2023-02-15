using NHamcrest;
using NHamcrest.NUnit;

namespace NHamcrestDemo.Test
{
    public class AssertNull
    {
        public static void Test()
        {
            string name = null;

            AssertEx.That(name, Is.Null(), $"{name} is not null");

            string student = "Huong";

            AssertEx.That(name, Is.NotNull(), $"{name} is null");

        }
    }
}
