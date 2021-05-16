using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
          int result = ClassLibraryPractice.Class1.Addition(10, 5);
            Assert.AreEqual(result, 15);
        }
    }
}
