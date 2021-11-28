using Microsoft.VisualStudio.TestTools.UnitTesting;
using EventApplication.Models;
using System;

namespace UserUnitTest2
{
    [TestClass]
    public class UnitTest1
    {
        private const int id = 1;
        private const string email = "bramdiaz@knights.ucf.edu";
        private const string password = "password123";
        private const string firstName = "Bramdon";
        private const string lastName = "Diaz";
        private const string gender = "male";
        private const string phoneNumber = "1234567890";
        private DateTime DOB = new DateTime(2000, 05, 25);
        private const string Interest1 = "outdoors";
        private const string Interest2 = "exercise";
        private const string Interest3 = "water sports";
        [TestMethod]
        public void TestMethod1()
        {
            Users testUser = new Users();

            testUser.Id = 1;
            testUser.Email = "bramdiaz@knights.ucf.edu";
            testUser.Password = "password123";
            testUser.FirstName = "Bramdon";
            testUser.LastName = "Diaz";
            testUser.Gender = "male";
            testUser.PhoneNumber = "1234567890";
            testUser.DOB = new DateTime(2000, 05, 25);
            testUser.Interest1 = "outdoors";
            testUser.Interest2 = "exercise";
            testUser.Interest3 = "water sports";

            Assert.AreEqual(testUser.Id, id);
            Assert.AreEqual(testUser.Email, email);
            Assert.AreEqual(testUser.Password, password);
            Assert.AreEqual(testUser.FirstName, firstName);
            Assert.AreEqual(testUser.LastName, lastName);
            Assert.AreEqual(testUser.Gender, gender);
            Assert.AreEqual(testUser.PhoneNumber, phoneNumber);
            Assert.AreEqual(testUser.DOB, DOB);
            Assert.AreEqual(testUser.Interest1, Interest1);
            Assert.AreEqual(testUser.Interest2, Interest2);
            Assert.AreEqual(testUser.Interest3, Interest3);
        }
    }
}