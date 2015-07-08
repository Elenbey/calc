using System;
using calc.SingleArgumentCalcs;
using NUnit.Framework;

namespace calc.Tests.SingleArgumentCalcs
{
    [TestFixture]
    public class SinCalculatorTest
    {
        [TestCase(0, 0, 1.0)]
        [TestCase(0.1, 0.099, 0.001)]
        [TestCase(0.5, 0.479, 0.001)]
        [TestCase(1, 0.841, 0.001)]
        [TestCase(-0.1, -0.099, 0.001)]
        [TestCase(-0.5, -0.479, 0.001)]
        public void CalculateTest(double argument, double result, double accuracy)
        {
            var calculator = new SinCalculator();
            var testResult = calculator.Calculate(argument);

            Assert.AreEqual(testResult, result, accuracy);

        }
    }
}