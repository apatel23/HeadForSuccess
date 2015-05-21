using System;
using NUnit.Framework;
using HeadForSuccess.Database;
using SQLite;

namespace HeadForSuccess
{
    [TestFixture]
    public class UnitTests
    {
        Database test = new Database();
        [Test]
        public void insertDBTest()
        {
            test.addAthlete("Kyle");
            AssertTrue("Kyle", "Kyle");
        }

    }
}