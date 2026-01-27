using class_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using class_library;

namespace ms_tests
{
    [TestClass]
    public class TemperatureConverterTests
    {
        //declare object
        TemperatureConverter converter;

        //runs before every test
        [TestInitialize]
        public void Setup()
        {
            //create object
            converter = new TemperatureConverter();
        }

        //celsius to fahrenheit test
        [TestMethod]
        public void Celsius_To_Fahrenheit_Test()
        {
            Assert.AreEqual(212, converter.CelsiusToFahrenheit(100));
        }

        //fahrenheit to celsius test
        [TestMethod]
        public void Fahrenheit_To_Celsius_Test()
        {
            Assert.AreEqual(0, converter.FahrenheitToCelsius(32));
        }
    }
}
