using NHamcrest;
using NHamcrest.NUnit;

namespace NHamcrestDemo.Test
{
    public class AssertInstanceOf
    {
        public static void Test()
        {
            Police police = new Police();
            AssertEx.That(police, Is.InstanceOf<Police>());

            Killer killer = new Killer();
            AssertEx.That(killer, Is.InstanceOf<Killer>());
        }

        private class Police { };

        private class Killer { };
    }

}
