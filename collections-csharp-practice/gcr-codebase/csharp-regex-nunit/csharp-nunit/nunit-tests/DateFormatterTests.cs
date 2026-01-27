using class_library;
using NUnit.Framework;
using System;

namespace nunit_tests
{
    [TestFixture]
    public class DateFormatterTests
    {
        DateFormatter formatter;

        //runs before every test
        [SetUp]
        public void Setup()
        {
            formatter = new DateFormatter();
        }

        //valid date test
        [Test]
        public void Valid_Date_Test()
        {
            Assert.AreEqual("10-08-2024", formatter.FormatDate("2024-08-10"));
        }

        //invalid date test
        [Test]
        public void Invalid_Date_Test()
        {
            Assert.Throws<FormatException>(() =>
            {
                formatter.FormatDate("10-08-2024");
            });
        }
    }
}
