﻿using calc.TwoArgumentsCalculator;
using NUnit.Framework;

namespace calc.Tests.TwoArgumentsCalculatorTests
{
    [TestFixture]
    public class SubtractionCalculatorTest
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, -1)]
        [TestCase(-7, -2, -5)]
        [TestCase(0.5, 0.3, 0.2)]
        public void CalculateTest(double valueOne, double valueTwo, double result)
        {
            var calculator = new SubtractionCalculator();
            var testResult = calculator.Calculate(valueOne, valueTwo);


            Assert.AreEqual(result, testResult);
        }
    }
}