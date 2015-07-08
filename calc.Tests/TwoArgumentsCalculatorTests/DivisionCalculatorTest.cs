using System;
using NUnit.Framework;

namespace calc.TwoArgumentsCalculator
{
    [TestFixture]
    public class DivisionCalculatorTest
    {
        [TestCase(3, 3, 1, 1)]
        [TestCase(1, 3, 0.33, 0.01)]
        [TestCase(-5, 5, -1, 1)]
        public void CalculateTest(double valueOne, double valueTwo, double result, double accuracy)
        {
            var calculator = new DivisionCalculator();
            var testResult = calculator.Calculate(valueOne, valueTwo);


            Assert.AreEqual(testResult, result, accuracy);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void DivisionZero()
        {
            var calculator = new DivisionCalculator();
            calculator.Calculate(5, 0);
        }
    }
}