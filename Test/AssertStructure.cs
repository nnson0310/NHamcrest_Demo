using NHamcrest;
using NHamcrest.NUnit;

namespace NHamcrestDemo.Test
{
    public class AssertStructure
    {
        public static void Test()
        {
            List<int> groupA = new List<int>();
            groupA.Add(1000);
            groupA.Add(200);
            groupA.Add(145);

            List<int> groupB = new List<int>();
            groupB.Add(999);
            groupB.Add(200);
            groupB.Add(145);

            AssertEx.That(groupA, Is.StructurallyEqualTo(groupB));
        }
    }

}
