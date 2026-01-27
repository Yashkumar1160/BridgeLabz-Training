using class_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ms_tests
{
    [TestClass]
    public class UserRegistrationTests
    {
        UserRegistration registration;

        //runs before every test
        [TestInitialize]
        public void Setup()
        {
            registration = new UserRegistration();
        }

        //valid user registration test
        [TestMethod]
        public void Valid_User_Test()
        {
            registration.RegisterUser("yash", "yash@gmail.com", "12345");
        }

        //invalid username test
        [TestMethod]
        public void Invalid_Username_Test()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                registration.RegisterUser("", "yash@gmail.com", "12345");
            });
        }
    }
}
