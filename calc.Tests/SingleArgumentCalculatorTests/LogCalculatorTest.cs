using System;
using calc.SingleArgumentCalculator;
using NUnit.Framework;

namespace calc.Tests.SingleArgumentCalculatorTests
{
    [TestFixture]
    public class LogCalculatorTest
    {
        [TestCase(1, 0, 1.0)]
        [TestCase(0.1, -1, 1.0)]
        [TestCase(0.4, -0.397, 0.001)]
        [TestCase(0.5, -0.301, 0.001)]
        [TestCase(5, 0.698, 0.001)]
        [TestCase(25, 1.397, 0.001)]
       

        public void CalculateTest(double argument, double result, double accuracy)
        {
            var calculator = new LogCalculator();
            var testResult = calculator.Calculate(argument);

            Assert.AreEqual(result, testResult, accuracy);

        }

      
        [Test]
        [ExpectedException(typeof(Exception))]
        public void LogNegativeTest()
        {
            var calculator = new LogCalculator();
            var testResult = calculator.Calculate(-0.1);
        }

    }
    
}