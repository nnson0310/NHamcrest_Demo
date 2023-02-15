using NHamcrest;
using NHamcrest.NUnit;

namespace NHamcrestDemo.Test
{
    public class AssertCollection
    {
        public static void Test()
        {
            List<int> numbers = new List<int>();
            numbers.Add(1000);
            numbers.Add(200);
            numbers.Add(145);

            AssertEx.That(numbers, Has.Item(Is.LessThanOrEqualTo(100)));
        }
    }

}
