using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HeadForSuccess;
using SQLite;

namespace DatabaseTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void addToDbtest()
        {
            Database testdb = new Database();
            testdb.addAthlete("Kyle");
            Assert.AreEqual("Kyle", testdb.getAthlete("Kyle").Name);
        }
    }
}
