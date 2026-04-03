using Microsoft.VisualStudio.TestTools.UnitTesting;
using class_library;

namespace ms_tests
{
    [TestClass]
    public class PasswordValidatorTests
    {
        //object
        PasswordValidator validator;

        //runs before each test
        [TestInitialize]
        public void Setup()
        {
            validator = new PasswordValidator();
        }

        //valid password test
        [TestMethod]
        public void Valid_Password_Test()
        {
            Assert.IsTrue(validator.IsValid("Password1234"));
        }

        //invalid password test
        [TestMethod]
        public void Invalid_Password_Test()
        {
            Assert.IsFalse(validator.IsValid("pass"));
        }
    }
}
