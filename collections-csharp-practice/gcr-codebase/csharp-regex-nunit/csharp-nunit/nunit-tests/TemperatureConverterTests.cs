using class_library;
using NUnit.Framework;
using class_library;

namespace nunit_tests
{
    [TestFixture]
    public class TemperatureConverterTests
    {
        //declare object
        TemperatureConverter converter;

        //runs before every test
        [SetUp]
        public void Setup()
        {
            //create object
            converter = new TemperatureConverter();
        }

        //celsius to fahrenheit test
        [Test]
        public void Celsius_To_Fahrenheit_Test()
        {
            Assert.AreEqual(212, converter.CelsiusToFahrenheit(100));
        }

        //fahrenheit to celsius test
        [Test]
        public void Fahrenheit_To_Celsius_Test()
        {
            Assert.AreEqual(0, converter.FahrenheitToCelsius(32));
        }
    }
}
