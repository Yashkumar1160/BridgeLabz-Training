using NUnit.Framework;
using class_library;

namespace nunit_tests
{
    [TestFixture]
    public class PasswordValidatorTests
    {
        //declare object
        PasswordValidator validator;

        //runs before every test
        [SetUp]
        public void Setup()
        {
            //create object
            validator = new PasswordValidator();
        }

        //valid password test
        [Test]
        public void Valid_Password_Test()
        {
            Assert.IsTrue(validator.IsValid("Password1"));
        }

        //invalid password test
        [Test]
        public void Invalid_Password_Test()
        {
            Assert.IsFalse(validator.IsValid("pass"));
        }
    }
}
