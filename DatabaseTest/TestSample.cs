using System;
using NUnit.Framework;
using HeadForSuccess;

namespace DatabaseTest
{
    [TestFixture]
    public class TestSample
    {
        [Test]
        public void Pass()
        {
            Assert.True(true);
        }

        [Test]
        public void Fail()
        {
            Assert.False(true);
        }

        [Test]
        [Ignore("another time")]
        public void Ignore()
        {
            Assert.True(false);
        }
    }
}