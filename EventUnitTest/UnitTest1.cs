using Microsoft.VisualStudio.TestTools.UnitTesting;
using EventApplication.Models;

namespace EventUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private const int id = 20;
        private const string name = "Dance";
        private const string location = "Orlando";
        private const string time = "12:30 pm";
        private const string date = "11/29/2021";
        private const string status = "Not started";
        private const string attendees = "14";
        private const string category = "exercise";

        [TestMethod]
        public void TestMethod1()
        {
            Events testEvents = new Events();
            testEvents.Id = 20;
            testEvents.Name = "Dance";
            testEvents.Location = "Orlando";
            testEvents.Time = "12:30 pm";
            testEvents.Date = "11/29/2021";
            testEvents.Status = "Not started";
            testEvents.Attendees = "14";
            testEvents.Category = "exercise";



            Assert.AreEqual(id, testEvents.Id);
            Assert.AreEqual(name, testEvents.Name);
            Assert.AreEqual(testEvents.Location, location);
            Assert.AreEqual(time, testEvents.Time);
            Assert.AreEqual(date, testEvents.Date);
            Assert.AreEqual(status, testEvents.Status);
            Assert.AreEqual(attendees, testEvents.Attendees);
            Assert.AreEqual(category, testEvents.Category);
        }
    }
}