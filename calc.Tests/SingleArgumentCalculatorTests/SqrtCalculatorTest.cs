using System;
using calc.SingleArgumentCalculator;
using NUnit.Framework;

namespace calc.Tests.SingleArgumentCalculatorTests
{
    [TestFixture]
    public class SqrtCalculatorTest
    {
        [TestCase(1, 1, 1.0)]
        [TestCase(0.1, 0.316, 0.001)]
        [TestCase(4, 2, 1.0)]
        [TestCase(0.5, 0.707, 0.001)]
        [TestCase(0, 0, 1.0)]
        [TestCase(25, 5, 1)]


        public void CalculateTest(double argument, double result, double accuracy)
        {
            var calculator = new SqrtCalculator();
            var testResult = calculator.Calculate(argument);

            Assert.AreEqual(testResult, result, accuracy);

        }


        [Test]
        [ExpectedException(typeof(Exception))]
        public void SqrtNegativeTest()
        {
            var calculator = new SqrtCalculator();
            var testResult = calculator.Calculate(-0.1);
        }

    }

}