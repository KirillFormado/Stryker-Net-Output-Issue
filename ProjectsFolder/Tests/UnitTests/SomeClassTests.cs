using System;
using MainLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class SomeClassTests
    {
        [TestMethod]
        public void TestAdd()
        {
            var result = SomeClass.Add(11, 12);
            Assert.AreEqual(23, result);
        }
    }
}
