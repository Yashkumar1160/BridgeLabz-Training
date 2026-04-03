    using class_library;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    namespace ms_tests
    {
        [TestClass]
        public class CalculatorTests
        {
            Calculator calc;

            //runs before every test
            [TestInitialize]
            public void Setup()
            {
                calc = new Calculator();
            }

            //add test
            [TestMethod]
            public void Add_Test()
            {
                Assert.AreEqual(15, calc.Add(10, 5));
            }

            //subtract test
            [TestMethod]
            public void Subtract_Test()
            {
                Assert.AreEqual(5, calc.Subtract(10, 5));
            }

            //multiply test
            [TestMethod]
            public void Multiply_Test()
            {
                Assert.AreEqual(50, calc.Multiply(10, 5));
            }

            //divide test
            [TestMethod]
            public void Divide_Test()
            {
                Assert.AreEqual(2, calc.Divide(10, 5));
            }

            //divide by zero test
            [TestMethod]
            public void Divide_By_Zero_Test()
            {
                Assert.Throws<DivideByZeroException>(() =>
                {
                    calc.Divide(10, 0);
                });
            }

        }
    }
