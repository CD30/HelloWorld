using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldClass;

namespace HelloWorldClassTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t = new Hi();

            Assert.AreNotEqual(t.result("POEF"), "WORLD");

        }
        [TestMethod]
        public void TestMethod2()
        {
            var t = new Hi();

            Assert.AreEqual(t.result("HELLO"), "WORLD");

        }
    }
}
