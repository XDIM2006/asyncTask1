using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCount()
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken Token = cts.Token;
            Assert.AreEqual(55, Program.Count(10, Token));
            Assert.AreEqual(500500, Program.Count(1000, Token));
            Assert.AreEqual(500000500000, Program.Count(1000000, Token));
        }
        [TestMethod]
        public void TestStart()
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken Token = cts.Token;
            Assert.AreEqual("userNumber=1000 sumUserNumber=500500", Program.GetCounter("1000", Token));
            Assert.AreEqual("userNumber=1000000 sumUserNumber=500000500000", Program.GetCounter("1000000", Token));
        }
    }
}
