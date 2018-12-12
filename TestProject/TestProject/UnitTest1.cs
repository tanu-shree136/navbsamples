using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        private TestContext testContextInstance;

        public TestContext TestContext
        {
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
        }
        [TestMethod]
        public void TestMethod1()
        {
            this.TestContext.AddResultFile("D:/LogStore0.zip"); 
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(true);
        }
    }
}
