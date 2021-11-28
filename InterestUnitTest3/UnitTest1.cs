using Microsoft.VisualStudio.TestTools.UnitTesting;
using EventApplication.Models;

namespace InterestUnitTest3
{
    [TestClass]
    public class UnitTest1
    {

        private const int id = 30;
        private const string category = "indoor";
        private const string subcategory = "exercise";
        private const string name = "dance";

        [TestMethod]
        public void TestMethod1()
        {
            Interests testInterest = new Interests();

            testInterest.Id = 30;
            testInterest.Category = "indoor";
            testInterest.SubCategory = "exercise";
            testInterest.Name = "dance";

            Assert.AreEqual(id, testInterest.Id);
            Assert.AreEqual(category, testInterest.Category);
            Assert.AreEqual(subcategory, testInterest.SubCategory);
            Assert.AreEqual(name, testInterest.Name);
        }
    }
}