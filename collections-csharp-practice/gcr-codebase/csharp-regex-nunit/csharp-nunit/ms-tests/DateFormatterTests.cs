using class_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ms_tests
{
    [TestClass]
    public class DateFormatterTests
    {
        DateFormatter formatter;

        //runs before every test
        [TestInitialize]
        public void Setup()
        {
            formatter = new DateFormatter();
        }

        //valid date test
        [TestMethod]
        public void Valid_Date_Test()
        {
            Assert.AreEqual("10-08-2024", formatter.FormatDate("2024-08-10"));
        }

        //invalid date test
        [TestMethod]
        public void Invalid_Date_Test()
        {
            Assert.Throws<FormatException>(() =>
            {
                formatter.FormatDate("10-08-2024");
            });
        }
    }
}
