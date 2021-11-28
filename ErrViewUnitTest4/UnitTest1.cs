using Microsoft.VisualStudio.TestTools.UnitTesting;
using EventApplication.Models;

namespace ErrViewUnitTest4
{
    [TestClass]
    public class UnitTest1
    {
        private const bool requestIdExist = true;

        [TestMethod]
        public void TestMethod1()
        {
            ErrorViewModel test = new ErrorViewModel();
            test.RequestId = "20";
            bool testBool = test.ShowRequestId;

            Assert.AreEqual(testBool, requestIdExist);
        }
    }
}