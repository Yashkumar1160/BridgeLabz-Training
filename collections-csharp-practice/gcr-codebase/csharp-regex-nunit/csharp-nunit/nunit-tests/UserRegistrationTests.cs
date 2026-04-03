using class_library;
using NUnit.Framework;
using System;

namespace nunit_tests
{
    [TestFixture]
    public class UserRegistrationTests
    {
        //declare object
        UserRegistration registration;

        //runs before every test
        [SetUp]
        public void Setup()
        {
            //create object
            registration = new UserRegistration();
        }

        //valid user registration test
        [Test]
        public void Valid_User_Test()
        {
            registration.RegisterUser("yash", "yash@gmail.com", "12345");
        }

        //invalid email test
        [Test]
        public void Invalid_Email_Test()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                registration.RegisterUser("yash", "yashgmail.com", "12345");
            });
        }
    }
}
