using NHamcrest;
using NHamcrest.NUnit;

namespace NHamcrestDemo.Test
{
    public class AssertEvery
    {
        public static void Test()
        {
            string[] studentNames = new string[] { "Maria", "Maxuma", "Martha", "Marxi" };
            string subStr = "mar";

            AssertEx.That(studentNames, Every.Item(Contains.String(subStr).CaseInsensitive()), $"{studentNames} does not contain {subStr}");
        }
    }

}

