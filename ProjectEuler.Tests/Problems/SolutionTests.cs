using System;
using System.Linq;
using NUnit.Framework;
using ProjectEuler.Problems;


namespace ProjectEuler.Tests.Problems
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        public void WorksAsExpected()
        {
            var s = new Solution<int>(() => 7, "Test");
            
            Assert.That(s.Note, Is.EqualTo("Test"));
            Assert.That(s.GetAnswer(), Is.EqualTo(7));
            Assert.That((s as ISolution).GetAnswer(), Is.EqualTo(7));
        }
    }
}