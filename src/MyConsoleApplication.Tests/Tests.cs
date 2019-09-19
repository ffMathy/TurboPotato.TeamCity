using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace MyConsoleApplication.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [TestCategory("Unit")]
        public void MyUnitTest()
        {
        }

        [TestMethod]
        [TestCategory("Integration")]
        public void MyIntegrationTest()
        {
            Thread.Sleep(60000);
        }

        [TestMethod]
        [TestCategory("UI")]
        public void MyUITest()
        {
            Thread.Sleep(60000 * 3);
        }
    }
}
