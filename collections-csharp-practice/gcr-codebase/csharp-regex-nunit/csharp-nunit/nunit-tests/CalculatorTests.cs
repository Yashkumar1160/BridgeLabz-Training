using class_library;
using NUnit.Framework;
using System;

namespace nunit_tests
{
    [TestFixture]
    public class CalculatorTests
    {
        //object 
        Calculator calc;

        //runs before every test
        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        //add test
        [Test]
        public void Add_Test()
        {
            Assert.AreEqual(15, calc.Add(10, 5));
        }


        //subtract test
        [Test]
        public void Subtract_Test()
        {
            Assert.AreEqual(5, calc.Subtract(10, 5));
        }

        //multiply test
        [Test]
        public void Multiply_Test()
        {
            Assert.AreEqual(50, calc.Multiply(10, 5));
        }

        //divide test
        [Test]
        public void Divide_Test()
        {
            Assert.AreEqual(2, calc.Divide(10, 5));
        }

        //exception test
        [Test]
        public void Divide_By_Zero_Test()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                calc.Divide(10, 0);
            });
        }
    }
}
