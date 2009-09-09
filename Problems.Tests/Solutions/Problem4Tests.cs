using NUnit.Framework;
using Problems.Solutions;


namespace Problems.Tests.Solutions
{
    [TestFixture]
    public class Problem4Tests
    {
        [TestCase((byte)0, 0L)] // 0 = 0 * 0
        [TestCase((byte)1, 9L)] // 0 = 0 * 0
        [TestCase((byte)2, 9009L)] // 9009 = 91  99
        [TestCase((byte)3, 906609)] // 
        public void VariousExamples(byte digits, long result)
        {
            Assert.AreEqual(result, Problem4.GetLargestPalindromeMadeFromAProductOf(digits));
        }
    }
}